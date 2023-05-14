namespace Task_2
{
    using System;

    abstract class Vehicle
    {
        public int FuelLevel { get; protected set; }
        public int FuelConsumption { get; protected set; }

        public abstract void ShowInfo();
        public void SetFuelLevel(int level)
        {
            FuelLevel = level;
        }

        public int CalculateFuelConsumption(int distance)
        {
            return distance * FuelConsumption;
        }
    }

    class Car : Vehicle
    {
        public string Brand { get; private set; }
        public int MaxSpeed { get; private set; }

        public Car(string brand, int maxSpeed, int fuelConsumption)
        {
            Brand = brand;
            MaxSpeed = maxSpeed;
            FuelConsumption = fuelConsumption;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Brand: {0}", Brand);
            Console.WriteLine("Max speed: {0} km/h", MaxSpeed);
            Console.WriteLine("Fuel consumption: {0} liters per 100 km", FuelConsumption);
            Console.WriteLine("Fuel level: {0} liters", FuelLevel);
        }
    }

    class Truck : Vehicle
    {
        public string Model { get; private set; }
        public int PayloadCapacity { get; private set; }

        public Truck(string model, int payloadCapacity, int fuelConsumption)
        {
            Model = model;
            PayloadCapacity = payloadCapacity;
            FuelConsumption = fuelConsumption;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Model: {0}", Model);
            Console.WriteLine("Payload capacity: {0} kg", PayloadCapacity);
            Console.WriteLine("Fuel consumption: {0} liters per 100 km", FuelConsumption);
            Console.WriteLine("Fuel level: {0} liters", FuelLevel);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[5];
            vehicles[0] = new Car("BMW", 220, 8);
            vehicles[1] = new Car("Toyota", 180, 6);
            vehicles[2] = new Truck("MAN", 5000, 25);
            vehicles[3] = new Truck("Volvo", 8000, 30);
            vehicles[4] = new Car("Mercedes", 240, 9);

            int totalFuelConsumption = 0;
            foreach (Vehicle v in vehicles)
            {
                Random random = new Random();
                v.SetFuelLevel(45); 
                v.ShowInfo();
                totalFuelConsumption += v.CalculateFuelConsumption(10); 
                Console.WriteLine();
            }
            Console.WriteLine("Total fuel consumption: {0} liters", totalFuelConsumption);

        }
    }
}