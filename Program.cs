namespace OOP
{
    public class Program
    {
        public static void Main()
        {
            List<Car> garage = new List<Car>();

            int carCount = int.Parse(Car.GetUserInput("Enter the number of cars you want to add:"));

            int i = 0;
            while (i < carCount)
            {
                Car car = new Car();
                Car.SetCarProperties(car);
                garage.Add(car);
                i++;
            }

            foreach (Car car in garage)
            {
                Console.WriteLine("\n" + car.ToString());
                car.StartNavigation();
            }

            List<Car> carsWithNavigationSystem = garage.Where(car => car.HasNavigationSystem == true).ToList();
            Console.WriteLine("\n" + carsWithNavigationSystem.Count);
        }
    }
}