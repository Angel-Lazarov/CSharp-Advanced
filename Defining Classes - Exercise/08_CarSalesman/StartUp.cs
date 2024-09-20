
namespace CarSalesman
{
    public class StartUp
    {
        public static void Main()
        {
            int enginesCount = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < enginesCount; i++)
            {
                // ENGINE -> "{model} {power} {displacement} {efficiency}"
                string[] engineInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (engineInfo.Length == 2)
                {
                    Engine engine = new Engine(engineInfo[0], int.Parse(engineInfo[1]));
                    engines.Add(engine);
                }
                else if (engineInfo.Length == 3)
                {
                    if (char.IsLetter(engineInfo[2][0]))
                    {
                        Engine engine = new Engine(engineInfo[0], int.Parse(engineInfo[1]), engineInfo[2]);
                        engines.Add(engine);
                    }
                    else if (char.IsDigit(engineInfo[2][0]))
                    {
                        Engine engine = new Engine(engineInfo[0], int.Parse(engineInfo[1]), int.Parse(engineInfo[2]));
                        engines.Add(engine);
                    }
                }
                else if (engineInfo.Length == 4)
                {
                    Engine engine = new Engine(engineInfo[0], int.Parse(engineInfo[1]), int.Parse(engineInfo[2]), engineInfo[3]);
                    engines.Add(engine);
                }
            }

            List<Car> cars = new List<Car>();
            int carsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carsCount; i++)
            {
                // CAR -> "{model} {engine} {weight} {color}".

                string[] carInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string carModel = carInfo[0];
                string engineModel = carInfo[1];

                Engine currentEngine = engines.FirstOrDefault(e => e.Model == engineModel);

                if (carInfo.Length == 2)
                {
                    Car car = new Car(carModel, currentEngine);
                    cars.Add(car);
                }
                else if (carInfo.Length == 4)
                {
                    Car car = new Car(carModel, currentEngine, int.Parse(carInfo[2]), carInfo[3]);
                    cars.Add(car);
                }
                else if (carInfo.Length == 3)
                {
                    if (char.IsDigit(carInfo[2][0]))
                    {
                        Car car = new Car(carModel, currentEngine, int.Parse(carInfo[2]));
                        cars.Add(car);
                    }
                    else if (char.IsLetter(carInfo[2][0]))
                    {
                        Car car = new Car(carModel, currentEngine, carInfo[2]);
                        cars.Add(car);
                    }
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
