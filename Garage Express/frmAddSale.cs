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
    public partial class frmAddSale : Form
    {
        FileStreamer fileStreamer = new FileStreamer();
        List<Sale> sales = new List<Sale>();
        Vehicle vehicle;
        List<Vehicle> vehicles = null;
        public frmAddSale(Vehicle vehicleSelected)
        {
            InitializeComponent();
           
            //set vehicle to the vehicleSelected parsed from the previous form
            vehicle = vehicleSelected;

            groupBoxCustDetails.Controls.Add(lblFirstName);
            groupBoxCustDetails.Controls.Add(txtFirstName);
            groupBoxCustDetails.Controls.Add(lblLastName);
            groupBoxCustDetails.Controls.Add(txtLastName);
            groupBoxCustDetails.Controls.Add(lblBirthDate);
            groupBoxCustDetails.Controls.Add(dateBirthDate);
            groupBoxCustDetails.Controls.Add(lblPhone);
            groupBoxCustDetails.Controls.Add(txtPhone);
            groupBoxCustDetails.Controls.Add(lblAddress);
            groupBoxCustDetails.Controls.Add(txtAddress);
            groupBoxCustDetails.Controls.Add(lblDatePurchase);
            groupBoxCustDetails.Controls.Add(datePurchaseDate);

            vehicles = fileStreamer.ReadVehicle();
            sales = fileStreamer.ReadSale();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clears all the fields
            //sets the date pickers to the current date
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            dateBirthDate.Value = DateTime.Now;
            datePurchaseDate.Value = DateTime.Now;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            int age = DateTime.Now.Date.Year - dateBirthDate.Value.Date.Year;
            //validation
            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtPhone.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (datePurchaseDate.Value > DateTime.Now)
            {
                MessageBox.Show("Purchase Date cannot be a future date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dateBirthDate.Value >= DateTime.Now)
            {
                MessageBox.Show("Birth Date cannot be a future date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (age < 16)
            {
                MessageBox.Show("Customer must be 16 years old or older", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (datePurchaseDate.Value < dateBirthDate.Value)
            {
                MessageBox.Show("Purchase Date cannot be before Birth Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Creates a new Sale object
                //gets textBox and dateTimePicker values and puts them into its contructor 
                Sale sale = new Sale(txtFirstName.Text, txtLastName.Text, dateBirthDate.Value.ToString("dd/MM/yyyy"), txtPhone.Text, txtAddress.Text, vehicle, datePurchaseDate.Value.ToString("dd/MM/yyyy"));
                //Adds the Sale object into the sales list
                sales.Add(sale);
                //Write the array to the file
                fileStreamer.Add_Customer_Sale(sales);
                int count = 0;
                int index = 0;
                //loops through the vehicles list
                foreach (Vehicle v in vehicles)
                {
                    //if the vehicle selected equals to the vehicle from the array
                    if (vehicle.ToString() == v.ToString())
                    {
                        index = count;
                        //remove the vehicle from the file
                        fileStreamer.Delete(v);
                    }
                    count++;
                }
                //remove the vehicle from the list
                vehicles.RemoveAt(index);
                this.Close();
            }
        }
    }
}
