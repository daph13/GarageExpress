using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Express
{
    class QuadBike : Vehicle
    {
        private bool childProof;

        public QuadBike()
            :base()
        {
            this.ChildProof = false;
        }

        public QuadBike(string make, string model, string regNum, int numWheels, double price, bool childProof)
            :base(make, model, regNum, numWheels, price)
        {
            this.ChildProof = childProof;
        }

        public bool ChildProof
        {
            get { return this.childProof; }
            set { this.childProof = value; }
        }

        public override string ToString()
        {
            return "QuadBike" + base.ToString() + "\tChild Proof :" + ChildProof;
        }

    }
}
