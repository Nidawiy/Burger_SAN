namespace Burger_SAN
{
    partial class UserReservationForm
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
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            this.numericGuests = new System.Windows.Forms.NumericUpDown();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtNotes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(133, 161);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(128, 22);
            this.dtpTime.TabIndex = 2;
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(70, 381);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(110, 39);
            this.btnReserve.TabIndex = 3;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.Location = new System.Drawing.Point(399, 381);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(110, 39);
            this.btnBackToLogin.TabIndex = 5;
            this.btnBackToLogin.Text = "Back To Login";
            this.btnBackToLogin.UseVisualStyleBackColor = true;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // numericGuests
            // 
            this.numericGuests.Location = new System.Drawing.Point(133, 56);
            this.numericGuests.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericGuests.Name = "numericGuests";
            this.numericGuests.Size = new System.Drawing.Size(253, 22);
            this.numericGuests.TabIndex = 6;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(133, 103);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(265, 22);
            this.dtpDate.TabIndex = 7;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(150, 223);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(358, 118);
            this.txtNotes.TabIndex = 8;
            // 
            // UserReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.numericGuests);
            this.Controls.Add(this.btnBackToLogin);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.dtpTime);
            this.Name = "UserReservationForm";
            this.Text = "UserReservationForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericGuests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnBackToLogin;
        private System.Windows.Forms.NumericUpDown numericGuests;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtNotes;
    }
}