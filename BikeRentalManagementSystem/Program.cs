using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
            Console.ReadLine();
        }

        public static void Menu()
        {
            var bike = new Bike(1, "Yamaha", "FZ", 200);
            Console.WriteLine(bike.ToString());
        }
    }
}
