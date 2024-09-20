
namespace CarSalesman
{
    public class Car
    {
        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }

        public Car(string model, Engine engine, int weight) :this(model, engine)
        {
            Weight = weight;
        }

        public Car(string model, Engine engine, string color) : this(model, engine)
        {
            Color = color;
        }

        public Car(string model, Engine engine, int weight, string color) : this(model, engine) 
        {
            Weight = weight;
            Color = color;
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            if (Weight != default && Color != default)
            {
                return $"{Model}: \n" +
                   $"{Engine} \n" +
                   $"  Weight: {Weight} \n" +
                   $"  Color: {Color} ";
            }
            else if (Weight == default && Color != default)
            {
                return $"{Model}: \n" +
                       $"{Engine} \n" +
                       $"  Weight: n/a \n" +
                       $"  Color: {Color} ";
            }
            else if (Weight != default && Color == default)
            {
                return $"{Model}: \n" +
                       $"{Engine} \n" +
                       $"  Weight: {Weight}\n" +
                       $"  Color: n/a ";
            }
            else //if (Weight == default && Color == default)
            {
                return $"{Model}: \n" +
                       $"{Engine} \n" +
                       $"  Weight: n/a \n" +
                       $"  Color: n/a ";
            }
        }
    }
}
