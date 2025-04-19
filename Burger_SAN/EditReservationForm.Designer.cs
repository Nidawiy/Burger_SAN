namespace Burger_SAN
{
    partial class EditReservationForm
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
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.numericGuests = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numericGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(134, 216);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(358, 118);
            this.txtNotes.TabIndex = 14;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(117, 96);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(265, 22);
            this.dtpDate.TabIndex = 13;
            // 
            // numericGuests
            // 
            this.numericGuests.Location = new System.Drawing.Point(117, 49);
            this.numericGuests.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericGuests.Name = "numericGuests";
            this.numericGuests.Size = new System.Drawing.Size(253, 22);
            this.numericGuests.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(383, 374);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 39);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Calcel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(54, 374);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 39);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(117, 154);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(128, 22);
            this.dtpTime.TabIndex = 9;
            // 
            // EditReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.numericGuests);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpTime);
            this.Name = "EditReservationForm";
            this.Text = "EditReservationForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericGuests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.NumericUpDown numericGuests;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpTime;
    }
}