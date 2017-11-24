using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Garage_Application
{
    public class Garage
    {
        public int numberOfFloors = 2;
        public int Capacity = 20;
        public List<GarageFloor> GarageFloors;

        public void SetGarage()
        {
            this.GarageFloors = new List<GarageFloor>();
            for (var i = 0; i < numberOfFloors; i++)
            {
                var floor = new GarageFloor() { FloorSection = new List<IndividualSpace>() };
                floor.ConstructFloor(Capacity);

                this.GarageFloors.Add(floor);
            }
        }

        public int AvailableSpaces()
        {
            int count = 0;
            foreach (var floor in this.GarageFloors)
            {
                foreach (var space in floor.FloorSection)
                {
                    if (space.ParkedVehicle == null)
                        count++;
                }
            }
            return count;
        }

        private IndividualSpace AvailableSpaces(int VehicleType)
        {
            foreach (var floor in this.GarageFloors)
            {
                foreach (var space in floor.FloorSection)
                {
                    if ((space.ParkedVehicle == null) && (space.vehicleSpaceType.SpaceValue == VehicleType))
                        return space;
                }
            }
            return null;
        }

        public IndividualSpace AllocateSpace(Vehicle vehicleDetail)
        {
            IndividualSpace individualSpace = AvailableSpaces(vehicleDetail.SpaceType);
            if (individualSpace != null)
            {
                individualSpace.SetParkVehical(vehicleDetail);
            }
            return individualSpace;
        }

        public int freeSpaceCounter()
        {
            int count = 0;

            foreach (var floor in this.GarageFloors)
            {
                foreach (var space in floor.FloorSection)
                {
                    if (space.ParkedVehicle == null)
                        count++;
                }
            }
            return count;
        }
    }
}