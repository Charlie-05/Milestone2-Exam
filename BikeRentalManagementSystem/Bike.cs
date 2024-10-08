using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BikeRentalManagementSystem
{
    internal class Bike
    {
        public Bike(int bikeId, string brand, string model, decimal rentalPrice)
        {
            this.BikeId = bikeId;
            this.Brand = brand;
            this.Model = model;
            this.RentalPrice = rentalPrice;
        }
        public int BikeId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal RentalPrice { get; set; }

        public override string ToString()
        {
            return $"Bike ID:{BikeId}, Bike Brand:{Brand}, Bike Model :{Model}, Rental Price :{RentalPrice}";
        }

    }
}
