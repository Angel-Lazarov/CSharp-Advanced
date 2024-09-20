using System.Text;

namespace AutomotiveRepairShop
{
    public class Vehicle
    {
        //22:23 - 22:43/23:03

        public Vehicle(string vin, int mileage, string damage)
        {
            VIN = vin;
            Mileage = mileage;
            Damage = damage;
        }

        public string VIN { get; set; }
        public int Mileage { get; set; }
        public string Damage { get; set; }

        public override string ToString()
        {
            return $"Damage: {Damage}, Vehicle: {VIN} ({Mileage} km)";
        }

    }
}
