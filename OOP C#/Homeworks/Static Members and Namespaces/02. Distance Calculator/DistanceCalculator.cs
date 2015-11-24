namespace _02.Distance_Calculator
{
    using _01.Point3D;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class DistanceCalculator
    {
        public static void CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            var distance = Math.Sqrt(Math.Pow((firstPoint.X - secondPoint.X), 2) +
                                     Math.Pow((firstPoint.Y - secondPoint.Y), 2) +
                                     Math.Pow((firstPoint.Z - secondPoint.Z), 2));
            Console.WriteLine("Distance  = {0}", distance);
        }
    }
}
