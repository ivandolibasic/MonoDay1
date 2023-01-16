namespace OOP
{
    public interface ICarFeatures
    {
        public int NumberOfDoors { get; set; }
        public bool HasSunroof { get; set; }
        public bool HasNavigationSystem { get; set; }
        public void StartNavigation();
    }
}