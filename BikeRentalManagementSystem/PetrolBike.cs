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
       
        public PetrolBike() : base()
        {
        }

        public string DisplayPetrolBikeInfo()
        {
            return $"{base.DisplayBikeInfo()} ,FuelTankCapacity{FuelTankCapacity} , EngineCapacity{EngineCapacity}";
        }

        public override string DisplayBikeInfo()
        {
            return ($"Bike ID:{BikeId}, Bike Brand:{Brand}, Bike Model :{Model}, Rental Price :{RentalPrice} ,FuelTankCapacity{FuelTankCapacity} , EngineCapacity{EngineCapacity}");
        }

    }
}
