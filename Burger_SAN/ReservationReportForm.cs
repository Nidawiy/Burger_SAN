using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace Burger_SAN
{
    public partial class ReservationReportForm : Form
    {
        private DataTable reportData;

        public ReservationReportForm(DataTable data)
        {
            InitializeComponent();
            reportData = data;
        }

        private void ReservationReportForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Rows received: " + reportData.Rows.Count); // اختبار
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportPath = "ReservationsReport.rdlc";

            ReportDataSource rds = new ReportDataSource("ReservationsDataSet", reportData);
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
