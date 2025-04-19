namespace Burger_SAN
{
    partial class AdminDashboard
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
            this.grpManageEmployees = new System.Windows.Forms.GroupBox();
            this.txtSearchUsername = new System.Windows.Forms.TextBox();
            this.txtSearchPhone = new System.Windows.Forms.TextBox();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.btnReloadEmployees = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.grpReservationReports = new System.Windows.Forms.GroupBox();
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.btnAllReservations = new System.Windows.Forms.Button();
            this.btnDailyReport = new System.Windows.Forms.Button();
            this.btnWeeklyReport = new System.Windows.Forms.Button();
            this.grpSystemSettings = new System.Windows.Forms.GroupBox();
            this.lblCurrentCapacity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudMaxCapacity = new System.Windows.Forms.NumericUpDown();
            this.btnUpdateCapacity = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.grpManageEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.grpReservationReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.grpSystemSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // grpManageEmployees
            // 
            this.grpManageEmployees.Controls.Add(this.txtSearchUsername);
            this.grpManageEmployees.Controls.Add(this.txtSearchPhone);
            this.grpManageEmployees.Controls.Add(this.txtSearchName);
            this.grpManageEmployees.Controls.Add(this.btnReloadEmployees);
            this.grpManageEmployees.Controls.Add(this.dgvEmployees);
            this.grpManageEmployees.Controls.Add(this.btnDeleteEmployee);
            this.grpManageEmployees.Controls.Add(this.btnEditEmployee);
            this.grpManageEmployees.Controls.Add(this.btnAddEmployee);
            this.grpManageEmployees.Location = new System.Drawing.Point(26, -1);
            this.grpManageEmployees.Name = "grpManageEmployees";
            this.grpManageEmployees.Size = new System.Drawing.Size(728, 156);
            this.grpManageEmployees.TabIndex = 0;
            this.grpManageEmployees.TabStop = false;
            // 
            // txtSearchUsername
            // 
            this.txtSearchUsername.Location = new System.Drawing.Point(422, 8);
            this.txtSearchUsername.Name = "txtSearchUsername";
            this.txtSearchUsername.Size = new System.Drawing.Size(160, 22);
            this.txtSearchUsername.TabIndex = 9;
            // 
            // txtSearchPhone
            // 
            this.txtSearchPhone.Location = new System.Drawing.Point(256, 36);
            this.txtSearchPhone.Name = "txtSearchPhone";
            this.txtSearchPhone.Size = new System.Drawing.Size(160, 22);
            this.txtSearchPhone.TabIndex = 8;
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(256, 8);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(160, 22);
            this.txtSearchName.TabIndex = 7;
            // 
            // btnReloadEmployees
            // 
            this.btnReloadEmployees.Location = new System.Drawing.Point(131, 32);
            this.btnReloadEmployees.Name = "btnReloadEmployees";
            this.btnReloadEmployees.Size = new System.Drawing.Size(119, 25);
            this.btnReloadEmployees.TabIndex = 6;
            this.btnReloadEmployees.Text = "Reload";
            this.btnReloadEmployees.UseVisualStyleBackColor = true;
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(15, 59);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.RowTemplate.Height = 24;
            this.dgvEmployees.Size = new System.Drawing.Size(712, 96);
            this.dgvEmployees.TabIndex = 3;
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(131, 7);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(119, 25);
            this.btnDeleteEmployee.TabIndex = 2;
            this.btnDeleteEmployee.Text = "Delete Employee";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Location = new System.Drawing.Point(6, 32);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(119, 25);
            this.btnEditEmployee.TabIndex = 1;
            this.btnEditEmployee.Text = "Edit Employee";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(6, 7);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(119, 25);
            this.btnAddEmployee.TabIndex = 0;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // grpReservationReports
            // 
            this.grpReservationReports.Controls.Add(this.btnShowReport);
            this.grpReservationReports.Controls.Add(this.dgvReservations);
            this.grpReservationReports.Controls.Add(this.btnAllReservations);
            this.grpReservationReports.Controls.Add(this.btnDailyReport);
            this.grpReservationReports.Controls.Add(this.btnWeeklyReport);
            this.grpReservationReports.Location = new System.Drawing.Point(26, 161);
            this.grpReservationReports.Name = "grpReservationReports";
            this.grpReservationReports.Size = new System.Drawing.Size(728, 272);
            this.grpReservationReports.TabIndex = 1;
            this.grpReservationReports.TabStop = false;
            // 
            // dgvReservations
            // 
            this.dgvReservations.AllowUserToAddRows = false;
            this.dgvReservations.AllowUserToDeleteRows = false;
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.Location = new System.Drawing.Point(10, 77);
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.ReadOnly = true;
            this.dgvReservations.RowHeadersWidth = 51;
            this.dgvReservations.RowTemplate.Height = 24;
            this.dgvReservations.Size = new System.Drawing.Size(712, 189);
            this.dgvReservations.TabIndex = 10;
           // 
            // btnAllReservations
            // 
            this.btnAllReservations.Location = new System.Drawing.Point(269, 21);
            this.btnAllReservations.Name = "btnAllReservations";
            this.btnAllReservations.Size = new System.Drawing.Size(147, 50);
            this.btnAllReservations.TabIndex = 5;
            this.btnAllReservations.Text = "All Reservations";
            this.btnAllReservations.UseVisualStyleBackColor = true;
            this.btnAllReservations.Click += new System.EventHandler(this.btnAllReservations_Click);
            // 
            // btnDailyReport
            // 
            this.btnDailyReport.Location = new System.Drawing.Point(27, 21);
            this.btnDailyReport.Name = "btnDailyReport";
            this.btnDailyReport.Size = new System.Drawing.Size(117, 50);
            this.btnDailyReport.TabIndex = 3;
            this.btnDailyReport.Text = "Daily Report";
            this.btnDailyReport.UseVisualStyleBackColor = true;
            this.btnDailyReport.Click += new System.EventHandler(this.btnDailyReport_Click);
            // 
            // btnWeeklyReport
            // 
            this.btnWeeklyReport.Location = new System.Drawing.Point(150, 21);
            this.btnWeeklyReport.Name = "btnWeeklyReport";
            this.btnWeeklyReport.Size = new System.Drawing.Size(111, 50);
            this.btnWeeklyReport.TabIndex = 4;
            this.btnWeeklyReport.Text = "Weekly Report";
            this.btnWeeklyReport.UseVisualStyleBackColor = true;
            this.btnWeeklyReport.Click += new System.EventHandler(this.btnWeeklyReport_Click);
            // 
            // grpSystemSettings
            // 
            this.grpSystemSettings.Controls.Add(this.lblCurrentCapacity);
            this.grpSystemSettings.Controls.Add(this.label1);
            this.grpSystemSettings.Controls.Add(this.nudMaxCapacity);
            this.grpSystemSettings.Controls.Add(this.btnUpdateCapacity);
            this.grpSystemSettings.Location = new System.Drawing.Point(32, 474);
            this.grpSystemSettings.Name = "grpSystemSettings";
            this.grpSystemSettings.Size = new System.Drawing.Size(728, 111);
            this.grpSystemSettings.TabIndex = 1;
            this.grpSystemSettings.TabStop = false;
            // 
            // lblCurrentCapacity
            // 
            this.lblCurrentCapacity.AutoSize = true;
            this.lblCurrentCapacity.Location = new System.Drawing.Point(431, 37);
            this.lblCurrentCapacity.Name = "lblCurrentCapacity";
            this.lblCurrentCapacity.Size = new System.Drawing.Size(0, 16);
            this.lblCurrentCapacity.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "تعديل الطاقة الاستيعابية";
            // 
            // nudMaxCapacity
            // 
            this.nudMaxCapacity.Location = new System.Drawing.Point(15, 45);
            this.nudMaxCapacity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMaxCapacity.Name = "nudMaxCapacity";
            this.nudMaxCapacity.Size = new System.Drawing.Size(74, 22);
            this.nudMaxCapacity.TabIndex = 7;
            // 
            // btnUpdateCapacity
            // 
            this.btnUpdateCapacity.Location = new System.Drawing.Point(160, 30);
            this.btnUpdateCapacity.Name = "btnUpdateCapacity";
            this.btnUpdateCapacity.Size = new System.Drawing.Size(187, 50);
            this.btnUpdateCapacity.TabIndex = 5;
            this.btnUpdateCapacity.Text = "Update Capacity";
            this.btnUpdateCapacity.UseVisualStyleBackColor = true;
            this.btnUpdateCapacity.Click += new System.EventHandler(this.btnUpdateCapacity_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(607, 584);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(187, 50);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnShowReport
            // 
            this.btnShowReport.Location = new System.Drawing.Point(445, 19);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(196, 51);
            this.btnShowReport.TabIndex = 11;
            this.btnShowReport.Text = "Show Report";
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 953);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.grpReservationReports);
            this.Controls.Add(this.grpSystemSettings);
            this.Controls.Add(this.grpManageEmployees);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.grpManageEmployees.ResumeLayout(false);
            this.grpManageEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.grpReservationReports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            this.grpSystemSettings.ResumeLayout(false);
            this.grpSystemSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxCapacity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpManageEmployees;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.GroupBox grpReservationReports;
        private System.Windows.Forms.Button btnDailyReport;
        private System.Windows.Forms.Button btnWeeklyReport;
        private System.Windows.Forms.GroupBox grpSystemSettings;
        private System.Windows.Forms.Button btnUpdateCapacity;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAllReservations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudMaxCapacity;
        private System.Windows.Forms.Label lblCurrentCapacity;
        private System.Windows.Forms.TextBox txtSearchUsername;
        private System.Windows.Forms.TextBox txtSearchPhone;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Button btnReloadEmployees;
        private System.Windows.Forms.DataGridView dgvReservations;
        private System.Windows.Forms.Button btnShowReport;
    }
}