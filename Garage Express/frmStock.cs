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
    public partial class frmStock : Form
    {
        FileStreamer fileStreamer = new FileStreamer();
        List<Vehicle> vehicles = new List<Vehicle>();
        List<Vehicle> cars;
        List<Vehicle> quads;
        List<Vehicle> motors;
        Vehicle vehicleSelected;
        string radioButtonSelected = "All";
        public frmStock()
        {
            InitializeComponent();

            //populate listBoxView
            this.Populate_ListBox();
            //hide edit fields
            this.Hide_EditFields();

            groupBoxVehicle.Controls.Add(radioButtonAll);
            groupBoxVehicle.Controls.Add(radioButtonCar);
            groupBoxVehicle.Controls.Add(radioButtonQuadBike);
            groupBoxVehicle.Controls.Add(radioButtonMotorBike);
            groupBoxStats.Controls.Add(lblCars);
            groupBoxStats.Controls.Add(lblQuads);
            groupBoxStats.Controls.Add(lblMotors);
            groupBoxStats.Controls.Add(lblTotal);

            //call Radio_Changed event when radio button is clicked
            radioButtonAll.CheckedChanged += RadioButton_Changed;
            radioButtonCar.CheckedChanged += RadioButton_Changed;
            radioButtonQuadBike.CheckedChanged += RadioButton_Changed;
            radioButtonMotorBike.CheckedChanged += RadioButton_Changed;

            
        }

        private void Hide_EditFields()
        {
            //hide all edit fields
            lblModel.Visible = false;
            txtModel.Visible = false;
            lblMake.Visible = false;
            txtMake.Visible = false;
            lblRegNum.Visible = false;
            txtRegNum.Visible = false;
            lblNumWheels.Visible = false;
            txtNumWheels.Visible = false;
            lblPrice.Visible = false;
            txtPrice.Visible = false;
            lblNumDoorsValves.Visible = false;
            txtNumDoorsValves.Visible = false;
            lblChildProof.Visible = false;
            radioButtonTrue.Visible = false;
            radioButtonFalse.Visible = false;
        }

        private void Populate_ListBox()
        {
            //if the listBox View is not empty
            if (listBoxView.Items.Count > 0)
            {
                //clear the listBoxView
                listBoxView.Items.Clear();
            }

            //get Vehicle list from file
            vehicles = fileStreamer.ReadVehicle();
            //Create a Car, QuadBike and MotorBike list
            cars = new List<Vehicle>();
            quads = new List<Vehicle>();
            motors = new List<Vehicle>();

            //loop through the display list of Vehicle objects
            foreach (Vehicle v in vehicles)
            {
                //if the radioButtonSelected is All
                if(radioButtonSelected == "All")
                {
                    //populate listBoxView
                    listBoxView.Items.Add(v.ToString());
                }
                else if(v.ToString().Contains(radioButtonSelected))
                {
                    //populate listBoxView
                    listBoxView.Items.Add(v.ToString());
                }
                //if the Vehicle is a Car
                if (v.ToString().Contains("Car"))
                {
                    //add the Car object to the cars list
                    cars.Add(v);
                }
                //if the Vehicle is a QuadBike
                else if (v.ToString().Contains("QuadBike"))
                {
                    //add the QuadBike object to the quads list
                    quads.Add(v);
                }
                //if the Vehicle is a MotorBike
                else if (v.ToString().Contains("MotorBike"))
                {
                    //add the MotorBike object to the motors list
                    motors.Add(v);
                }
            }

            //display the number of Cars, QuadBikes, MotorBikes and total number of Vehicles
            lblCars.Text = "Cars :" + cars.Count;
            lblQuads.Text = "QuadBikes :" + quads.Count;
            lblMotors.Text = "MotorBikes :" + motors.Count;
            lblTotal.Text = "Total :" + vehicles.Count;
        }


        private void RadioButton_Changed(object sender, EventArgs e)
        {
            listBoxView.Items.Clear();
            RadioButton radioButton = sender as RadioButton;
            radioButtonSelected = radioButton.Text;
            //if a radioButton is checked
            if(radioButton.Checked == true)
            {
                switch(radioButton.Text)
                {
                    //if...
                    //All is selected
                    case "All":
                        //loop through thevehicles list
                        foreach (Vehicle v in vehicles)
                        {
                            //populate listBoxView with all Vehicle objects
                            listBoxView.Items.Add(v.ToString());
                        }
                        break;
                        //Car is selected
                    case "Car":
                        foreach (Vehicle v in vehicles)
                        {
                            //populate listBoxView with Car objects
                            if (v.ToString().Contains("Car"))
                            {
                                listBoxView.Items.Add(v.ToString());
                            }
                        }
                        break;
                        //Quad Bike is selected
                    case "QuadBike":
                        foreach (Vehicle v in vehicles)
                        {
                            //calculate listBoxView with QuadBike objects
                            if (v.ToString().Contains("QuadBike"))
                            {
                                listBoxView.Items.Add(v.ToString());
                            }
                        }
                        break;
                        //Motor Bike is selected
                    case "MotorBike":
                        foreach (Vehicle v in vehicles)
                        {
                            //populate listBoxView with Motor Bike objects
                            if (v.ToString().Contains("MotorBike"))
                            {
                                listBoxView.Items.Add(v.ToString());
                            }
                        }
                        break;
                }
            }
            //hide all edit fields
            this.Hide_EditFields();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //if the vehicles list is less than 30
            if (vehicles.Count < 30)
            {
                //display a new form to add stock
                frmAddStock addStockForm = new frmAddStock();
                //call another method to repopulate the listBoxView when the new form is closed
                addStockForm.FormClosed += AddStockForm_FormClosed;
                addStockForm.Show();
            }
            else
            {
                //display error message
                MessageBox.Show("Maximum number of vehicles in stock. Cannot purchase more vehicles", "Garage is full", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void AddStockForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //repopulate listBoxView 
            this.Populate_ListBox();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            int count = 0;
            int delete = 0;
            //if nothing is selected
            if (listBoxView.SelectedItem == null)
            {
                //display error message
                MessageBox.Show("No vehicle is selected to be deleted", "Nothing Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //loop through vehicles list
                foreach (Vehicle v in vehicles)
                {
                    //get selected Vehicle 
                    if (listBoxView.SelectedItem.ToString() == v.ToString())
                    {
                        //get the index 
                        delete = count;
                        //delete the selected Vehicle in the file
                        fileStreamer.Delete(v);
                    }
                    count++;
                }
                //remove the selecte Vehicle from the vehicles list
                vehicles.RemoveAt(delete);
            }

            //hide all edit fields
            this.Hide_EditFields();
            //repopulate the listBox
            this.Populate_ListBox();
        }

        private void Selected_Vehicle()
        {
            //loop through vehicles list
            foreach (Vehicle v in vehicles)
            {
                //get the selected Vehicle object
                if (listBoxView.SelectedItem.ToString() == v.ToString())
                {
                    vehicleSelected = v;
                }
            }
        }

        private void listBoxView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if nothing is selected
            if (listBoxView.SelectedItem == null)
            {
                //hide all edit fields
                this.Hide_EditFields();
            }
            else
            {
                //display all fields relevant to all Vehicles
                lblModel.Visible = true;
                txtModel.Visible = true;
                lblMake.Visible = true;
                txtMake.Visible = true;
                lblRegNum.Visible = true;
                txtRegNum.Visible = true;
                lblNumWheels.Visible = true;
                txtNumWheels.Visible = true;
                lblPrice.Visible = true;
                txtPrice.Visible = true;

                //if Car is selected
                if (listBoxView.SelectedItem.ToString().Contains("Car"))
                {
                    //display remaining fields relevant to Car
                    lblNumDoorsValves.Visible = true;
                    lblNumDoorsValves.Text = "Number of Doors";
                    txtNumDoorsValves.Visible = true;
                    lblChildProof.Visible = false;
                    radioButtonTrue.Visible = false;
                    radioButtonFalse.Visible = false;

                    //get selected Vehicle object
                    this.Selected_Vehicle();
                    //Cast Vehicle object as a Car
                    Car carSelected = (Car)vehicleSelected;

                    //populate fields with the selected Vehicle's information
                    txtMake.Text = carSelected.Make;
                    txtModel.Text = carSelected.Model;
                    txtRegNum.Text = carSelected.RegNum;
                    txtNumWheels.Text = carSelected.NumWheels.ToString();
                    txtPrice.Text = carSelected.Price.ToString();
                    txtNumDoorsValves.Text = carSelected.NumDoors.ToString();

                }
                //if QuadBike is selected
                else if (listBoxView.SelectedItem.ToString().Contains("QuadBike"))
                {
                    //display remaining fields relevant to QuadBike
                    lblNumDoorsValves.Visible = false;
                    txtNumDoorsValves.Visible = false;
                    lblChildProof.Visible = true;
                    radioButtonTrue.Visible = true;
                    radioButtonFalse.Visible = true;

                    //get selected Vehicle object
                    this.Selected_Vehicle();
                    //Cast Vehicle object as a QuadBike
                    QuadBike quadSelected = (QuadBike)vehicleSelected;

                    //populate fields with the selected Vehicle's information
                    txtMake.Text = quadSelected.Make;
                    txtModel.Text = quadSelected.Model;
                    txtRegNum.Text = quadSelected.RegNum;
                    txtNumWheels.Text = quadSelected.NumWheels.ToString();
                    txtPrice.Text = quadSelected.Price.ToString();

                    //if ChildProof is true
                    if(quadSelected.ChildProof == true)
                    {
                        //check radioButtonTrue
                        radioButtonTrue.Checked = true;
                    }
                    //if ChildProof is false
                    else
                    {
                        //check radioButtonFalse
                        radioButtonFalse.Checked = true;
                    }

                }
                //if MotorBike is selected
                else if (listBoxView.SelectedItem.ToString().Contains("MotorBike"))
                {
                    //display remaining fields relevant to MotorBike
                    lblNumDoorsValves.Visible = true;
                    lblNumDoorsValves.Text = "Number of Valves";
                    txtNumDoorsValves.Visible = true;
                    lblChildProof.Visible = false;
                    radioButtonTrue.Visible = false;
                    radioButtonFalse.Visible = false;

                    //get selected Vehicle object
                    this.Selected_Vehicle();
                    //Cast Vehicle object as a MotorBike
                    MotorBike motorSelected = (MotorBike)vehicleSelected;

                    //populate fields with the selected Vehicle's information
                    txtMake.Text = motorSelected.Make;
                    txtModel.Text = motorSelected.Model;
                    txtRegNum.Text = motorSelected.RegNum;
                    txtNumWheels.Text = motorSelected.NumWheels.ToString();
                    txtPrice.Text = motorSelected.Price.ToString();
                    txtNumDoorsValves.Text = motorSelected.Valves.ToString();

                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int check;
            double check2;

            //if nothing is selected in listBoxView
            if (listBoxView.SelectedItem == null)
            {
                //display error message
                MessageBox.Show("Please select a vehicle to edit", "Nothing is Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                //validation
                if (listBoxView.SelectedItem.ToString().Contains("QuadBike"))
                {
                    if (txtMake.Text == "" || txtModel.Text == "" || txtNumWheels.Text == "" || txtPrice.Text == "")
                    {
                        MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                    }
                    else if (!Int32.TryParse(txtNumWheels.Text, out check) || Int32.Parse(txtNumWheels.Text) < 0)
                    {
                        MessageBox.Show("Please enter a valid number of wheels", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (!Double.TryParse(txtPrice.Text, out check2) || Double.Parse(txtPrice.Text) < 0)
                    {
                        MessageBox.Show("Please enter a valid price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //if validation passes
                        //edit the Vehicle
                        this.Edit_Vehicle();
                    }
                }
                else if(listBoxView.SelectedItem.ToString().Contains("Car") || listBoxView.SelectedItem.ToString().Contains("MotorBike"))
                {
                    if (txtMake.Text == "" || txtModel.Text == "" || txtNumWheels.Text == "" || txtPrice.Text == "" || txtNumDoorsValves.Text == "")
                    {
                        MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (!Int32.TryParse(txtNumDoorsValves.Text, out check) || Int32.Parse(txtNumDoorsValves.Text) < 0)
                    {
                        MessageBox.Show("Please enter a valid number of doors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (!Int32.TryParse(txtNumWheels.Text, out check) || Int32.Parse(txtNumWheels.Text) < 0)
                    {
                        MessageBox.Show("Please enter a valid number of wheels", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (!Double.TryParse(txtPrice.Text, out check2) || Double.Parse(txtPrice.Text) < 0)
                    {
                        MessageBox.Show("Please enter a valid price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //validation passes
                        //edit the Vehicle
                        this.Edit_Vehicle();
                    }
                }

               
            }

        }

        private void Edit_Vehicle()
        {
            Car updatedCar;
            QuadBike updatedQuad;
            MotorBike updatedMotor;

            //if the selected Vehicle is a Car
            if (listBoxView.SelectedItem.ToString().Contains("Car"))
            {
                //create another Car object to store the edited information into it's contructor
                updatedCar = new Car(txtMake.Text, txtModel.Text, txtRegNum.Text, Int32.Parse(txtNumWheels.Text), Double.Parse(txtPrice.Text), Int32.Parse(txtNumDoorsValves.Text));
                //replace the original Car object with the new one
                fileStreamer.Edit(vehicleSelected, updatedCar);
            }
            //if the selected Vehicle is a QuadBike
            else if (listBoxView.SelectedItem.ToString().Contains("QuadBike"))
            {
                //if the radioButtonTrue is checked
                if (radioButtonTrue.Checked == true)
                {
                    //create another QuadBike object to store the edited information into it's constructor with ChildProof as true
                    updatedQuad = new QuadBike(txtMake.Text, txtModel.Text, txtRegNum.Text, Int32.Parse(txtNumWheels.Text), Double.Parse(txtPrice.Text), true);
                }
                //if radioButtonFalse is checked
                else
                {
                    //create another QuadBike object to store the edited information into it's constructor with ChildProof as false
                    updatedQuad = new QuadBike(txtMake.Text, txtModel.Text, txtRegNum.Text, Int32.Parse(txtNumWheels.Text), Double.Parse(txtPrice.Text), false);
                }
                //replace the original QuadBike object with the new one
                fileStreamer.Edit(vehicleSelected, updatedQuad);

            }
            //if the selected Vehicle is a MotorBike
            else if (listBoxView.SelectedItem.ToString().Contains("MotorBike"))
            {
                //create another MotorBike object to store the edited information into it's contructor
                updatedMotor = new MotorBike(txtMake.Text, txtModel.Text, txtRegNum.Text, Int32.Parse(txtNumWheels.Text), Double.Parse(txtPrice.Text), Int32.Parse(txtNumDoorsValves.Text));
                //replace the original MotorBike object with the new one
                fileStreamer.Edit(vehicleSelected, updatedMotor);
            }
            //repopulate the listBox
            this.Populate_ListBox();
            //hide all edit fields
            this.Hide_EditFields();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
