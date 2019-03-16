using System;
using System.Collections;
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
    public partial class frmMenu : Form
    {
        //List<Vehicle> vehicles;
        public frmMenu()
        {
            InitializeComponent();
            //Create a Vehicles.dat file if it does not exist
            if (!File.Exists(@".\Vehicles.dat"))
            {
                FileInfo newFile = new FileInfo(@".\Vehicles.dat");
                FileStream fs = newFile.Create();
                fs.Close();
            }
            //Create a Sales.dat file if it does not exist
            if (!File.Exists(@".\Sales.dat"))
            {
                FileInfo newFile = new FileInfo(@".\Sales.dat");
                FileStream fs = newFile.Create();
                fs.Close();
            }
            //StreamWriter writer = new StreamWriter(@"Vehicles.dat");
            //Car car1 = new Car("Mercedez", "Civic", "CO454542", 4, 254420, 4);
            //Car car2 = new Car("Honda", "Civic1", "CO65658", 4, 255453, 4);
            //Car car3 = new Car("Honda", "Civic2", "CO55122", 4, 250000, 4);
            //Car car4 = new Car("Honda", "Civic3", "CO12545", 4, 250000, 4);
            //Car car5 = new Car("Honda", "Civic4", "CO1265", 4, 250000, 4);
            //Car car6 = new Car("Honda", "Civic5", "CO18885", 4, 250000, 4);
            //Car car7 = new Car("Honda", "Civic6", "CO88888", 4, 250000, 4);
            //Car car8 = new Car("Honda", "Civic7", "CO62133", 4, 250000, 4);
            //Car car9 = new Car("Honda", "Civic8", "CO54213", 4, 250000, 4);
            //Car car10 = new Car("Honda", "Civic9", "CO3266", 4, 250000, 4);

            //QuadBike quad1 = new QuadBike("Mercedez", "Benz", "KE12345", 4, 50000, false);
            //QuadBike quad2 = new QuadBike("Honda", "Quad", "KE67891", 4, 60000, true);
            //QuadBike quad3 = new QuadBike("Honda", "Quad1", "KE12312", 4, 80000, false);
            //QuadBike quad4 = new QuadBike("Mercedez", "Quad2", "KE25445", 4, 820000, false);
            //QuadBike quad5 = new QuadBike("Honda", "Quad3", "KE87465", 4, 50000, true);
            //QuadBike quad6 = new QuadBike("Perodua", "Quad4", "KE29488", 4, 50000, true);
            //QuadBike quad7 = new QuadBike("Lamborgini", "Quad5", "KE09859", 4, 50000, true);
            //QuadBike quad8 = new QuadBike("Hummer", "Quad6", "KE09560", 4, 50000, true);
            //QuadBike quad9 = new QuadBike("Volvo", "Quad7", "KE070878", 4, 50000, true);
            //QuadBike quad10 = new QuadBike("Match", "Quad8", "KE34565", 4, 50000, true);

            //MotorBike motor1 = new MotorBike("Harley", "Davidson", "DU18885", 4, 250000, 5);
            //MotorBike motor2 = new MotorBike("Harley", "Davidson1", "DU88888", 4, 250000, 4);
            //MotorBike motor3 = new MotorBike("Harley", "Davidson2", "DU62133", 4, 250000, 6);
            //MotorBike motor4 = new MotorBike("Harley", "Davidson3", "DU54213", 4, 250000, 4);
            //MotorBike motor5 = new MotorBike("Harley", "Davidson4", "DU32656", 4, 250000, 4);


            //vehicles = new List<Vehicle> { car1, car2, car3, car4, car5, car6, car7, car8, car9, car10, quad1, quad2, quad3, quad4, quad5, quad6, quad7, quad8, quad9, quad10, motor1, motor2, motor3, motor4, motor5 };
            //foreach (Vehicle car in vehicles)
            //{
            //    writer.WriteLine(car.ToString());
            //}
            //writer.Close();

        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            frmStock newStockForm = new frmStock();
            newStockForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            frmSales newSalesForm = new frmSales();
            newSalesForm.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReport newReport = new frmReport();
            newReport.Show();
        }
    }
}
