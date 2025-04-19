using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Burger_SAN
{
    public partial class AdminDashboard : Form

    {
        private int userId;
        DBConnection db = new DBConnection();

        public AdminDashboard(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadCurrentCapacity(); // تحميل السعة من قاعدة البيانات
            LoadEmployees();       // تحميل الموظفين عند فتح الفورم

            // ربط الفلاتر
            txtSearchName.TextChanged += FilterChanged;
            txtSearchPhone.TextChanged += FilterChanged;
            txtSearchUsername.TextChanged += FilterChanged;
            btnReloadEmployees.Click += (s, ev) => LoadEmployees();
            btnDailyReport.Click += btnDailyReport_Click;
            btnWeeklyReport.Click += btnWeeklyReport_Click;
            btnAllReservations.Click += btnAllReservations_Click;
        }

        private void LoadEmployees()
        {
            try
            {
                db.OpenConnection();

                string query = @"SELECT UserID, FullName, Phone, Email, Username 
                                 FROM Users 
                                 WHERE Role = 'Employee' 
                                 ORDER BY FullName ASC";

                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvEmployees.DataSource = table;

                // تحسين شكل الأعمدة
                dgvEmployees.Columns["UserID"].HeaderText = "ID";
                dgvEmployees.Columns["FullName"].HeaderText = "Name";
                dgvEmployees.Columns["Phone"].HeaderText = "Phone";
                dgvEmployees.Columns["Email"].HeaderText = "Email";
                dgvEmployees.Columns["Username"].HeaderText = "Username";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employees: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            FilterEmployees();
        }

        private void FilterEmployees()
        {
            try
            {
                db.OpenConnection();

                string query = @"SELECT UserID, FullName, Phone, Email, Username 
                                 FROM Users 
                                 WHERE Role = 'Employee'
                                 AND FullName LIKE @name 
                                 AND Phone LIKE @phone 
                                 AND Username LIKE @username
                                 ORDER BY FullName ASC";

                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@name", "%" + txtSearchName.Text.Trim() + "%");
                cmd.Parameters.AddWithValue("@phone", "%" + txtSearchPhone.Text.Trim() + "%");
                cmd.Parameters.AddWithValue("@username", "%" + txtSearchUsername.Text.Trim() + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvEmployees.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering employees: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeeForm form = new AddEmployeeForm();
            form.ShowDialog();
            LoadEmployees();
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                var row = dgvEmployees.SelectedRows[0];

                int id = Convert.ToInt32(row.Cells["UserID"].Value);
                string name = row.Cells["FullName"].Value.ToString();
                string phone = row.Cells["Phone"].Value.ToString();
                string email = row.Cells["Email"].Value.ToString();
                string username = row.Cells["Username"].Value.ToString();

                AddEmployeeForm form = new AddEmployeeForm(id, name, phone, email, username);
                form.ShowDialog();

                LoadEmployees();
            }
            else
            {
                MessageBox.Show("Please select an employee to edit.");
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this employee?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int employeeId = Convert.ToInt32(dgvEmployees.SelectedRows[0].Cells["UserID"].Value);

                    try
                    {
                        db.OpenConnection();

                        string deleteQuery = "DELETE FROM Users WHERE UserID = @id AND Role = 'Employee'";
                        MySqlCommand cmd = new MySqlCommand(deleteQuery, db.GetConnection());
                        cmd.Parameters.AddWithValue("@id", employeeId);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Employee deleted successfully.");
                        LoadEmployees();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        db.CloseConnection();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to delete.");
            }
        }

        private void btnUpdateCapacity_Click(object sender, EventArgs e)
        {
            SaveNewCapacity(); // تشمل تحديث التسمية أيضًا
        }

        private void LoadCurrentCapacity()
        {
            try
            {
                db.OpenConnection();

                string query = "SELECT SettingValue FROM Settings WHERE SettingKey = 'MaxCapacity'";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

                object result = cmd.ExecuteScalar();
                int capacity = result != null ? Convert.ToInt32(result) : 0;

                lblCurrentCapacity.Text = $"Current Capacity: {capacity}";
                nudMaxCapacity.Value = capacity;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading capacity: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void SaveNewCapacity()
        {
            try
            {
                db.OpenConnection();

                int newCapacity = (int)nudMaxCapacity.Value;

                string query = @"INSERT INTO Settings (SettingKey, SettingValue)
                                 VALUES ('MaxCapacity', @value)
                                 ON DUPLICATE KEY UPDATE SettingValue = @value";

                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@value", newCapacity);
                cmd.ExecuteNonQuery();

                lblCurrentCapacity.Text = $"Current Capacity: {newCapacity}";
                MessageBox.Show("Capacity updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving capacity: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadReservationsByDateRange(DateTime from, DateTime to)
        {
            try
            {
                db.OpenConnection();

                string query = @"SELECT R.ReservationID, U.FullName, R.ReservationDate, R.TimeSlot, 
                                R.NumberOfGuests, R.Status, R.Notes
                         FROM Reservations R
                         JOIN Users U ON R.UserID = U.UserID
                         WHERE R.ReservationDate BETWEEN @from AND @to
                         ORDER BY R.ReservationDate DESC";

                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@from", from.Date);
                cmd.Parameters.AddWithValue("@to", to.Date);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvReservations.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reservations: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void btnDailyReport_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            LoadReservationsByDateRange(today, today);
        }

        private void btnWeeklyReport_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime lastWeek = today.AddDays(-7);
            LoadReservationsByDateRange(lastWeek, today);
        }

        private void btnAllReservations_Click(object sender, EventArgs e)
        {
            // افتراضياً نعرض كل الحجوزات من 5 سنوات مضت
            DateTime from = DateTime.Today.AddYears(-5);
            DateTime to = DateTime.Today;
            LoadReservationsByDateRange(from, to);
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {  
        }


    }
}
