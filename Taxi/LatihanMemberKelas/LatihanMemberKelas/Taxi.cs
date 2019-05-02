using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberKelas
{
    class Taxi
    {
        // properties
        public string DriverName { get; set;  }
        public bool OnDuty { get; set;  }
        public int NumPassenger { get; set; }

        // method
        public void TaxiInfo() 
        {
            Console.WriteLine("DriverName : {0}", DriverName);
            Console.WriteLine("OnDuty : {0}", OnDuty);
            Console.WriteLine("NumPassenger : {0}", NumPassenger);
        }
        public void PickUpPassenger()
        {
            Console.WriteLine("{0} Sedang Menjemput Penumpang Cewek Cantik", DriverName);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} Selesai Menjemput Penumpang Cewek Cantik", DriverName);
        }
    }
}
