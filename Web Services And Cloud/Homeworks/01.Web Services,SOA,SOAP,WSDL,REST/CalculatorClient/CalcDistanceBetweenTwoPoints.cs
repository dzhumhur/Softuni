namespace CalculatorClient
{
    using System;
    using ServiceReference1;

    class CalcDistanceBetweenTwoPoints
    {
        static void Main()
        {
            var service = new ServiceDistanceCalculatorClient();
            var startPoint = new Point{x = 5, y = 10};
            var endPoint = new Point{x = 4, y = 3};
            var distance = service.CalcDistance(startPoint, endPoint);

            Console.WriteLine("Start Point - ({0}, {1})\nEnd Point - ({2}, {3})", startPoint.x, startPoint.y, endPoint.x, endPoint.y);
            Console.WriteLine("The distance = {0:F5}", distance);
        }
    }
}
