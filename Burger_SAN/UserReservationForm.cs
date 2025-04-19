using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Burger_SAN
{
    public partial class UserReservationForm : Form
    {
        private int userId;
        private string userFullName;
        DBConnection db = new DBConnection();


        public UserReservationForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void UserReservationForm_Load(object sender, EventArgs e)
        {
            // التاريخ بتنسيق yyyy-MM-dd باستخدام تقويم
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "yyyy-MM-dd";
            dtpDate.ShowUpDown = false; // يظهر كتقويم

            // الوقت بصيغة HH:mm بدون تقويم
            dtpTime.Format = DateTimePickerFormat.Custom;
            dtpTime.CustomFormat = "HH:mm";
            dtpTime.ShowUpDown = true; // فقط Spin للساعات والدقائق
        }


        private void btnReserve_Click(object sender, EventArgs e)
        {
            const int MAX_CAPACITY = 500;

            int numberOfGuests = (int)numericGuests.Value;
            DateTime resDate = dtpDate.Value.Date;
            TimeSpan resTime = dtpTime.Value.TimeOfDay;
            string notes = txtNotes.Text.Trim();

            if (numberOfGuests <= 0)
            {
                MessageBox.Show("الرجاء إدخال عدد صحيح للضيوف.", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                db.OpenConnection();

                // تحقق من أن الحجز ليس قريبًا جدًا (أقل من 3 ساعات من الآن)
                DateTime now = DateTime.Now;
                DateTime reservationDateTime = resDate.Add(resTime);

                if (reservationDateTime <= now.AddHours(3))
                {
                    db.CloseConnection();
                    MessageBox.Show("لا يمكن الحجز لموعد قريب جدًا.\nيرجى اختيار وقت بعد 3 ساعات على الأقل من الآن.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // استخراج الساعة فقط من وقت الحجز
                int hour = resTime.Hours;

                // التحقق من عدد الأشخاص المحجوزين في نفس التاريخ والساعة
                string checkQuery = @"SELECT IFNULL(SUM(NumberOfGuests), 0)
                              FROM Reservations
                              WHERE ReservationDate = @date
                                AND HOUR(TimeSlot) = @hour
                                AND Status != 'Cancelled'";

                MySqlCommand checkCmd = new MySqlCommand(checkQuery, db.GetConnection());
                checkCmd.Parameters.AddWithValue("@date", resDate);
                checkCmd.Parameters.AddWithValue("@hour", hour);

                int bookedSeats = Convert.ToInt32(checkCmd.ExecuteScalar());
                int remaining = MAX_CAPACITY - bookedSeats;

                if (numberOfGuests > remaining)
                {
                    db.CloseConnection();
                    MessageBox.Show($"نعتذر، لا يمكن حجز {numberOfGuests} مقعد.\nالمقاعد المتوفرة في الساعة {hour}:00 هي: {remaining}", "السعة ممتلئة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // تنفيذ الحجز
                string insertQuery = @"INSERT INTO Reservations 
                               (UserID, TableID, ReservationDate, TimeSlot, NumberOfGuests, Notes, Status, CreatedBy)
                               VALUES (@userID, NULL, @date, @time, @guests, @notes, 'Pending', @createdBy)";

                MySqlCommand cmd = new MySqlCommand(insertQuery, db.GetConnection());
                cmd.Parameters.AddWithValue("@userID", userId);
                cmd.Parameters.AddWithValue("@date", resDate);
                cmd.Parameters.AddWithValue("@time", resTime);
                cmd.Parameters.AddWithValue("@guests", numberOfGuests);
                cmd.Parameters.AddWithValue("@notes", notes);
                cmd.Parameters.AddWithValue("@createdBy", userId);

                cmd.ExecuteNonQuery();
                db.CloseConnection();

                MessageBox.Show("تم تقديم الحجز بنجاح.\nسيتواصل معك الموظف لتأكيد الحجز قبل الموعد.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                new UserDashboardForm(userId,userFullName).Show();

            }
            catch (Exception ex)
            {
                db.CloseConnection();
                MessageBox.Show("حدث خطأ أثناء تنفيذ الحجز: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

    }
}
