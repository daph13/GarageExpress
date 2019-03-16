using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Express
{
    class Sale
    {
        private string firstName;
        private string lastName;
        private string dateOfBirth;
        private string datePurchase;
        private string phoneNumber;
        private string address;
        private double price;
        private Vehicle vehicle;
        private const double MARK_UP = 0.25;
        private const double VAT = 0.2;

        public Sale()
        {
            this.FirstName = "";
            this.LastName = "";
            this.DateOfBirth = "";
            this.DatePurchase = "";
            this.PhoneNumber = "";
            this.Address = "";
            this.Vehicle = null;
        }

        public Sale(string fName, string lName, string dOB, string phone, string a, Vehicle v, string dP)
        {
            firstName = fName;
            lastName = lName;
            dateOfBirth = dOB;
            datePurchase = dP;
            phoneNumber = phone;
            address = a;
            vehicle = v;
            price = this.Calculate_Price();

        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public string DateOfBirth
        {
            get { return this.dateOfBirth; }
            set { this.dateOfBirth = value; }
        }

        public string DatePurchase
        {
            get { return this.datePurchase; }
            set { this.datePurchase = value; }
        }

        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }

        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public double Price
        {
            get { return this.price; }
            set { this.price = this.Calculate_Price(); }
        }

        public Vehicle Vehicle
        {
            get { return this.vehicle; }
            set { this.vehicle = value; }
        }

        public double Calculate_Price()
        {
            price = vehicle.Price;
            price += price * MARK_UP;
            price += price * VAT;

            return price;
        }

        public string DisplaySummary()
        {
            string display = "";
            if(vehicle.ToString().Contains("Car"))
            {
                display = DatePurchase + "\tName :" + FirstName + " " + LastName + "\tPurchase :Car  (Make :" + vehicle.Make + " Model :" + vehicle.Model + " Reg Number :" + vehicle.RegNum + " Price :" + Price.ToString("C") + ")"; 
            }
            else if (vehicle.ToString().Contains("QuadBike"))
            {
                display = DatePurchase + "\tName :" + FirstName + " " + LastName + "\tPurchase :QuadBike  (Make :" + vehicle.Make + " Model :" + vehicle.Model + " Reg Number :" + vehicle.RegNum + " Price :" + Price.ToString("C") + ")";
            }
            else if (vehicle.ToString().Contains("MotorBike"))
            {
                display = DatePurchase + "\tName :" + FirstName + " " + LastName + "\tPurchase :MotorBike  (Make :" + vehicle.Make + " Model :" + vehicle.Model + " Reg Number :" + vehicle.RegNum + " Price :" + Price.ToString("C") + ")";
            }
            return display;
        }

        public string DisplayDetails()
        {
            return "Name :" + FirstName + " " + LastName + "\nDOB :" + DateOfBirth + "\nPhone :" + PhoneNumber + "\nAddress :" + Address + "\nVehicle :" + vehicle.ToString() + "\nPrice :" + Price.ToString("C") + "\nPurchase Date :" + DatePurchase;
        }

        public override string ToString()
        {
            return "First Name :" + FirstName + "\tLast Name :" + LastName + "\tDOB :" + DateOfBirth + "\tPhone :" + PhoneNumber + "\tAddress :" + Address + "\tPurchase :" + vehicle.ToString() + "\tPurchase Date :" + DatePurchase + "\tPrice Sold :" + Price;
        }
    }
}
