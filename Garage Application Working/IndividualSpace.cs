using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Application
{
    public class IndividualSpace
    {
        public VehicleType AllowedVehicleType = VehicleType.Bike;

        private Vehicle parkedVehicle = null;

        public Vehicle ParkedVehicle { get => parkedVehicle; set => parkedVehicle = value; }

        public void SetParkVehical(Vehicle vehicle)
        {
            this.ParkedVehicle = vehicle;
        }
        public SpaceType vehicleSpaceType = new SpaceType();
    }
}