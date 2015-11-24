namespace _02.Distance_Calculator
{
    using _01.Point3D;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class ConsoleClient
    {
        static void Main(string[] args)
        {
            var firstPoint = new Point3D(3, 14, 20);
            var secondPoint = new Point3D(1, 9, 11);

            DistanceCalculator.CalculateDistance(firstPoint, secondPoint);
        }
    }
}
