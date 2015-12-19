namespace _01.Galactic_GPS
{
    using System;
    using System.Collections.Generic;

    class ConsoleClient
    {
        static void Main()
        {
            List<Location> locations = new List<Location>
            {
                new Location(85, 70, Planet.Mars),
                new Location(45, 40, Planet.Jupiter),
                new Location(65, 170, Planet.Neptun),
                new Location(90, 90, Planet.Earth),
            };

            locations.ForEach(l => Console.WriteLine(l));
        }
    }
}
