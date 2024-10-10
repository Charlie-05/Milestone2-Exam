using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagementSystem
{
    internal class PetrolBike : Bike
    {
        public string FuelTankCapacity {   get; set; }
        public string EngineCapacity { get; set; }  
         public PetrolBike() { }
        public PetrolBike(string fuelTankCapacity, string engineCapacity) : base()
        {
            FuelTankCapacity = fuelTankCapacity;
            EngineCapacity = engineCapacity;
        }

        public string DisplayPetrolBikeInfo()
        {
            return $"{this.BikeId} {this.Brand}, {this.Model} {this.RentalPrice} {this.FuelTankCapacity} {this.EngineCapacity}";
        }

        public override string DisplayBikeInfo()
        {
            return ($"Bike ID:{BikeId}, Bike Brand:{Brand}, Bike Model :{Model}, Rental Price :{RentalPrice} ,FuelTankCapacity{FuelTankCapacity} , EngineCapacity{EngineCapacity}");
        }

    }
}
