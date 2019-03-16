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
    public partial class frmStockReport : Form
    {
        FileStreamer fileStreamer = new FileStreamer();
        List<Vehicle> vehicles = new List<Vehicle>();
        List<Vehicle> cars = new List<Vehicle>();
        List<Vehicle> quads = new List<Vehicle>();
        List<Vehicle> motors = new List<Vehicle>();
        string[] type = {"All", "Car", "Quad Bike", "Motor Bike" };
        BindingSource bindSource = new BindingSource(); 

        public frmStockReport()
        {
            InitializeComponent();

            groupBoxStats.Controls.Add(lblCars);
            groupBoxStats.Controls.Add(lblQuads);
            groupBoxStats.Controls.Add(lblMotors);
            groupBoxStats.Controls.Add(lblTotal);

            //get list of vehicles from file
            vehicles = fileStreamer.ReadVehicle();
            
            //loop through vehicles list
            foreach (Vehicle v in vehicles)
            {
                //populate listBoxVehicles with the Vehicle objects
                listBoxVehicles.Items.Add(v.ToString());
            }

            //create a list of Cars, QuadBikes and MotorBikes
            this.Create_Lists();
            //populate the comboBox with a list of strings
            bindSource.DataSource = type;
            comboBoxType.DataSource = bindSource.DataSource;
           
        }

        private void Create_Lists()
        {
            //loop through the vehicles list
            foreach (Vehicle v in vehicles)
            {
                //if the Vehicle object is a Car
                if(v.ToString().Contains("Car"))
                {
                    //add the Vehicle to the cars list
                    cars.Add(v);
                }
                //if the Vehicle object is a QuadBike
                else if (v.ToString().Contains("QuadBike"))
                {
                    //add the Vehicle to the quads list
                    quads.Add(v);
                }
                //if the Vehicle object is a MotorBike
                else if (v.ToString().Contains("MotorBike"))
                {
                    //add the Vehicle object to the quads list
                    motors.Add(v);
                }
            }

            //display the number of Cars, QuadBikes, MotorBikes and the total number of Vehicles
            lblCars.Text = "Cars :" + cars.Count;
            lblQuads.Text = "Quad Bikes :" + quads.Count;
            lblMotors.Text = "Motor Bikes :" + motors.Count;
            lblTotal.Text = "Total Vehicles :" + vehicles.Count;
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clear the listBoxVehicles
            listBoxVehicles.Items.Clear();

            //if All is selected in the comboBox
            if (comboBoxType.SelectedItem.ToString() == "All")
            {
                //loop through the vehicles list
                foreach (Vehicle v in vehicles)
                {
                    //populate listBoxVehicles with all Vehicle objects
                    listBoxVehicles.Items.Add(v.ToString());
                }
            }
            //if Car is selected in the comboBox
            else if (comboBoxType.SelectedItem.ToString() == "Car")
            {
                foreach (Vehicle v in vehicles)
                {
                    //populate listBoxVehicles with Car objects
                    if (v.ToString().Contains("Car"))
                    {
                        listBoxVehicles.Items.Add(v.ToString());
                    }
                }
            }
            //if Quad Bike is selected in the comboBox
            else if (comboBoxType.SelectedItem.ToString() == "Quad Bike")
            {
                //populate listBoxVehicles with QuadBike objects
                foreach (Vehicle v in vehicles)
                {
                    if (v.ToString().Contains("QuadBike"))
                    {
                        listBoxVehicles.Items.Add(v.ToString());
                    }
                }

            }
            //if Motor Bike is selected in the comboBox
            else if (comboBoxType.SelectedItem.ToString() == "Motor Bike")
            {
                //populate listBoxVehicles with MotorBike objects
                foreach (Vehicle v in vehicles)
                {
                    if (v.ToString().Contains("MotorBike"))
                    {
                        listBoxVehicles.Items.Add(v.ToString());
                    }
                }

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
