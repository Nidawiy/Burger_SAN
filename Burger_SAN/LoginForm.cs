using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Burger_SAN
{
    public partial class LoginForm : Form
    {
        DBConnection db = new DBConnection();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();  // إخفاء الفورم الحالي
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter both username and password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                db.OpenConnection();

                string query = "SELECT * FROM Users WHERE Username = @username AND PasswordHash = @password";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password); // لاحقًا استبدلها بـ Hash لو استخدمت تشفير

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string role = reader["Role"].ToString();
                    int userId = Convert.ToInt32(reader["UserID"]);
                    string fullName = reader["FullName"].ToString(); // 👈 جلب الاسم الكامل

                    db.CloseConnection();

                    MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();

                    switch (role)
                    {
                        case "Admin":
                            new AdminDashboard(userId).Show();
                            break;
                        case "Employee":
                            new EmployeeDashboard(userId).Show();
                            break;
                        case "User":
                            new UserDashboardForm(userId, fullName).Show(); // 👈 تمرير الاسم الكامل
                            break;
                        default:
                            MessageBox.Show("Unknown role detected.");
                            break;
                    }
                }
                else
                {
                    db.CloseConnection();
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                db.CloseConnection();
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm();
            forgotPasswordForm.Show();
        }


    }
}
