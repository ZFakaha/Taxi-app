using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectTaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek dari kelas taxi
            Taxi Driver1 = new Taxi();

            // mengeset nilai properties
            Driver1.DriverName = "Zuka";
            Driver1.OnDuty = true;
            Driver1.NumPassenger = 10;

            // pemanggilan method
            Driver1.TaxiInfo();
            Driver1.PickUpPassenger();
            Driver1.DropOffPassenger();
       
            Console.ReadKey();
        }
    }
}
