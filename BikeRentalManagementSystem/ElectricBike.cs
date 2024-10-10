using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagementSystem
{
    internal class ElectricBike : Bike
    {
        public string BatteryCapacity { get; set; } 
        public string MotorPower { get; set; }

        public ElectricBike() : base() { }
        public string DisplayElectricBikeInfo()
        {
            return $"{this.BikeId} {this.Brand}, {this.Model} {this.RentalPrice} {this.BatteryCapacity} {this.MotorPower}";
        }

        public override string DisplayBikeInfo()
        {
            return $"{ base.DisplayBikeInfo()},BatteryCapacity {BatteryCapacity}, MotorPower {MotorPower}";
        }
    }
}
