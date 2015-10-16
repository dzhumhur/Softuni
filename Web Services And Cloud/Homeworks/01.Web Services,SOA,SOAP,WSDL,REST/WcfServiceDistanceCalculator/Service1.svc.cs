namespace WcfServiceDistanceCalculator
{
    using System;
    using System.Drawing;

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceDistanceCalculator" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceDistanceCalculator.svc or ServiceDistanceCalculator.svc.cs at the Solution Explorer and start debugging.
    public class ServiceDistanceCalculator : IServiceDistanceCalculator
    {
        public double CalcDistance(Point startPoint, Point endPoint)
        {
            double deltaX = startPoint.X - endPoint.X;
            double deltaY = startPoint.Y - endPoint.Y;

            double distance = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));

            return distance;
        }
    }
}
