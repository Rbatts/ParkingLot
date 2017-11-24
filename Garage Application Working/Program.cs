using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var garage = new Garage();
            garage.SetGarage();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n Spaces Left On All Floors = {garage.AvailableSpaces()}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n Make      -  Model  -  Year  -  Colour -  Plate     -  Vehicle Size");
            Console.ResetColor();
            Console.ReadLine();

            Vehicle myVehicle = new Vehicle();
            SpaceType mySpace = new SpaceType();
            myVehicle.Make = "Vauxhall";
            myVehicle.Model = "Astra";
            myVehicle.Year = 2006;
            myVehicle.Colour = "Opal";
            myVehicle.LicensePlate = "DX06 TGP";
            myVehicle.SpaceType = 2;
            IndividualSpace vehicleSpace = garage.AllocateSpace(myVehicle);
            if (vehicleSpace == null)
            {
                Console.WriteLine("Could not allocate space");
            }
            Console.WriteLine("\n {0}  -  {1}  -  {2}  -  {3}   -  {4}  -  {5}",
            myVehicle.Make,
            myVehicle.Model,
            myVehicle.Year,
            myVehicle.Colour,
            myVehicle.LicensePlate,
            myVehicle.SpaceType = 2);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n Avaliable Spaces Left {garage.AvailableSpaces()}");
            Console.ReadLine();
            Console.ResetColor();

            Vehicle myBike = new Vehicle();
            myBike.Make = "\n Ducati";
            myBike.Model = "G600";
            myBike.Year = 2011;
            myBike.Colour = "Red";
            myBike.LicensePlate = "SG11 TUO";
            myBike.SpaceType = 1;
            IndividualSpace BikeSpace = garage.AllocateSpace(myBike);
            if (BikeSpace == null)
            {
                Console.WriteLine("No Bike Spaces Available");
            }
            Console.WriteLine(" {0}    -  {1}   -  {2}  -  {3}    -  {4}  -  {5}",
            myBike.Make,
            myBike.Model,
            myBike.Year,
            myBike.Colour,
            myBike.LicensePlate,
            myBike.SpaceType = 1);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n Avaliable Spaces Left {garage.AvailableSpaces()}");
            Console.ReadLine();
            Console.ResetColor();

            Vehicle myVan = new Vehicle();
            myVan.Make = "\n Ford";
            myVan.Model = "Haul";
            myVan.Year = 2009;
            myVan.Colour = "White";
            myVan.LicensePlate = "WP09 QPL";
            myVan.SpaceType = 3;

            IndividualSpace vanSpace = garage.AllocateSpace(myVan);
            if (vanSpace == null)
            {
                Console.WriteLine("No Van Spaces Available");
            }

            Console.WriteLine(" {0}      -  {1}   -  {2}  -  {3}  -  {4}  -  {5}",
            myVan.Make,
            myVan.Model,
            myVan.Year,
            myVan.Colour,
            myVan.LicensePlate,
            myVan.SpaceType = 3);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n Avaliable Spaces Left {garage.AvailableSpaces()}");
            Console.ReadLine();
            Console.ResetColor();
        }
    }
}
