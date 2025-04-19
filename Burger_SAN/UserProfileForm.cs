using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Burger_SAN
{
    public partial class UserProfileForm : Form
    {
        private int userId;
        DBConnection db = new DBConnection();

        public UserProfileForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }


       
     
     

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();
            string oldPassword = txtOldPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (fullName == "" || phone == "" || email == "")
            {
                MessageBox.Show("يرجى ملء جميع الحقول الأساسية.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool wantsToChangePassword = !string.IsNullOrEmpty(oldPassword) || !string.IsNullOrEmpty(newPassword) || !string.IsNullOrEmpty(confirmPassword);

            if (wantsToChangePassword)
            {
                if (oldPassword == "" || newPassword == "" || confirmPassword == "")
                {
                    MessageBox.Show("يرجى ملء جميع حقول كلمة السر.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (newPassword != confirmPassword)
                {
                    MessageBox.Show("كلمة السر الجديدة وتأكيدها غير متطابقين.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    db.OpenConnection();

                    string checkQuery = "SELECT PasswordHash FROM Users WHERE UserID = @userId";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, db.GetConnection());
                    checkCmd.Parameters.AddWithValue("@userId", userId);
                    string currentPassword = checkCmd.ExecuteScalar()?.ToString();

                    if (currentPassword != oldPassword)
                    {
                        db.CloseConnection();
                        MessageBox.Show("كلمة السر القديمة غير صحيحة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string updateQuery = @"UPDATE Users 
                                           SET FullName = @fullName, 
                                               Phone = @phone, 
                                               Email = @email, 
                                               PasswordHash = @newPassword 
                                           WHERE UserID = @userId";

                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, db.GetConnection());
                    updateCmd.Parameters.AddWithValue("@fullName", fullName);
                    updateCmd.Parameters.AddWithValue("@phone", phone);
                    updateCmd.Parameters.AddWithValue("@email", email);
                    updateCmd.Parameters.AddWithValue("@newPassword", newPassword);
                    updateCmd.Parameters.AddWithValue("@userId", userId);

                    updateCmd.ExecuteNonQuery();
                    db.CloseConnection();

                    MessageBox.Show("تم تحديث البيانات وكلمة السر بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    db.CloseConnection();
                    MessageBox.Show("خطأ أثناء التحديث: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    db.OpenConnection();

                    string query = @"UPDATE Users 
                                     SET FullName = @fullName, Phone = @phone, Email = @email 
                                     WHERE UserID = @userId";

                    MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                    cmd.Parameters.AddWithValue("@fullName", fullName);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@userId", userId);

                    cmd.ExecuteNonQuery();
                    db.CloseConnection();

                    MessageBox.Show("تم تحديث الملف الشخصي بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    db.CloseConnection();
                    MessageBox.Show("خطأ أثناء التحديث: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        
        }

        private void btnCacel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserProfileForm_Load(object sender, EventArgs e)
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT Username, FullName, Phone, Email FROM Users WHERE UserID = @userId";

                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@userId", userId);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtUsername.Text = reader["Username"].ToString();
                    txtFullName.Text = reader["FullName"].ToString();
                    txtPhone.Text = reader["Phone"].ToString();
                    txtEmail.Text = reader["Email"].ToString();
                }
                else
                {
                    MessageBox.Show("لم يتم العثور على بيانات المستخدم.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }

                db.CloseConnection();
            }
            catch (Exception ex)
            {
                db.CloseConnection();
                MessageBox.Show("خطأ أثناء تحميل البيانات: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
