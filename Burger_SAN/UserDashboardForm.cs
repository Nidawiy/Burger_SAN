using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Burger_SAN
{
    public partial class UserDashboardForm : Form
    {
        private int userId;
        private string userFullName;
        private int currentReservationId = -1;
        DBConnection db = new DBConnection();

        public UserDashboardForm(int userId, string fullName)
        {
            InitializeComponent();
            this.userId = userId;
            this.userFullName = fullName ?? "مستخدم";
        }

        private void UserDashboardForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "مرحبًا، " + userFullName;
            LoadCurrentReservation();
            LoadReservationHistory();
        }

        private void LoadReservationHistory()
        {
            try
            {
                db.OpenConnection();

                string query = @"SELECT ReservationDate, TimeSlot, NumberOfGuests, Status, Notes 
                                 FROM Reservations 
                                 WHERE UserID = @userId
                                 ORDER BY ReservationDate DESC";

                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@userId", userId);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvHistory.DataSource = table;

                // تلوين الصفوف حسب الحالة
                foreach (DataGridViewRow row in dgvHistory.Rows)
                {
                    string status = row.Cells["Status"].Value?.ToString();
                    if (status == "Confirmed")
                        row.DefaultCellStyle.ForeColor = Color.Green;
                    else if (status == "Pending")
                        row.DefaultCellStyle.ForeColor = Color.Orange;
                    else if (status == "Cancelled")
                        row.DefaultCellStyle.ForeColor = Color.Gray;
                }

                db.CloseConnection();
            }
            catch (Exception ex)
            {
                db.CloseConnection();
                MessageBox.Show("خطأ أثناء تحميل سجل الحجوزات: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCurrentReservation()
        {
            try
            {
                db.OpenConnection();

                string query = @"SELECT ReservationID, ReservationDate, TimeSlot, NumberOfGuests, Status, Notes 
                                 FROM Reservations 
                                 WHERE UserID = @userId 
                                   AND Status IN ('Pending', 'Confirmed')
                                 ORDER BY CONCAT(ReservationDate, ' ', TimeSlot) DESC 
                                 LIMIT 1";

                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@userId", userId);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    currentReservationId = Convert.ToInt32(reader["ReservationID"]);
                    lblDate.Text = Convert.ToDateTime(reader["ReservationDate"]).ToString("yyyy-MM-dd");
                    lblTime.Text = reader["TimeSlot"].ToString();
                    lblGuests.Text = reader["NumberOfGuests"].ToString();
                    lblStatus.Text = reader["Status"].ToString();
                    txtNotes.Text = reader["Notes"].ToString();

                    string status = reader["Status"].ToString();
                    lblStatus.ForeColor = status == "Confirmed" ? Color.Green : Color.Orange;
                }
                else
                {
                    currentReservationId = -1;
                    lblDate.Text = "-";
                    lblTime.Text = "-";
                    lblGuests.Text = "-";
                    lblStatus.Text = "لا يوجد حجز نشط";
                    lblStatus.ForeColor = Color.Gray;
                    txtNotes.Text = "";
                }

                db.CloseConnection();
            }
            catch (Exception ex)
            {
                db.CloseConnection();
                MessageBox.Show("خطأ أثناء تحميل الحجز الحالي: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (currentReservationId == -1)
            {
                MessageBox.Show("لا يوجد حجز نشط لإلغائه.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("هل أنت متأكد من أنك تريد إلغاء الحجز الحالي؟",
                                                  "تأكيد الإلغاء",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    db.OpenConnection();

                    string query = @"UPDATE Reservations 
                                     SET Status = 'Cancelled'
                                     WHERE ReservationID = @id";

                    MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                    cmd.Parameters.AddWithValue("@id", currentReservationId);

                    int affected = cmd.ExecuteNonQuery();
                    db.CloseConnection();

                    if (affected > 0)
                    {
                        MessageBox.Show("تم إلغاء الحجز بنجاح.", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCurrentReservation();
                        LoadReservationHistory();
                    }
                    else
                    {
                        MessageBox.Show("فشل في إلغاء الحجز.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    db.CloseConnection();
                    MessageBox.Show("حدث خطأ أثناء إلغاء الحجز: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (currentReservationId == -1)
            {
                MessageBox.Show("لا يوجد حجز لتعديله.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("سيتم تعديل الحجز التالي:\nID = " + currentReservationId,
                            "تأكيد التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);

            EditReservationForm editForm = new EditReservationForm(currentReservationId, userId);
            editForm.FormClosed += (s, args) =>
            {
                LoadCurrentReservation();
                LoadReservationHistory();
            };
            editForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            UserProfileForm profileForm = new UserProfileForm(userId);
            profileForm.ShowDialog();
        }

        private void AddReservation_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserReservationForm(userId).Show();
        }
    }
}
