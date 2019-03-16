using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garage_Express
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
            groupBoxReports.Controls.Add(btnViewStock);
            groupBoxReports.Controls.Add(btnViewSales);
        }

        private void btnViewStock_Click(object sender, EventArgs e)
        {
            frmStockReport stockReport = new frmStockReport();
            stockReport.Show();
        }

        private void btnViewSales_Click(object sender, EventArgs e)
        {
            frmSalesReport salesReport = new frmSalesReport();
            salesReport.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
