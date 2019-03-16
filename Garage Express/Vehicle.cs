using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Express
{
   public abstract class Vehicle
    {
        
        private string make;
        private string model;
        private string regNum;
        private int numWheels;
        private double price;


        public Vehicle()
        {   
            this.Make = "";
            this.Model = "";
            this.RegNum = "";
            this.NumWheels = 0;
            this.Price = 0.0;
        }

        public Vehicle(string make, string model, string regNum, int numWheels, double price)
        {
            this.Make = make;
            this.Model = model;
            this.RegNum = regNum;
            this.NumWheels = numWheels;
            this.Price = price;
        }

        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string RegNum
        {
            get { return this.regNum; }
            set { this.regNum = value; }
        }

        public int NumWheels
        {
            get { return this.numWheels; }
            set { this.numWheels = value; }
        }

        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public override string ToString()
        {
            return "\tMake :" + Make + "\tModel :" + Model + "\tReg Number :" + RegNum + "\tWheels :" + NumWheels + "\tPrice :" + Price;
        }
    }
}
