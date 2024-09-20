

namespace SpeedRacing
{
    public class StartUp
    {
        public static void Main()
        {
            List<Car> cars = new List<Car>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Car car = new Car(carInfo[0], double.Parse(carInfo[1]), double.Parse(carInfo[2]));

                cars.Add(car);
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                // Drive {carModel} {amountOfKm}"

                Car currentCar = cars.FirstOrDefault(c => c.Model == commandInfo[1]);

                currentCar.Drive(int.Parse(commandInfo[2]));
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravvelledDistance}");
            }
        }

    }
}
