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

        public void CreateBike(Bike bike)
        {
            this.BikesList.Add(bike);
            Console.WriteLine("Added Successfully");
        }
        public void ReadBikes()
        {
            foreach (var item in BikesList)
            {
                Console.WriteLine(item);
            }
        }

        public void UpdateBike(int bikeId, Bike bike)
        {
            var findBike = this.BikesList.Where(b => b.BikeId == bikeId).FirstOrDefault();
            if (findBike != null)
            {
                this.BikesList.Remove(findBike);
                var addBike = new Bike();
                addBike.BikeId = bikeId;
                addBike.Brand = bike.Brand;
                addBike.Model = bike.Model;
                addBike.RentalPrice = bike.RentalPrice;
                this.CreateBike(addBike);
                Console.WriteLine("Successfully updated");
                this.ReadBikes();

            }
            else
            {
                Console.WriteLine("Invalid Id");
            }
        }
        public void DeleteBike(int bikeId)
        {
            var findBike = this.BikesList.Where(b => b.BikeId == bikeId).FirstOrDefault();
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

    }
}
