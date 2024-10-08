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

            var manager = new BikeManager();
            manager.CreateBike(bike);
            manager.ReadBikes();
            //Console.WriteLine("Enter the bike ID to be Updated");
            //var BikeId = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the New Brand");
            //var NBrand = Console.ReadLine();
            //Console.WriteLine("Enter the New Model");
            //var NModel = Console.ReadLine();
            //Console.WriteLine("Enter the New Rental Price");
            //var NRentalPrice = decimal.Parse(Console.ReadLine());
            //var Nbike = new Bike
            //{
            //    Brand = NBrand,
            //    Model = NModel,
            //    RentalPrice = NRentalPrice
            //};
            //manager.UpdateBike(BikeId, Nbike);
        }

    }
}
