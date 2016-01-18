using System;

namespace Abstraction
{
    class FiguresExample
    {
        static void Main()
        {
            Circle circle = new Circle(5);
            Rectangle rect = new Rectangle(10, 5);

            Console.WriteLine(circle);
            Console.WriteLine(rect);
        }
    }
}
