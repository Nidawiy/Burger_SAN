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
    public partial class RegisterForm: Form
    {


        DBConnection db = new DBConnection();

        public RegisterForm()
        {
            InitializeComponent();
        }

     
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string phone = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (fullName == "" || username == "" || password == "" || confirmPassword == "")
            {
                MessageBox.Show("Please fill in all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                db.OpenConnection();

                // التحقق من وجود اسم المستخدم مسبقًا
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @username";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, db.GetConnection());
                checkCmd.Parameters.AddWithValue("@username", username);
                int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (exists > 0)
                {
                    db.CloseConnection();
                    MessageBox.Show("Username already exists. Please choose another.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // إدخال المستخدم الجديد
                string insertQuery = @"INSERT INTO Users (Username, PasswordHash, FullName, Role, Phone, Email) 
                                       VALUES (@username, @password, @fullname, 'User', @phone, @email)";

                MySqlCommand cmd = new MySqlCommand(insertQuery, db.GetConnection());
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);  // لاحقًا استخدم تشفير
                cmd.Parameters.AddWithValue("@fullname", fullName);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);

                cmd.ExecuteNonQuery();
                db.CloseConnection();

                MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                new LoginForm().Show();
            }
            catch (Exception ex)
            {
                db.CloseConnection();
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
