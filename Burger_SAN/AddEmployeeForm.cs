using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Burger_SAN
{
    public partial class AddEmployeeForm : Form
    {
        DBConnection db = new DBConnection();

        private bool isEditMode = false;
        private int employeeId = -1;

        // Constructor للإضافة
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        // Constructor للتعديل
        public AddEmployeeForm(int userId, string fullName, string phone, string email, string username)
        {
            InitializeComponent();
            isEditMode = true;
            employeeId = userId;

            txtFullName.Text = fullName;
            txtPhone.Text = phone;
            txtEmail.Text = email;
            txtUsername.Text = username;

            // لا حاجة لكلمة المرور في التعديل
            txtPassword.Enabled = false;
            txtPassword.Text = "(unchanged)";
        }

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(username) ||
                (!isEditMode && string.IsNullOrEmpty(password)))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            try
            {
                db.OpenConnection();

                if (isEditMode)
                {
                    // تعديل الموظف
                    string updateQuery = @"UPDATE Users SET FullName=@name, Phone=@phone, Email=@mail, Username=@username 
                                           WHERE UserID=@id";
                    MySqlCommand cmd = new MySqlCommand(updateQuery, db.GetConnection());
                    cmd.Parameters.AddWithValue("@name", fullName);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@mail", email);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@id", employeeId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee updated successfully!");
                }
                else
                {
                    // تحقق من عدم تكرار اسم المستخدم
                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @username";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, db.GetConnection());
                    checkCmd.Parameters.AddWithValue("@username", username);

                    int exists = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (exists > 0)
                    {
                        MessageBox.Show("Username already exists.");
                        return;
                    }

                    // إضافة الموظف
                    string insertQuery = @"INSERT INTO Users (FullName, Phone, Email, Username, PasswordHash, Role) 
                                           VALUES (@name, @phone, @mail, @username, @password, 'Employee')";
                    MySqlCommand cmd = new MySqlCommand(insertQuery, db.GetConnection());
                    cmd.Parameters.AddWithValue("@name", fullName);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@mail", email);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee added successfully!");
                }

                this.Close();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
