namespace _01.Point3D
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class ConsoleClient
    {
        static void Main(string[] args)
        {
            var point = new Point3D(1, 3, 5);

            Console.WriteLine(Point3D.StartPoint);
            Console.WriteLine(point);
        }
    }
}
