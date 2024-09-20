
namespace SpeedRacing
{
    public class Car
    {
        public Car(string model, double fuelAmount, double consumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            ConsumptionPerKilometer = consumptionPerKilometer;
            TravvelledDistance = 0;
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double ConsumptionPerKilometer { get; set; }
        public double TravvelledDistance { get; set; }


        public void Drive(int distanceToDrive) 
        {
            if (FuelAmount < distanceToDrive * ConsumptionPerKilometer)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else 
            {
                double usedFuel = distanceToDrive * ConsumptionPerKilometer;
                FuelAmount -= usedFuel;
                TravvelledDistance += distanceToDrive;
            }
        }
    }
}
