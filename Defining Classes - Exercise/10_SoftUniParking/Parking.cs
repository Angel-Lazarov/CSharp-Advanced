
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    public class Parking
    {
        private List<Car> cars;
        private int capacity;


        public Parking(int capacity)    
        {
            cars = new List<Car>();
            this.capacity = capacity;
        }


        public int Count
        {
            get { return cars.Count; }
        }


        public string AddCar(Car car)
        {
            if (cars.Any(c => c.RegistrationNumber == car.RegistrationNumber))
            {
                return $"Car with that registration number, already exists!";
            }
            else
            {
                if (Count >= capacity)
                {
                    return "Parking is full!";
                }
                else
                {
                    cars.Add(car);
                    return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
                }
            }
        }

        public string RemoveCar(string registrationNumber) 
        {
            if (cars.Any(c => c.RegistrationNumber == registrationNumber))
            {
                Car currentCar = cars.FirstOrDefault(c => c.RegistrationNumber == registrationNumber);
                cars.Remove(currentCar);
                return $"Successfully removed {currentCar.RegistrationNumber}";
            }
            else 
            {
                return "Car with that registration number, doesn't exist!";
            }
        
        }

        public Car GetCar(string RegistrationNumber) 
        {
            Car car = cars.FirstOrDefault(c => c.RegistrationNumber == RegistrationNumber);

            return car;
        }

        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers) 
        {
            foreach (string registrationNumber in RegistrationNumbers) 
            {
                //if (cars.Any(cars => cars.RegistrationNumber == registrationNumber)) 
                //{
                //    Car currentCar = cars.Find(cars => cars.RegistrationNumber == registrationNumber);

                //    cars.Remove(currentCar);
                //}
                RemoveCar(registrationNumber);
            }
        }
    }
}
