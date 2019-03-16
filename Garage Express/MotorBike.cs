using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Express
{
    class MotorBike : Vehicle
    {
        private int valves;

        public MotorBike()
            :base()
        {
            this.Valves = 0;
        }

        public MotorBike(string make, string model, string regNum, int numWheels, double price, int valves)
            :base(make, model, regNum, numWheels, price)
        {
            this.Valves = valves;
        }

        public int Valves
        {
            get { return this.valves; }
            set { this.valves = value; }
        }

        public override string ToString()
        {
            return "MotorBike" + base.ToString() + "\tValves :" + Valves;
        }

    }
}
