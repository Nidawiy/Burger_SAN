namespace Burger_SAN
{
    partial class UserProfileForm
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCacel = new System.Windows.Forms.Button();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(185, 350);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(134, 22);
            this.txtEmail.TabIndex = 33;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(185, 293);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(134, 22);
            this.txtPhone.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "New Password";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(185, 195);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(134, 22);
            this.txtNewPassword.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "FullName";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(185, 82);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(134, 22);
            this.txtUsername.TabIndex = 26;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(185, 138);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(134, 22);
            this.txtOldPassword.TabIndex = 25;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(185, 29);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(134, 22);
            this.txtFullName.TabIndex = 24;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(51, 138);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(91, 16);
            this.lblPassword.TabIndex = 23;
            this.lblPassword.Text = "Old Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(51, 85);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(70, 16);
            this.lblUsername.TabIndex = 22;
            this.lblUsername.Text = "Username";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(137, 398);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 40);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCacel
            // 
            this.btnCacel.Location = new System.Drawing.Point(335, 398);
            this.btnCacel.Name = "btnCacel";
            this.btnCacel.Size = new System.Drawing.Size(128, 40);
            this.btnCacel.TabIndex = 35;
            this.btnCacel.Text = "Cancel";
            this.btnCacel.UseVisualStyleBackColor = true;
            this.btnCacel.Click += new System.EventHandler(this.btnCacel_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(185, 245);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(134, 22);
            this.txtConfirmPassword.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Confirm Password";
            // 
            // UserProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.btnCacel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Name = "UserProfileForm";
            this.Text = "UserProfileForm";
            this.Load += new System.EventHandler(this.UserProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCacel;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label5;
    }
}