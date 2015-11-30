namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using TheSlum.Interfaces;
    using TheSlum.Shapes;

    class ConsoleClient
    {
        static void Main()
        {
            List<IShape> shapes = new List<IShape>()
            {
                new Circle(5),
                new Rectangle(5, 10),
                new Rhombus(4, 5, 8)
            };

            shapes.ForEach(Console.WriteLine);
        }
    }
}
