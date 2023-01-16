using System.Collections;

namespace OOP
{
    public class Car : Vehicle, ICarFeatures, IEnumerable<Car>
    {
        private int fuelTank;
        public int NumberOfDoors { get; set; }
        public bool HasSunroof { get; set; }
        public bool HasNavigationSystem { get; set; }

        public void SetFuelTank(int fuelTank) { this.fuelTank = fuelTank; }
        public int GetFuelTank() { return fuelTank; }

        public override void StartEngine()
        {
            Console.WriteLine($"The engine of {Manufacturer} {Model} is starting...");
        }

        public override string? ToString()
        {
            return $"Manufacturer: {Manufacturer}\nModel: {Model}\nYearOfProduction: {YearOfProduction}\nNumber of Doors: {NumberOfDoors}\nHas Sunroof: {HasSunroof}";
        }

        public void StartNavigation()
        {
            if (HasNavigationSystem)
            {
                Console.WriteLine("Navigation system is starting");
            }
            else
            {
                Console.WriteLine("This car doesn't have a navigation system");
            }
        }

        public static string? GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            var input = Console.ReadLine();
            return input;
        }
        public static int GetIntInput(string prompt)
        {
            int result;
            while (!int.TryParse(GetUserInput(prompt), out result))
                Console.WriteLine("Invalid input, please enter a valid number.");
            return result;
        }
        public static bool GetBooleanInput(string prompt)
        {
            bool result;
            while (!bool.TryParse(GetUserInput(prompt), out result))
                Console.WriteLine("Invalid input, please enter either true or false.");
            return result;
        }
        public static void SetCarProperties(Car car)
        {
            car.Manufacturer = GetUserInput("Enter the manufacturer of the car:");
            car.Model = GetUserInput("Enter the model of the car:");
            car.YearOfProduction = GetIntInput("Enter the year of production of the car:");
            car.NumberOfDoors = GetIntInput("Enter the number of doors of the car:");
            car.HasSunroof = GetBooleanInput("Does the car have a sunroof (True/False)");
            car.HasNavigationSystem = GetBooleanInput("Does the car have a navigation system (True/False)");
        }

        public IEnumerator<Car> GetEnumerator()
        {
            yield return this;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}