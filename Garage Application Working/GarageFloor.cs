using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Application
{
    public class GarageFloor
    {
        public List<IndividualSpace> FloorSection { get; set; }

        public void ConstructFloor(int numberOfSpaces)
        {
            this.FloorSection = new List<IndividualSpace>();
            for (int i = 0; i < 2; i++)
            {
                var ParkingSpace = new IndividualSpace();

                ParkingSpace.vehicleSpaceType.SpaceValue = 1;

                this.FloorSection.Add(ParkingSpace);
            }

            for (int i = 0; i < 6; i++)
            {
                var ParkingSpace = new IndividualSpace();

                ParkingSpace.vehicleSpaceType.SpaceValue = 2;

                this.FloorSection.Add(ParkingSpace);
            }

            for (int i = 0; i < 2; i++)
            {
                var ParkingSpace = new IndividualSpace();

                ParkingSpace.vehicleSpaceType.SpaceValue = 3;

                this.FloorSection.Add(ParkingSpace);
            }
        }
    }
}
