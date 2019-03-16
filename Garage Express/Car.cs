using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Express
{
    class Car : Vehicle
    {
        private int numDoors;
        
        public Car()
            :base()
        {
            this.NumDoors = 0;
        }

        public Car(string make, string model, string regNum, int numWheels, double price, int numDoors)
            :base(make, model, regNum, numWheels, price)
        {
            this.NumDoors = numDoors;
        }

        public int NumDoors
        {
            get { return this.numDoors; }
            set { this.numDoors = value; }
        }

        public override string ToString()
        {   
            return "Car" + base.ToString() + "\tDoors :" + NumDoors;
        }
    }
}
