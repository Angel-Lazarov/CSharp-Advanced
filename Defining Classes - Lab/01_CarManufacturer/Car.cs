using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire[] tires;

        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
            tires = new Tire[4];
        }

        public Car(string make, string model, int year) : this()
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires) : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            Tires = tires;
            Engine = engine;
        }

        public Tire[] Tires { get; set; }
        public Engine Engine { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }

        public void Drive(double distance)
        {
            if (distance/100 * this.FuelConsumption > FuelQuantity)
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
            else
            {
                FuelQuantity -= distance/100 * FuelConsumption;
            }
        }

        public string WhoAmI()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Make: {Make}");
            stringBuilder.AppendLine($"Model: {Model}");
            stringBuilder.AppendLine($"Year: {Year}");
            stringBuilder.AppendLine($"HorsePowers: {Engine.HorsePower}");
            stringBuilder.AppendLine($"FuelQuantity: {FuelQuantity}");

            return stringBuilder.ToString().Trim();
        }
    }
}
