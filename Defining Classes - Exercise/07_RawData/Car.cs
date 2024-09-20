
namespace RawData
{
    public class Car
    {
        public Car(string model,
            int speed, int power, //engine
            int weight, string type,  //cargo
            double tire1pressure, int tire1age,
            double tire2pressure, int tire2age,
            double tire3pressure, int tire3age,
            double tire4pressure, int tire4age
            )
        {
            Model = model;
            Engine = new Engine(speed,  power);
            Cargo = new Cargo(weight, type);
            Tires = new Tire[4];
            Tires[0] = new Tire(tire1pressure, tire1age);
            Tires[1] = new Tire(tire2pressure, tire2age);
            Tires[2] = new Tire(tire3pressure, tire3age);
            Tires[3] = new Tire(tire4pressure, tire4age);
        }

        public string Model  { get; set; }

        public Cargo Cargo { get; set; }

        public Tire[] Tires { get; set; }
        public Engine Engine { get; set; }

    }
}
