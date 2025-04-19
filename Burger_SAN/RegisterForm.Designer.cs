namespace Burger_SAN
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExit = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(505, 374);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 37);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(162, 150);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(134, 22);
            this.txtPassword.TabIndex = 12;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(162, 41);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(134, 22);
            this.txtFullName.TabIndex = 11;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(28, 150);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(66, 16);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(28, 97);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(70, 16);
            this.lblUsername.TabIndex = 9;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(162, 94);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(134, 22);
            this.txtUsername.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "FullName";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(162, 207);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(134, 22);
            this.txtConfirmPassword.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Confirm Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Phone";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(162, 311);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(134, 22);
            this.txtEmail.TabIndex = 21;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(162, 254);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(134, 22);
            this.txtPhone.TabIndex = 20;
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.Location = new System.Drawing.Point(302, 373);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(120, 38);
            this.btnBackToLogin.TabIndex = 22;
            this.btnBackToLogin.Text = "Back To Login";
            this.btnBackToLogin.UseVisualStyleBackColor = true;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(129, 373);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(120, 38);
            this.btnRegister.TabIndex = 24;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnBackToLogin);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnBackToLogin;
        private System.Windows.Forms.Button btnRegister;
    }
}