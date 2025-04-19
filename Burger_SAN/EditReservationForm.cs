using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burger_SAN
{
    public partial class EditReservationForm: Form
    {

        private int reservationId;
        private int userId;
        private const int MAX_CAPACITY = 500;

        DBConnection db = new DBConnection();

        public EditReservationForm(int reservationId, int userId)
        {
            InitializeComponent();
            this.reservationId = reservationId;
            this.userId = userId;
        }

        private void EditReservationForm_Load(object sender, EventArgs e)
        {
            // تنسيق التاريخ والوقت
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "yyyy-MM-dd";
            dtpTime.Format = DateTimePickerFormat.Custom;
            dtpTime.CustomFormat = "HH:mm";
            dtpTime.ShowUpDown = true;

            numericGuests.Minimum = 1;
            numericGuests.Maximum = 500;

            LoadReservationDetails();
        }

        private void LoadReservationDetails()
        {
            try
            {
                db.OpenConnection();

                string query = @"SELECT ReservationDate, TimeSlot, NumberOfGuests, Notes 
                                 FROM Reservations 
                                 WHERE ReservationID = @id";

                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@id", reservationId);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    dtpDate.Value = Convert.ToDateTime(reader["ReservationDate"]);
                    dtpTime.Value = DateTime.Today.Add((TimeSpan)reader["TimeSlot"]);
                    numericGuests.Value = Convert.ToInt32(reader["NumberOfGuests"]);
                    txtNotes.Text = reader["Notes"].ToString();
                }

                db.CloseConnection();
            }
            catch (Exception ex)
            {
                db.CloseConnection();
                MessageBox.Show("خطأ أثناء تحميل بيانات الحجز: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public EditReservationForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime date = dtpDate.Value.Date;
            TimeSpan time = dtpTime.Value.TimeOfDay;
            int hour = time.Hours;
            int guests = (int)numericGuests.Value;
            string notes = txtNotes.Text.Trim();

            DateTime now = DateTime.Now;
            DateTime selectedDateTime = date.Add(time);

            if (selectedDateTime <= now.AddHours(3))
            {
                MessageBox.Show("لا يمكن تعديل الحجز إلى موعد قريب جدًا من الآن.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                db.OpenConnection();

                // تحقق من الطاقة الاستيعابية
                string checkQuery = @"SELECT IFNULL(SUM(NumberOfGuests), 0)
                                      FROM Reservations
                                      WHERE ReservationDate = @date
                                        AND HOUR(TimeSlot) = @hour
                                        AND Status != 'Cancelled'
                                        AND ReservationID != @currentId";

                MySqlCommand checkCmd = new MySqlCommand(checkQuery, db.GetConnection());
                checkCmd.Parameters.AddWithValue("@date", date);
                checkCmd.Parameters.AddWithValue("@hour", hour);
                checkCmd.Parameters.AddWithValue("@currentId", reservationId);

                int bookedSeats = Convert.ToInt32(checkCmd.ExecuteScalar());
                int remaining = MAX_CAPACITY - bookedSeats;

                if (guests > remaining)
                {
                    db.CloseConnection();
                    MessageBox.Show($"العدد المطلوب يتجاوز السعة.\nالمقاعد المتوفرة لهذه الساعة: {remaining}", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // التعديل الفعلي
                string updateQuery = @"UPDATE Reservations 
                                       SET ReservationDate = @date,
                                           TimeSlot = @time,
                                           NumberOfGuests = @guests,
                                           Notes = @notes
                                       WHERE ReservationID = @id";

                MySqlCommand updateCmd = new MySqlCommand(updateQuery, db.GetConnection());
                updateCmd.Parameters.AddWithValue("@date", date);
                updateCmd.Parameters.AddWithValue("@time", time);
                updateCmd.Parameters.AddWithValue("@guests", guests);
                updateCmd.Parameters.AddWithValue("@notes", notes);
                updateCmd.Parameters.AddWithValue("@id", reservationId);

                updateCmd.ExecuteNonQuery();
                db.CloseConnection();

                MessageBox.Show("تم حفظ التعديلات بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                db.CloseConnection();
                MessageBox.Show("خطأ أثناء التعديل: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
