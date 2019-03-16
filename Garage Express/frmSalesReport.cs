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
    public partial class frmSalesReport : Form
    {
        FileStreamer fileStreamer = new FileStreamer();
        List<Sale> sales;
        List<String> dates;
        BindingSource bindSource = new BindingSource();
        public frmSalesReport()
        {
            InitializeComponent();

            //get sales list from file
            sales = fileStreamer.ReadSale();

            groupBoxStats.Controls.Add(lblDateSelected);
            groupBoxStats.Controls.Add(lblVehiclesSold);
            groupBoxStats.Controls.Add(lblProfit);

            //get a list of dates from sales made
            this.Get_Dates();
            //populate the combobox with the list of dates
            bindSource.DataSource = dates;
            comboBoxDates.DataSource = bindSource.DataSource;
            lblPurchaseDetails.Visible = false;

        }

        private void Get_Dates()
        {
            string row;
            string[] columns;
            //create a list of Strings
            List<String> tempList = new List<String> {"All"};
            //loop through the sales list
            foreach (Sale s in sales)
            {
                //split the ToString() of each Sale object
                row = s.ToString();
                columns = row.Split(':', '\t');
                
                //add non duplicate dates into the list
                if(!tempList.Contains(columns[25]))
                {
                    tempList.Add(columns[25]);
                }
            }
            //set the dates list with the tempList
            dates = tempList;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxDates_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxSales.Items.Clear();
            lblPurchaseDetails.Visible = false;

            double totalActualPrice = 0.0;
            double totalSalesPrice = 0.0;
            double totalProfit = 0.0;
            int countForTheDay = 0;
            
            //loop through the sales list
            foreach(Sale s in sales)
            {
                //if All is selected
                if(comboBoxDates.SelectedItem.ToString() == "All")
                {
                    //populate listBoxSales with the Sale objects
                    listBoxSales.Items.Add(s.DisplaySummary());
                    //calculate the total actual price of the vehicles
                    totalActualPrice += s.Vehicle.Price;
                    //calculate the total sales price of the vehicles
                    totalSalesPrice += s.Price;
                    //get the number of sales 
                    countForTheDay++;
                }
                //is a particular date is selected
                else if(comboBoxDates.SelectedItem.ToString() == s.DatePurchase)
                { 
                    //populate listBoxSales with Sale objects of that date
                    listBoxSales.Items.Add(s.DisplaySummary());
                    //calculate the total actual price of the vehicles
                    totalActualPrice += s.Vehicle.Price;
                    //calculate the total sales price of the vehicles
                    totalSalesPrice += s.Price;
                    //get the number of sales
                    countForTheDay++;
                }
                
            }
            
            //calculate the totalProfit
            totalProfit = totalSalesPrice - totalActualPrice;
            //display the Date, Total Vehicles sold, total sales and total profit
            lblDateSelected.Text = "Date :" + comboBoxDates.SelectedItem.ToString();
            lblVehiclesSold.Text = "Vehicles Sold :" + countForTheDay;
            lblProfit.Text = "Profit Amount :" + totalProfit.ToString("C");
            lblTotalSales.Text = "Sales Amount :" + totalSalesPrice.ToString("C");
        }

        private void listBoxSales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSales.SelectedItem != null)
            {
                lblPurchaseDetails.Visible = true;

                //loop through the sales list
                foreach (Sale s in sales)
                {
                    //get selected Sale object
                    if (listBoxSales.SelectedItem.ToString().Contains(s.Vehicle.RegNum))
                    {
                        //display details of the selected Sale object
                        lblPurchaseDetails.Text = "Purchase Details : \n\n" + s.DisplayDetails();
                    }
                }
            }
        }
    }
}
