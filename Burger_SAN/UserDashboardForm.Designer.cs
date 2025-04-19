namespace Burger_SAN
{
    partial class UserDashboardForm
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
            this.grpCurrentReservation = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblGuests = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.btnProfile = new System.Windows.Forms.Button();
            this.AddReservation = new System.Windows.Forms.Button();
            this.grpCurrentReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(117, 401);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 37);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpCurrentReservation
            // 
            this.grpCurrentReservation.Controls.Add(this.btnCancel);
            this.grpCurrentReservation.Controls.Add(this.btnEdit);
            this.grpCurrentReservation.Controls.Add(this.txtNotes);
            this.grpCurrentReservation.Controls.Add(this.lblDate);
            this.grpCurrentReservation.Controls.Add(this.lblGuests);
            this.grpCurrentReservation.Controls.Add(this.lblTime);
            this.grpCurrentReservation.Controls.Add(this.lblStatus);
            this.grpCurrentReservation.Controls.Add(this.label6);
            this.grpCurrentReservation.Controls.Add(this.label5);
            this.grpCurrentReservation.Controls.Add(this.label3);
            this.grpCurrentReservation.Controls.Add(this.label2);
            this.grpCurrentReservation.Controls.Add(this.label1);
            this.grpCurrentReservation.Location = new System.Drawing.Point(24, 28);
            this.grpCurrentReservation.Name = "grpCurrentReservation";
            this.grpCurrentReservation.Size = new System.Drawing.Size(764, 204);
            this.grpCurrentReservation.TabIndex = 11;
            this.grpCurrentReservation.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(263, 155);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 33);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(93, 155);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(91, 33);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(131, 96);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ReadOnly = true;
            this.txtNotes.Size = new System.Drawing.Size(235, 22);
            this.txtNotes.TabIndex = 10;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(128, 18);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 16);
            this.lblDate.TabIndex = 9;
            // 
            // lblGuests
            // 
            this.lblGuests.AutoSize = true;
            this.lblGuests.Location = new System.Drawing.Point(128, 54);
            this.lblGuests.Name = "lblGuests";
            this.lblGuests.Size = new System.Drawing.Size(0, 16);
            this.lblGuests.TabIndex = 8;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(431, 18);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 16);
            this.lblTime.TabIndex = 7;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(431, 54);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 16);
            this.lblStatus.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "🕒 الوقت:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "📌 الحالة:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = " 📝 الملاحظات:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "👥 العدد:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "📅 التاريخ:";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(646, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 16);
            this.lblWelcome.TabIndex = 14;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 401);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(98, 37);
            this.btnLogout.TabIndex = 16;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Location = new System.Drawing.Point(35, 244);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.RowHeadersWidth = 51;
            this.dgvHistory.RowTemplate.Height = 24;
            this.dgvHistory.Size = new System.Drawing.Size(752, 151);
            this.dgvHistory.TabIndex = 17;
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(221, 401);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(98, 37);
            this.btnProfile.TabIndex = 18;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // AddReservation
            // 
            this.AddReservation.Location = new System.Drawing.Point(325, 401);
            this.AddReservation.Name = "AddReservation";
            this.AddReservation.Size = new System.Drawing.Size(98, 37);
            this.AddReservation.TabIndex = 19;
            this.AddReservation.Text = "Add";
            this.AddReservation.UseVisualStyleBackColor = true;
            this.AddReservation.Click += new System.EventHandler(this.AddReservation_Click);
            // 
            // UserDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddReservation);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.dgvHistory);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.grpCurrentReservation);
            this.Controls.Add(this.btnExit);
            this.Name = "UserDashboardForm";
            this.Text = "UserDashboardForm";
            this.Load += new System.EventHandler(this.UserDashboardForm_Load);
            this.grpCurrentReservation.ResumeLayout(false);
            this.grpCurrentReservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpCurrentReservation;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblGuests;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button AddReservation;
    }
}