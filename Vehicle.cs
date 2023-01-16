namespace OOP
{
    public abstract class Vehicle
    {
        public string? Manufacturer;
        public string? Model;
        public int YearOfProduction;

        public abstract void StartEngine();
    }
}