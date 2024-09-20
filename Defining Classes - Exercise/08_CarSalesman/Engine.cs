
namespace CarSalesman
{
    public class Engine
    {
        public Engine(string model, int power)
        {
            Model = model;
            Power = power;
        }

        public Engine(string model, int power, int displacement) : this(model, power) 
        {
            Displacement = displacement;
        }

        public Engine(string model, int power, string efficiency) : this(model, power) 
        {
            Efficiency = efficiency;
        }

        public Engine(string model, int power, int displacement, string efficiency) : this (model, power)
        {
            Displacement = displacement;
            Efficiency = efficiency;
        }

        public string Model { get; set; }
        public int Power { get; set; }
        public int Displacement { get; set; }
        public string Efficiency { get; set; }
        
        public override string ToString()
        {
            if (Efficiency != null && Displacement == 0)
            {
                return $"  {Model}: \n" +
                         $"    Power: {Power} \n" +
                         $"    Displacement: n/a \n" +
                         $"    Efficiency: {Efficiency}";
            }
            else if (Efficiency == null && Displacement != 0)
            {
                return $"  {Model}: \n" +
                         $"    Power: {Power} \n" +
                         $"    Displacement: {Displacement} \n" +
                         $"    Efficiency: n/a";
            }
            else if (Efficiency == null && Displacement == 0)
            {
                return $"  {Model}: \n" +
                         $"    Power: {Power} \n" +
                         $"    Displacement: n/a \n" +
                         $"    Efficiency: n/a";
            }
            else
            {
                return $"  {Model}: \n" +
                         $"    Power: {Power} \n" +
                         $"    Displacement: {Displacement} \n" +
                         $"    Efficiency: {Efficiency}";
            }
        }
    }
}
