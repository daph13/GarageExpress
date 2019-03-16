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
    public partial class frmAddStock : Form
    {
        List<Vehicle> vehicles = null;
        FileStreamer fileStreamer = new FileStreamer();
        List<Vehicle> cars = new List<Vehicle>();
        List<Vehicle> quads = new List<Vehicle>();
        List<Vehicle> motors = new List<Vehicle>();
        string[] type = {"", "Car", "Quad Bike", "Motor Bike" };
        BindingSource bindSource = new BindingSource();

        public frmAddStock()
        {
            InitializeComponent();
            //get vehicles list
            vehicles = fileStreamer.ReadVehicle();
            
            //loop through vehicles list
            foreach(Vehicle v in vehicles)
            {
                //if...
                //vehicle is a Car
                if(v.ToString().Contains("Car"))
                {
                    //Add to cars list
                    cars.Add(v);
                }
                //vehicle is a Quad 
                else if(v.ToString().Contains("QuadBike"))
                {
                    //Add to quads list
                    quads.Add(v);
                }
                //vehicle is a MotorBike
                else if(v.ToString().Contains("MotorBike"))
                {
                    //Add to motors list
                    motors.Add(v);
                }
            }

            //populate ComboBox with string array
            bindSource.DataSource = type;
            comboBoxVehicle.DataSource = bindSource.DataSource;

        }

        //Hides textfields and Labels
        private void Hide_Fields()
        {
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
            lblCProof.Visible = false;
            radioButtonTrue.Visible = false;
            radioButtonFalse.Visible = false;
            btnAdd.Visible = false;
            btnClear.Visible = false;

        }

        //Displays fields and labels
        private void Display_Fields()
        {
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
            btnAdd.Visible = true;
            btnClear.Visible = true;
        }

        private void comboBoxVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            radioButtonTrue.Checked = false;
            radioButtonFalse.Checked = false;
            //if nothing is selected
            if (comboBoxVehicle.SelectedItem.ToString() == "")
            {
                this.Hide_Fields();
            }
            //if Car is selected
            else if(comboBoxVehicle.SelectedItem.ToString() == "Car")
            {
                //if the cars list has less than 10 Car objects
                if (cars.Count < 10)
                {
                    //display the fields for Car
                    this.Display_Fields();
                    lblNumDoorsValves.Visible = true;
                    txtNumDoorsValves.Visible = true;
                    lblNumDoorsValves.Text = "Number of Doors";
                    lblCProof.Visible = false;
                    radioButtonTrue.Visible = false;
                    radioButtonFalse.Visible = false;
                }
                else
                {
                    //hide all the fields
                    this.Hide_Fields();
                    MessageBox.Show("Maximum number of cars achieved.\nCannot add anymore cars", "Maximum Cars", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            //if Quad Bike is selected
            else if (comboBoxVehicle.SelectedItem.ToString() == "Quad Bike")
            {
                // if the quads list has less than 10 QuadBike objects
                if(quads.Count < 10)
                {
                    //display the fields for QuadBike
                    this.Display_Fields();
                    lblNumDoorsValves.Visible = false;
                    txtNumDoorsValves.Visible = false;
                    lblCProof.Visible = true;
                    radioButtonTrue.Visible = true;
                    radioButtonFalse.Visible = true;
                }
                else
                {
                    //hide all the fields
                    this.Hide_Fields();
                    MessageBox.Show("Maximum number of quadbikes achieved.\nCannot add anymore quadbikes", "Maximum Quads", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            //if Motor Bike is selected
            else if (comboBoxVehicle.SelectedItem.ToString() == "Motor Bike")
            {
                //if the motors list has less than 10 MotorBike objects
                if (motors.Count < 10)
                {
                    //display the fields for MotorBike
                    this.Display_Fields();
                    lblNumDoorsValves.Visible = true;
                    txtNumDoorsValves.Visible = true;
                    lblNumDoorsValves.Text = "Number Of Valves";
                    lblCProof.Visible = false;
                    radioButtonTrue.Visible = false;
                    radioButtonFalse.Visible = false;
                }
                else
                {
                    //hide all the fields
                    this.Hide_Fields();
                    MessageBox.Show("Maximum number of motorbikes achieved.\nCannot add anymore motorbikes", "Maximum Motor Bikes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //clears all fields
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMake.Clear();
            txtModel.Clear();
            txtRegNum.Clear();
            txtNumWheels.Clear();
            txtPrice.Clear();
            txtNumDoorsValves.Clear();
            radioButtonTrue.Checked = false;
            radioButtonFalse.Checked = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //if no vehicle is selected
            if (comboBoxVehicle.SelectedItem.ToString() == "" || comboBoxVehicle.SelectedItem == null)
            {
                //display error message
                MessageBox.Show("Please the type of Vehicle", "Vehicle not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int check;
                double check2;
                //validation
                if (comboBoxVehicle.SelectedItem.ToString() == "Quad Bike")
                {
                    if (txtModel.Text == "" || txtMake.Text == "" || txtRegNum.Text == "" || txtNumWheels.Text == "" || txtPrice.Text == "")
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
                    else if(radioButtonTrue.Checked == false && radioButtonFalse.Checked == false)
                    {
                        MessageBox.Show("Please check if the QuadBike is ChildProof", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (this.Validate_RegNum_Exists() == true)
                    {
                        MessageBox.Show("Registration Number already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //validation passes
                        //add the Vehicle
                        this.Add_Vehicle();
                    }
                }
                else
                { 
                    if (txtModel.Text == "" || txtMake.Text == "" || txtRegNum.Text == "" || txtNumWheels.Text == "" || txtPrice.Text == "" || txtNumDoorsValves.Text == "")
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
                    else if (!Int32.TryParse(txtNumDoorsValves.Text, out check) || Int32.Parse(txtNumDoorsValves.Text) < 0)
                    {
                        MessageBox.Show("Please enter a valid number of doors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (this.Validate_RegNum_Exists() == true)
                    {
                        MessageBox.Show("Registration Number already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //validation passes
                        //add the Vehicle
                        this.Add_Vehicle();
                    }
                }
            }
            

        }

        private void Add_Vehicle()
        {
            //if Car is selected
            if (comboBoxVehicle.SelectedItem.ToString() == "Car")
            {
                //Create a Car object and insert field values in to its constructor
                Car car = new Car(txtMake.Text, txtModel.Text, txtRegNum.Text, Int32.Parse(txtNumWheels.Text), Double.Parse(txtPrice.Text), Int32.Parse(txtNumDoorsValves.Text));
                //add the Car in to the vehicles list
                vehicles.Add(car);
            }
            //if Quad Bike is selected
            else if (comboBoxVehicle.SelectedItem.ToString() == "Quad Bike")
            {
                //Create a QuadBike object and insert field values in to its constructor
                QuadBike quad = null;
                if (radioButtonTrue.Checked == true)
                {
                    quad = new QuadBike(txtMake.Text, txtModel.Text, txtRegNum.Text, Int32.Parse(txtNumWheels.Text), Double.Parse(txtPrice.Text), true);
                }
                else if (radioButtonFalse.Checked == true)
                {
                    quad = new QuadBike(txtMake.Text, txtModel.Text, txtRegNum.Text, Int32.Parse(txtNumWheels.Text), Double.Parse(txtPrice.Text), false);
                }

                //add the QuadBike into the vehicles list
                vehicles.Add(quad);
            }
            //if Motor Bike is selected
            else if (comboBoxVehicle.SelectedItem.ToString() == "Motor Bike")
            {
                //Create a MotorBike object and insert field values in to its constructor
                MotorBike motor = new MotorBike(txtMake.Text, txtModel.Text, txtRegNum.Text, Int32.Parse(txtNumWheels.Text), Double.Parse(txtPrice.Text), Int32.Parse(txtNumDoorsValves.Text));
                //add the MotorBike into the vehicles list 
                vehicles.Add(motor);
            }
            //write the vehicles list into the file
            fileStreamer.Add(vehicles);
            this.Close();
        }

        //checks if the vehicle's registration number already exists
        private bool Validate_RegNum_Exists()
        {
            bool exists = false;
            //loops through the vehicles list
            foreach (Vehicle v in vehicles)
            {
                //if the registration number exists in the list
                if (txtRegNum.Text == v.RegNum)
                {
                    //it is true
                    exists = true;
                }
            }

            return exists;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
