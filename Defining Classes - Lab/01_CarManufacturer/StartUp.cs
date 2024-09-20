using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {

            List<Tire[]> allTirePairs = new List<Tire[]>();
            string tireInfo = string.Empty;

            while ((tireInfo = Console.ReadLine()) != "No more tires")
            {
                List<Tire> tirePairs = new() ;
                string[] tirePairsInfo = tireInfo.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < tirePairsInfo.Length-1; i+=2)
                {
                    int tireYear = int.Parse(tirePairsInfo[i]);
                    double tirePressure = double.Parse(tirePairsInfo[i+1]);

                    Tire tire = new Tire(tireYear, tirePressure);
                    tirePairs.Add(tire);
                }

                allTirePairs.Add(tirePairs.ToArray());
            }

            List<Engine> engines = new List<Engine>();
            string engineInfo = string.Empty;

            while ((engineInfo = Console.ReadLine()) != "Engines done")
            {
                string[] engineInfoPairs = engineInfo.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int engineHorsePower = int.Parse(engineInfoPairs[0]);
                double engineCubicCapacity = double.Parse(engineInfoPairs[1]);

                Engine engine = new Engine(engineHorsePower, engineCubicCapacity);
                engines.Add(engine);
            }

            string input = string.Empty;

            List<Car> cars = new List<Car>();

            while ((input = Console.ReadLine()) != "Show special")
            {
                string[] inputInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string make = inputInfo[0];
                string model = inputInfo[1];
                int year = int.Parse(inputInfo[2]);
                double fuelQuantity = double.Parse(inputInfo[3]);
                double fuelConsumption = double.Parse(inputInfo[4]);
                int engineIndex = int.Parse(inputInfo[5]);
                int tiresIndex = int.Parse(inputInfo[6]);

                Engine engineWanted = engines[engineIndex];
                Tire[] tiresWanted = allTirePairs[tiresIndex];

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engineWanted, tiresWanted);

                cars.Add(car);
            }

            foreach (var car in cars.Where(car=>car.Year >= 2017).Where(car =>car.Engine.HorsePower > 330).Where(car => car.Tires.Sum(tire=>tire.Pressure) >=9 && car.Tires.Sum(tire=>tire.Pressure) <= 10))
            {
                car.Drive(20);
                Console.WriteLine(car.WhoAmI());
            }
        }




        //Tire[] tires = new Tire[4]
        //{
        //    new Tire(1, 2.5),
        //    new Tire(1, 2.1),
        //    new Tire(2, 0.5),
        //    new Tire(2, 2.3),

        //};

        //var engine = new Engine(560, 6300);
        //var car = new Car("Lamborgini", "Urus", 2010, 250, 9, engine, tires);

        //string make = Console.ReadLine();
        //string model = Console.ReadLine();
        //int year = int.Parse(Console.ReadLine());
        //double fuelQuantity = double.Parse(Console.ReadLine());
        //double fuelConsumption = double.Parse(Console.ReadLine());

        //Car firstCar = new Car();
        //Car secondCar = new Car(make, model, year);
        //Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);
        //Console.WriteLine(firstCar.WhoAmI());
        //Console.WriteLine(secondCar.WhoAmI());
        //Console.WriteLine(thirdCar.WhoAmI());
        //Console.WriteLine(car.WhoAmI());
        
}
}
