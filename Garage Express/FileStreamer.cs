using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garage_Express
{
    class FileStreamer
    {
        List<Vehicle> vehicles = new List<Vehicle>();
        List<String> readList = new List<String>();
        List<Sale> sales = new List<Sale>();

        public List<Vehicle> ReadVehicle()
        {
            //open the Vehicles.dat file
            StreamReader reader = File.OpenText(@"Vehicles.dat");
            List<Vehicle> tempList = new List<Vehicle>();
            
            string row = null;
            string[] columns;
            //read each line from the file
            while ((row = reader.ReadLine()) != null)
            {
                //Splits each row of strings from the text with a \t and :
                columns = row.Split('\t', ':');
         
                //if ..
                //the string contains the string "Car"
                if (row.Contains("Car"))
                {
                    //Create a Car object and insert the split strings into its allocated properties
                    Car car = new Car(columns[2], columns[4], columns[6], Int32.Parse(columns[8]), Double.Parse(columns[10]), Int32.Parse(columns[12]));
                    //add it to the tempList
                    tempList.Add(car);

                }
                //the string contains the string "QuadBike"
                else if (row.Contains("QuadBike"))
                {
                    //Create a QuadBike object and insert the split strings into its allocated properties
                    QuadBike quad = new QuadBike(columns[2], columns[4], columns[6], Int32.Parse(columns[8]), Double.Parse(columns[10]), bool.Parse(columns[12]));
                    //add it to the tempList
                    tempList.Add(quad);
                   
                }
                //the string contains the string "MotorBike"
                else if (row.Contains("MotorBike"))
                {
                    //Create a Motor object and insert the split strings into its allocated properties
                    MotorBike motor = new MotorBike(columns[2], columns[4], columns[6], Int32.Parse(columns[8]), Double.Parse(columns[10]), Int32.Parse(columns[12]));
                    //add it to the tempList
                    tempList.Add(motor);

                }

            }
            //set the vehicles list to the tempList
            vehicles = tempList;
            reader.Close();
            return vehicles;

        }

        public List<Sale> ReadSale()
        {
            //Open the Sales.dat file
            StreamReader reader = File.OpenText(@"Sales.dat");
            List<Sale> tempList = new List<Sale>();
            Sale sale;
            string row = null;
            string[] columns;
            
            //read each line from the file
            while((row = reader.ReadLine()) != null)
            {
                //Splits each row of strings from the text with a \t and :
                columns = row.Split('\t', ':');
                //if ..
                //the string contains the string "Car"
                if (row.Contains("Car"))
                {
                    //Create a Sale object with a Car object and insert the split strings into its allocated properties
                    sale = new Sale(columns[1], columns[3], columns[5], columns[7], columns[9], new Car(columns[13], columns[15], columns[17], Int32.Parse(columns[19]), Double.Parse(columns[21]), Int32.Parse(columns[23])), columns[25]);
                    tempList.Add(sale);
                }
                //the string contains the string "QuadBike"
                else if (row.Contains("QuadBike"))
                {
                    //Create a Sale object with a QuadBike object and insert the split strings into its allocated properties
                    sale = new Sale(columns[1], columns[3], columns[5], columns[7], columns[9], new QuadBike(columns[13], columns[15], columns[17], Int32.Parse(columns[19]), Double.Parse(columns[21]), bool.Parse(columns[23])), columns[25]);
                    tempList.Add(sale);
                }
                //the string contains the string "MotorBike"
                else if (row.Contains("MotorBike"))
                {
                    //Create a Sale object with a MotorBike object and insert the split strings into its allocated properties
                    sale = new Sale(columns[1], columns[3], columns[5], columns[7], columns[9], new MotorBike(columns[13], columns[15], columns[17], Int32.Parse(columns[19]), Double.Parse(columns[21]), Int32.Parse(columns[23])), columns[25]);
                    tempList.Add(sale);
                }                
            }
            //set the sales list to the tempList
            sales = tempList;
            reader.Close();
            return sales;
        }

        public void Add(List<Vehicle> vehicleList)
        {
            //open the Vehicles.dat file
            StreamWriter writer = new StreamWriter(@"Vehicles.dat");
            
            //loop through the vehicleList
            foreach (Vehicle vehicle in vehicleList)
            {
                //write each object from the vehicleList into the file
                writer.WriteLine(vehicle.ToString());
            }
            //set the vehicles List to the vehicleList added
            vehicles = vehicleList;
            writer.Close();
            MessageBox.Show("Vehicle has been added to stock", "Vehicle Purchased", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Add_Customer_Sale(List<Sale> saleList)
        {
            //Open the Sales.dat file
            StreamWriter writer = new StreamWriter(@"Sales.dat");

            //loop through the saleList
            foreach (Sale sale in saleList)
            {
                //write each object from the saleList into the file
                writer.WriteLine(sale.ToString());
            }
            //set the sales list to the saleList added
            sales = saleList;
            writer.Close();
            MessageBox.Show("Vehicle has been sold", "New Sale", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Delete(Vehicle vehicle)
        {
            //Open the Vehicles.dat file
            StreamWriter writer = new StreamWriter(@"Vehicles.dat");
            //Create another empty list of vehicle objects
            List<Vehicle> tempList = new List<Vehicle>();
            //loop through the vehicles list
            foreach(Vehicle v in vehicles)
            {
                //if the objects from the vehicles list are NOT equal to the vehicle parsed
                if (!(v.Equals(vehicle)))
                {
                    //write them into the file
                    writer.WriteLine(v.ToString());
                    //add these objects into the tempList
                    tempList.Add(v);
                }
            }
            writer.Close();
            //set the vehicles list to the tempList
            vehicles = tempList;
        }

        public void Edit(Vehicle oldVehicle, Vehicle newVehicle)
        {
            //Open the Vehicles.dat file
            StreamWriter writer = new StreamWriter(@"Vehicles.dat");
            int count = 0;
            int index = 0;
            
            //loop through the vehicles list
            foreach (Vehicle v in vehicles)
            {
                //if oldVehicle equals to the object in the vehicles list
                if(oldVehicle.Equals(v))
                {
                    //get the index
                    index = count;
                }
                count++;
            }
            //replace the newVehicle into the list of that index
            vehicles[index] = newVehicle;
            
            //loop through the vehicles list 
            foreach (Vehicle v in vehicles)
            {
                //write each object in the vehicles list into the file
                writer.WriteLine(v.ToString());
            }
            writer.Close();
            MessageBox.Show("Vehicle has been edited", "Vehicle Edited", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        public void Edit_Sale(Sale oldSale, Sale newSale)
        {
            StreamWriter writer = new StreamWriter(@"Sales.dat");

            int count = 0;
            int index = 0;

            //loop through the  sales list
            foreach (Sale s in sales)
            {
                //if oldSale equals to the object in the sales list
                if (oldSale.Equals(s))
                {
                    //get the index
                    index = count;
                }
                count++;
            }
            //replace the newSale into the list of that index
            sales[index] = newSale;

            //loop through the sales list 
            foreach (Sale s in sales)
            {
                //write each object in the sales list into the file
                writer.WriteLine(s.ToString());
            }
            writer.Close();
            MessageBox.Show("Sale has been edited", "Sale Edited", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Delete_Sale(Sale sale)
        {
            //Open the Sales.dat file
            StreamWriter writer = new StreamWriter(@"Sales.dat");
            //Create another empty list of sale objects
            List<Sale> tempList = new List<Sale>();
            //loop through the sales list
            foreach (Sale s in sales)
            {
                //if the objects from the sales list are NOT equal to the sale parsed
                if (!(s.Equals(sale)))
                {
                    //write them into the file
                    writer.WriteLine(s.ToString());
                    //add these objects into the tempList
                    tempList.Add(s);
                }
            }
            writer.Close();
            //set the sales list to the tempList
            sales = tempList;
        }






    }
}
