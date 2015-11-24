namespace _03.Paths
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
            Path3D points = new Path3D();
            var firsPoint = new Point3D(5, 6, 7);
            var secondPoint = new Point3D(12, 7, 9);
            var thirdPoint = new Point3D(3, 32, 15);
            var fourthPoint = new Point3D(35, 68, 14);
            var fifthPoint = new Point3D(45, 61, 93);
            points.Add(firsPoint);
            points.Add(secondPoint);
            points.Add(thirdPoint);
            points.Add(fourthPoint);
            points.Add(fifthPoint);

            Storage.Save("exportedPoints", points);

            Path3D loadedPoints = Storage.Load("exportedPoints");
            foreach (var point in loadedPoints.Points)
            {
                Console.WriteLine(point);
            } 
        }
    }
}
