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
            bikeRepository = new BikeRepository();

        }
        public List<Bike> BikesList;
        public BikeRepository bikeRepository;
        public void CreateBike()
        {
            //Console.WriteLine("Enter the bike ID ");
            //var BikeId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Brand");
            var input = Console.ReadLine();
            var Brand = CapitalizeTitle(input);
            Console.WriteLine("Enter the Model");
            var Model = Console.ReadLine();
            var RentalPrice = ValidateBikeRentalPrice();
            var bike = new Bike()
            {
                Brand = Brand,
                Model = Model,
                RentalPrice = RentalPrice
            };

            // this.BikesList.Add(bike);
            bikeRepository.AddBike(bike);
            Console.WriteLine("Added Successfully");

        }
        public void ReadBikes()
        {
            var data = bikeRepository.GetAllBikes();
            Console.WriteLine(data);
        }

        public void UpdateBike()
        {
            Console.WriteLine("Enter the bike ID to be Updated");
            var BikeId = int.Parse(Console.ReadLine());
            //var findBike = this.BikesList.Where(b => b.BikeId == BikeId).FirstOrDefault();
            var findBike = bikeRepository.GetBikeByID(BikeId);
            if (findBike != null)
            {
                Console.WriteLine("Enter the New Brand");
                var input = Console.ReadLine();
                var NBrand = CapitalizeTitle(input);
                Console.WriteLine("Enter the New Model");
                var NModel = Console.ReadLine();
                var RentalPrice = ValidateBikeRentalPrice();
                var Nbike = new Bike
                {
                    BikeId = BikeId,
                    Brand = NBrand,
                    Model = NModel,
                    RentalPrice = RentalPrice
                };
                // this.BikesList.Add(Nbike);
                bikeRepository.UpdateBike(Nbike);
            }
            else
            {
                Console.WriteLine("Invalid Id");
            }
        }
        public void DeleteBike()
        {
            Console.WriteLine("Enter the bike ID to be Deleted");
            var BikeId = int.Parse(Console.ReadLine());
            // var findBike = this.BikesList.Where(b => b.BikeId == BikeId).FirstOrDefault();
            var findBike = bikeRepository.GetBikeByID(BikeId);
            if (findBike != null)
            {
                bikeRepository.DeleteBike(BikeId);
            }
            else
            {
                Console.WriteLine("Invalid Id");
            }
        }

        public void GetBikeByID()
        {
            Console.WriteLine("Enter the BikeID ");
            int bikeId = int.Parse(Console.ReadLine());
            var data = bikeRepository.GetBikeByID(bikeId);
            if ((data !=null))
            {
                Console.WriteLine(data);
            }
            else
            {

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

        public string CapitalizeTitle(string str)
        {
            string firstLetter = str.Substring(0, 1);
            string remaining = str.Substring(1,str.Length-1);
            return $"{firstLetter.ToUpper()}{remaining}";
        }

    }
}
