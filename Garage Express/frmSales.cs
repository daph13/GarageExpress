using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garage_Express
{
    public partial class frmSales : Form
    {
        FileStreamer fileStreamer = new FileStreamer();
        List<Vehicle> display = new List<Vehicle>();
        List<Sale> sales = new List<Sale>();
        Vehicle vehicleSelected;
        private double vehicleSalePrice;
        public frmSales()
        {
            InitializeComponent();

            //populates both listboxes
            this.Populate_ListBox();
            //hides all the edit fields
            this.Hide_EditFields();

            groupBoxVehicles.Controls.Add(radioButtonAll);
            groupBoxVehicles.Controls.Add(radioButtonCar);
            groupBoxVehicles.Controls.Add(radioButtonQuad);
            groupBoxVehicles.Controls.Add(radioButtonMotor);

            groupBoxCustDetails.Controls.Add(lblFName);
            groupBoxCustDetails.Controls.Add(txtFName);
            groupBoxCustDetails.Controls.Add(lblLName);
            groupBoxCustDetails.Controls.Add(txtLName);
            groupBoxCustDetails.Controls.Add(lblDOB);
            groupBoxCustDetails.Controls.Add(dateBirthDate);
            groupBoxCustDetails.Controls.Add(lblPhone);
            groupBoxCustDetails.Controls.Add(txtPhone);
            groupBoxCustDetails.Controls.Add(lblDatePurchase);
            groupBoxCustDetails.Controls.Add(datePurchaseDate);
            groupBoxCustDetails.Controls.Add(lblAddress);
            groupBoxCustDetails.Controls.Add(txtAddress);

            radioButtonAll.Checked = true;
            lblSalePrice.Visible = false;

            //calls event when the radiobuttons are checked
            radioButtonAll.CheckedChanged += RadioButton_Changed;
            radioButtonCar.CheckedChanged += RadioButton_Changed;
            radioButtonQuad.CheckedChanged += RadioButton_Changed;
            radioButtonMotor.CheckedChanged += RadioButton_Changed;
        }

        private void RadioButton_Changed(object sender, EventArgs e)
        {
            listBoxVehicles.Items.Clear();
            lblSalePrice.Visible = false;
            RadioButton radioButton = sender as RadioButton;
            //if a radioButton is checked
            if (radioButton.Checked == true)
            {
                //check radioButton text
                switch (radioButton.Text)
                {
                    //if...
                    //All is selected
                    case "All":
                        //loop through the display list of vehicles objects
                        foreach (Vehicle d in display)
                        {
                            //populate listBoxVehicles with all vehicles
                            listBoxVehicles.Items.Add(d.ToString());
                        }
                        break;
                        //Car is selected
                    case "Car":
                        foreach (Vehicle d in display)
                        {
                            //populate listBoxVehicles with only Car objects
                            if (d.ToString().Contains("Car"))
                            {
                                listBoxVehicles.Items.Add(d.ToString());
                            }
                        }
                        break;
                        //Quad Bike is selected
                    case "Quad Bike":
                        foreach (Vehicle d in display)
                        {
                            //populate listBoxVehicles with only QuadBike objects
                            if (d.ToString().Contains("QuadBike"))
                            {
                                listBoxVehicles.Items.Add(d.ToString());
                            }
                        }
                        break;
                        //Motor Bike is selected
                    case "Motor Bike":
                        foreach (Vehicle d in display)
                        {
                            //populate listBoxVehicles with only MotorBike objects
                            if (d.ToString().Contains("MotorBike"))
                            {
                                listBoxVehicles.Items.Add(d.ToString());
                            }
                        }
                        break;
                }
            }
        }


        private void Populate_ListBox()
        {
            //get list of Vehicles from file
            display = fileStreamer.ReadVehicle();
            //get list of Sales from file
            sales = fileStreamer.ReadSale();
            
            //loop through the display list
            foreach(Vehicle v in display)
            {
                //populate listBoxVehicles with Vehicle objects
                listBoxVehicles.Items.Add(v.ToString());
            }

            //loops through the sales list
            foreach(Sale s in sales)
            {
                //populate listBoxSales with Sale objects
                listBoxSales.Items.Add(s.DisplaySummary());
            }
        }

        private void Get_Selected_Vehicle()
        {
            int count = 0;
            int index = 0;
            //loop through display list
            foreach (Vehicle v in display)
            {
                //get the index of the vehicle selected on the listBox in the list
                if (listBoxVehicles.SelectedItem.ToString() == v.ToString())
                {
                    index = count;
                }
                count++;
            }
            //store the vehicle in a new Vehicle object
            vehicleSelected = display[index];
        }

        private void Calculate_Sale_Price()
        {
            double salePrice;
            double markUp = 0.25;
            double vat = 0.2;
            
            //calculate the sale price of the selected vehicle
            salePrice = vehicleSelected.Price;
            salePrice += salePrice * markUp;
            salePrice += salePrice * vat;

            //store the sale prive in another variable
            vehicleSalePrice = salePrice;
        }

        private void Hide_EditFields()
        {
            //hide all of the edit fields and the edit and delete button
            groupBoxCustDetails.Visible = false;
            btnEdit.Visible = false;
            btnDelete.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {

            lblSalePrice.Visible = false;
            
            //if nothing is selected from listBoxVehicles
            if (listBoxVehicles.SelectedItem == null)
            {
                //display an error message
                MessageBox.Show("Please choose a vehicle to be sold", "Nothing is selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //else create display another form to add another sale
                //parse the vehicleSelected object to the form
                frmAddSale addNewSaleForm = new frmAddSale(vehicleSelected);
                addNewSaleForm.Show();
                //call another event to repopulate listBoxVehicles when the form is closed
                addNewSaleForm.FormClosed += AddSaleForm_FormClosed;
            }
        }

        private void AddSaleForm_FormClosed(object sender, EventArgs e)
        {
            //repopulate listBoxVehicles
            listBoxVehicles.Items.Clear();
            listBoxSales.Items.Clear();
            this.Populate_ListBox();
        }

        private void listBoxVehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if something in listBoxVeicles is selected
            if(listBoxVehicles.SelectedItem != null)
            {
                //hide all the edit fields
                this.Hide_EditFields();
                //get the selected Vehicle object
                this.Get_Selected_Vehicle();
                //calculate the selected Vehicle's sale price
                this.Calculate_Sale_Price();
                lblSalePrice.Visible = true;
                //display the sale price of the selected Vehicle
                lblSalePrice.Text = "Sale Price of Vehicle :" + vehicleSalePrice.ToString("C");
                listBoxSales.ClearSelected();
            }
            
            

        }

        private void listBoxSales_SelectedIndexChanged(object sender, EventArgs e)
        {
            //of something is selected in listBoxSales
            if (listBoxSales.SelectedItem != null)
            {
                listBoxVehicles.SelectedItem = null;
                lblSalePrice.Visible = false;
                groupBoxCustDetails.Visible = true;
                btnEdit.Visible = true;
                btnDelete.Visible = true;

                //loop through the sales list
                foreach (Sale s in sales)
                {
                    //get the selected Sale object
                    if (listBoxSales.SelectedItem.ToString().Contains(s.Vehicle.RegNum))
                    {
                        //populate the edit fields with the selected Sale object values
                        txtFName.Text = s.FirstName;
                        txtLName.Text = s.LastName;
                        dateBirthDate.Value = DateTime.Parse(s.DateOfBirth);
                        txtPhone.Text = s.PhoneNumber;
                        datePurchaseDate.Value = DateTime.Parse(s.DatePurchase);
                        txtAddress.Text = s.Address;
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Sale currentSale = null;
            Sale updatedSale;
            Vehicle vehicle = null;
            int age = DateTime.Now.Date.Year - dateBirthDate.Value.Date.Year;

            //validation
            if (txtFName.Text == "" || txtLName.Text == "" || txtPhone.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dateBirthDate.Value >= DateTime.Now)
            {
                MessageBox.Show("Invalid Date Of Birth", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (datePurchaseDate.Value > DateTime.Now)
            {
                MessageBox.Show("Invalid Purchase Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                //loop through the sales list
                foreach (Sale s in sales)
                {
                    //get the selected Sale object
                    if (listBoxSales.SelectedItem.ToString().Contains(s.Vehicle.RegNum))
                    {
                        //store the vehicle in another Vehicle object
                        vehicle = s.Vehicle;
                        //store the selected Sale object in another Sale object
                        currentSale = s;
                    }
                }

                //create another Sale object to store the edited details of the selected Sale object
                updatedSale = new Sale(txtFName.Text, txtLName.Text, dateBirthDate.Value.ToString("dd/MM/yyyy"), txtPhone.Text, txtAddress.Text, vehicle, datePurchaseDate.Value.ToString("dd/MM/yyyy"));
                //replace the original Sale object with the new one
                fileStreamer.Edit_Sale(currentSale, updatedSale);
                listBoxSales.Items.Clear();
                //repopulate the listBoxes
                this.Populate_ListBox();
                //hide all the edit fields
                this.Hide_EditFields();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int count = 0;
            int delete = 0;

            //loop through the sales list
            foreach (Sale s in sales)
            {
                //get the selected Sale Object
                if(listBoxSales.SelectedItem.ToString() == s.DisplaySummary())
                {
                    //get the index of the selected Sale object 
                    delete = count;
                    //remove the selected Sale object in the file
                    fileStreamer.Delete_Sale(s);
                }
                count++;
            }
            //remove the selected Sale object from the sales list
            sales.RemoveAt(delete);
            this.listBoxSales.Items.Clear();
            //repopulate the listBoxes
            this.Populate_ListBox();
            //hide all edit fields
            this.Hide_EditFields();
        }
    }
}
