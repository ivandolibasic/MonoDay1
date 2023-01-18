namespace OOP
{
    interface ICarFeatures
    {
        int NumberOfDoors { get; set; }
        bool HasSunroof { get; set; }
        bool HasNavigationSystem { get; set; }
        void StartNavigation();
    }
}