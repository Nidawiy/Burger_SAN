namespace Burger_SAN
{
    partial class EmployeeDashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtDateFilter = new System.Windows.Forms.DateTimePicker();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.txtPhoneSearch = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dataGridViewReservations = new System.Windows.Forms.DataGridView();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.cmbStatusFilter = new System.Windows.Forms.ComboBox();
            this.lblTotalGuests = new System.Windows.Forms.Label();
            this.btnPrintReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Today\'s Reservations";
            // 
            // dtDateFilter
            // 
            this.dtDateFilter.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateFilter.Location = new System.Drawing.Point(12, 58);
            this.dtDateFilter.Name = "dtDateFilter";
            this.dtDateFilter.Size = new System.Drawing.Size(128, 22);
            this.dtDateFilter.TabIndex = 5;
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Location = new System.Drawing.Point(12, 4);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(128, 22);
            this.txtNameSearch.TabIndex = 8;
            // 
            // txtPhoneSearch
            // 
            this.txtPhoneSearch.Location = new System.Drawing.Point(12, 29);
            this.txtPhoneSearch.Name = "txtPhoneSearch";
            this.txtPhoneSearch.Size = new System.Drawing.Size(128, 22);
            this.txtPhoneSearch.TabIndex = 9;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(199, 46);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 16);
            this.lblTotal.TabIndex = 10;
            // 
            // dataGridViewReservations
            // 
            this.dataGridViewReservations.AllowUserToAddRows = false;
            this.dataGridViewReservations.AllowUserToDeleteRows = false;
            this.dataGridViewReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservations.Location = new System.Drawing.Point(14, 106);
            this.dataGridViewReservations.Name = "dataGridViewReservations";
            this.dataGridViewReservations.ReadOnly = true;
            this.dataGridViewReservations.RowHeadersWidth = 51;
            this.dataGridViewReservations.RowTemplate.Height = 24;
            this.dataGridViewReservations.Size = new System.Drawing.Size(773, 340);
            this.dataGridViewReservations.TabIndex = 11;
            this.dataGridViewReservations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReservations_CellContentClick);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(180, 4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(144, 38);
            this.btnReload.TabIndex = 12;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            //this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(571, 20);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(144, 38);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // cmbStatusFilter
            // 
            this.cmbStatusFilter.FormattingEnabled = true;
            this.cmbStatusFilter.Items.AddRange(new object[] {
            "All",
            "Pending",
            "Confirmed",
            "Cancelled"});
            this.cmbStatusFilter.Location = new System.Drawing.Point(383, 43);
            this.cmbStatusFilter.Name = "cmbStatusFilter";
            this.cmbStatusFilter.Size = new System.Drawing.Size(162, 24);
            this.cmbStatusFilter.TabIndex = 14;
            this.cmbStatusFilter.SelectedIndexChanged += new System.EventHandler(this.cmbStatusFilter_SelectedIndexChanged);
            // 
            // lblTotalGuests
            // 
            this.lblTotalGuests.AutoSize = true;
            this.lblTotalGuests.Location = new System.Drawing.Point(199, 73);
            this.lblTotalGuests.Name = "lblTotalGuests";
            this.lblTotalGuests.Size = new System.Drawing.Size(0, 16);
            this.lblTotalGuests.TabIndex = 15;
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Location = new System.Drawing.Point(577, 62);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(137, 35);
            this.btnPrintReport.TabIndex = 16;
            this.btnPrintReport.Text = "Print Report";
            this.btnPrintReport.UseVisualStyleBackColor = true;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // EmployeeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.lblTotalGuests);
            this.Controls.Add(this.cmbStatusFilter);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.dataGridViewReservations);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtPhoneSearch);
            this.Controls.Add(this.txtNameSearch);
            this.Controls.Add(this.dtDateFilter);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EmployeeDashboard";
            this.Text = "EmployeeDashboard";
            this.Load += new System.EventHandler(this.EmployeeDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDateFilter;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.TextBox txtPhoneSearch;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dataGridViewReservations;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ComboBox cmbStatusFilter;
        private System.Windows.Forms.Label lblTotalGuests;
        private System.Windows.Forms.Button btnPrintReport;
    }
}