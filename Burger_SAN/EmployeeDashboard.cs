using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Burger_SAN
{
    public partial class EmployeeDashboard : Form
    {
        DBConnection db = new DBConnection();
        private int userId;

        public EmployeeDashboard(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void EmployeeDashboard_Load(object sender, EventArgs e)
        {
            dtDateFilter.Value = DateTime.Today;

            cmbStatusFilter.Items.Clear();
            cmbStatusFilter.Items.Add("All");
            cmbStatusFilter.Items.Add("Pending");
            cmbStatusFilter.Items.Add("Confirmed");
            cmbStatusFilter.Items.Add("Cancelled");
            cmbStatusFilter.SelectedIndex = 0;

            // فلترة تلقائية عند التغيير
            txtNameSearch.TextChanged += FilterChanged;
            txtPhoneSearch.TextChanged += FilterChanged;
            dtDateFilter.ValueChanged += FilterChanged;
            cmbStatusFilter.SelectedIndexChanged += cmbStatusFilter_SelectedIndexChanged;
            btnReload.Click += (s, ev) => LoadReservations();
            btnLogout.Click += btnLogout_Click;
            btnPrintReport.Click += btnPrintReport_Click;
            dataGridViewReservations.CellContentClick += dataGridViewReservations_CellContentClick;

            LoadReservations();
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            LoadReservations();
        }

        private void LoadReservations()
        {
            try
            {
                db.OpenConnection();

                string query = @"SELECT R.ReservationID, U.FullName, U.Phone, 
                                        R.ReservationDate, R.TimeSlot, 
                                        R.NumberOfGuests, R.Status, R.Notes
                                 FROM Reservations R
                                 JOIN Users U ON R.UserID = U.UserID
                                 WHERE R.ReservationDate = @date";

                if (!string.IsNullOrWhiteSpace(txtNameSearch.Text))
                    query += " AND U.FullName LIKE @name";

                if (!string.IsNullOrWhiteSpace(txtPhoneSearch.Text))
                    query += " AND U.Phone LIKE @phone";

                if (cmbStatusFilter.SelectedItem != null && cmbStatusFilter.SelectedItem.ToString() != "All")
                    query += " AND R.Status = @status";

                query += " ORDER BY R.TimeSlot ASC";

                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@date", dtDateFilter.Value.Date);

                if (!string.IsNullOrWhiteSpace(txtNameSearch.Text))
                    cmd.Parameters.AddWithValue("@name", $"%{txtNameSearch.Text}%");

                if (!string.IsNullOrWhiteSpace(txtPhoneSearch.Text))
                    cmd.Parameters.AddWithValue("@phone", $"%{txtPhoneSearch.Text}%");

                if (cmbStatusFilter.SelectedItem != null && cmbStatusFilter.SelectedItem.ToString() != "All")
                    cmd.Parameters.AddWithValue("@status", cmbStatusFilter.SelectedItem.ToString());

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridViewReservations.DataSource = table;
                lblTotal.Text = $"Total Reservations: {table.Rows.Count}";

                // عدد الضيوف
                int totalGuests = 0;
                foreach (DataRow row in table.Rows)
                {
                    totalGuests += Convert.ToInt32(row["NumberOfGuests"]);
                }
                lblTotalGuests.Text = $"Total Guests: {totalGuests}";

                // إزالة الأعمدة التفاعلية السابقة
                if (dataGridViewReservations.Columns.Contains("Confirm"))
                    dataGridViewReservations.Columns.Remove("Confirm");

                if (dataGridViewReservations.Columns.Contains("Cancel"))
                    dataGridViewReservations.Columns.Remove("Cancel");

                // إضافة أعمدة Confirm / Cancel
                DataGridViewButtonColumn confirmButton = new DataGridViewButtonColumn();
                confirmButton.Name = "Confirm";
                confirmButton.HeaderText = "";
                confirmButton.Text = "Confirm";
                confirmButton.UseColumnTextForButtonValue = true;
                dataGridViewReservations.Columns.Add(confirmButton);

                DataGridViewButtonColumn cancelButton = new DataGridViewButtonColumn();
                cancelButton.Name = "Cancel";
                cancelButton.HeaderText = "";
                cancelButton.Text = "Cancel";
                cancelButton.UseColumnTextForButtonValue = true;
                dataGridViewReservations.Columns.Add(cancelButton);

                // تلوين الصفوف حسب الحالة
                foreach (DataGridViewRow row in dataGridViewReservations.Rows)
                {
                    string status = row.Cells["Status"].Value.ToString();
                    if (status == "Pending")
                        row.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                    else if (status == "Confirmed")
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                    else if (status == "Cancelled")
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                }
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

        private void dataGridViewReservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string reservationId = dataGridViewReservations.Rows[e.RowIndex].Cells["ReservationID"].Value.ToString();

                if (dataGridViewReservations.Columns[e.ColumnIndex].Name == "Confirm")
                {
                    UpdateReservationStatus(reservationId, "Confirmed");
                }
                else if (dataGridViewReservations.Columns[e.ColumnIndex].Name == "Cancel")
                {
                    UpdateReservationStatus(reservationId, "Cancelled");
                }
            }
        }

        private void UpdateReservationStatus(string reservationId, string newStatus)
        {
            try
            {
                db.OpenConnection();
                string query = "UPDATE Reservations SET Status = @status WHERE ReservationID = @id";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@status", newStatus);
                cmd.Parameters.AddWithValue("@id", reservationId);
                cmd.ExecuteNonQuery();

                MessageBox.Show($"Reservation updated to {newStatus}");
                LoadReservations();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating status: " + ex.Message);
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

        private void cmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadReservations();
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("\ud83d\udd27 ميزة الطباعة تحتاج إعداد صفحة للطباعة أو تصدير PDF أولاً.");
            }
        }
    }
}
