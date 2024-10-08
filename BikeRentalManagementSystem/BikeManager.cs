using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace BikeRentalManagementSystem
{
    internal class BikeManager
    {
        public BikeManager()
        {
            BikesList = new List<Bike>();
        }
        public List<Bike> BikesList;

        public void CreateBike()
        {
            Console.WriteLine("Enter the bike ID ");
            var BikeId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Brand");
            var Brand = Console.ReadLine();
            Console.WriteLine("Enter the Model");
            var Model = Console.ReadLine();
            var RentalPrice = ValidateBikeRentalPrice();
            var bike = new Bike()
            {
                BikeId = BikeId,
                Brand = Brand,
                Model = Model,
                RentalPrice = RentalPrice
            };
            
            this.BikesList.Add(bike);
            Console.WriteLine("Added Successfully");



        }
        public void ReadBikes()
        {
            if (BikesList.Count > 0)
            {
                foreach (var item in BikesList)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("No bikes available");
            }

        }

        public void UpdateBike()
        {
            Console.WriteLine("Enter the bike ID to be Updated");
            var BikeId = int.Parse(Console.ReadLine());
            var findBike = this.BikesList.Where(b => b.BikeId == BikeId).FirstOrDefault();
            if (findBike != null)
            {
                this.BikesList.Remove(findBike);
                Console.WriteLine("Enter the New Brand");
                var NBrand = Console.ReadLine();
                Console.WriteLine("Enter the New Model");
                var NModel = Console.ReadLine();
                var RentalPrice = ValidateBikeRentalPrice();
                var Nbike = new Bike
                {
                    BikeId = BikeId,
                    Brand = NBrand,
                    Model = NModel,
                    RentalPrice=RentalPrice
                };
                this.BikesList.Add(Nbike);
                Console.WriteLine("Bike Updated Successfully");
            }
            else
            {
                Console.WriteLine("Invalid Id");
            }
        }
        public void DeleteBike()
        {
            Console.WriteLine("Enter the bike ID to be Updated");
            var BikeId = int.Parse(Console.ReadLine());
            var findBike = this.BikesList.Where(b => b.BikeId == BikeId).FirstOrDefault();
            if (findBike != null)
            {
                this.BikesList.Remove(findBike);
                Console.WriteLine("Successfully Deleted");
            }
            else
            {
                Console.WriteLine("Invalid Id");
            }
        }

        public decimal ValidateBikeRentalPrice()
        {
            decimal init = 0;
            while (true)
            {
                Console.WriteLine("Enter the Rental Price");
                var RentalPrice = decimal.Parse(Console.ReadLine());
                if (RentalPrice > 0)
                {
                    init = RentalPrice;
                    break;
                }
                Console.WriteLine("Invalid");
            }
            return init;
        }

    }
}
