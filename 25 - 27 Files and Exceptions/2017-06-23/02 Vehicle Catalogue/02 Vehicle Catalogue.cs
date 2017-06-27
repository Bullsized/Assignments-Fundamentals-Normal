using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Vehicle_Catalogue
{
    class Program
    {
        //60/100 due to... no reason. The description was idiotic once again.

        //need to parse every text ToLower(), that's why. Oh well.



        static void Main(string[] args)
        {
            //{typeOfVehicle} {model} {color} {horsepower}

            List<Vehicle> VehiclesAltogether = new List<Vehicle>();

            string inputLine = Console.ReadLine();

            while (inputLine != "End")
            {
                string[] inputSplit = inputLine.Split();

                string lameExerciseDescription = string.Empty;

                if (inputSplit[0] == "car" || inputSplit[0] == "Car")
                {
                    lameExerciseDescription = "Car";
                }
                else if (inputSplit[0] == "truck" || inputSplit[0] == "Truck")
                {
                    lameExerciseDescription = "Truck";
                }
                var currentVehicle = new Vehicle()
                {
                    Type = lameExerciseDescription,
                    Model = inputSplit[1],
                    Color = inputSplit[2],
                    HPower = int.Parse(inputSplit[3])
                };

                VehiclesAltogether.Add(currentVehicle);

                inputLine = Console.ReadLine();
            }

            inputLine = Console.ReadLine();

            while (inputLine != "Close the Catalogue")
            {
                foreach (var vhcl in VehiclesAltogether)
                {
                    if (inputLine == vhcl.Model)
                    {
                        Console.WriteLine($"Type: {vhcl.Type}");
                        Console.WriteLine($"Model: {vhcl.Model}");
                        Console.WriteLine($"Color: {vhcl.Color}");
                        Console.WriteLine($"Horsepower: {vhcl.HPower}");
                    }
                }
                inputLine = Console.ReadLine();
            }


            if (VehiclesAltogether.Where(x => x.Type == "Car").Count() > 0)
            {
                double carsAverage = VehiclesAltogether.Where(x => x.Type == "Car").Select(x => x.HPower).Average();
                Console.WriteLine($"Cars have average horsepower of: {carsAverage:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: 0.00.");
            }

            if (VehiclesAltogether.Where(x => x.Type == "Truck").Count() > 0)
            {
                double trucksAverage = VehiclesAltogether.Where(x => x.Type == "Truck").Select(x => x.HPower).Average();
                Console.WriteLine($"Trucks have average horsepower of: {trucksAverage:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: 0.00.");
            }
        }
    }

    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HPower { get; set; }
    }
}