
namespace RawData
{
    public class StartUp
    {
        public static void Main()
        {
            List<Car> cars = new List<Car>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Car car = new Car
                    (
                    input[0],
                    int.Parse(input[1]), int.Parse(input[2]),
                    int.Parse(input[3]), input[4],
                    double.Parse(input[5]), int.Parse(input[6]),
                    double.Parse(input[7]), int.Parse(input[8]),
                    double.Parse(input[9]), int.Parse(input[10]),
                    double.Parse(input[11]), int.Parse(input[12])
                    );

                cars.Add(car);
            }

            string type = Console.ReadLine();

            string[] filtered;

            if (type == "fragile")
            {
                filtered = cars.Where(c => c.Cargo.Type == type 
                                && c.Tires.Any(t => t.Pressure < 1))
                               .Select(c=>c.Model)
                               .ToArray();
            }
            else 
            {
            filtered = cars.Where(c=>c.Cargo.Type == "flammable" 
                            && c.Engine.Power > 250)
                            .Select(c=>c.Model).ToArray();

            }

            Console.WriteLine(string.Join(Environment.NewLine, filtered));
        }
    }
}
