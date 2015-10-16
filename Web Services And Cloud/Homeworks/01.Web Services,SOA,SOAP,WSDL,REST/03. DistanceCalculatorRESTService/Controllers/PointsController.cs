using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _03.DistanceCalculatorRESTService.Controllers
{
    public class PointsController : ApiController
    {
        public double GetDistance(int startX, int startY, int endX, int endY)
        {
            double deltaX = startX - endX;
            double deltaY = startY - endY;
            double pointsDistance = Math.Sqrt(Math.Pow(deltaX, 2) - Math.Pow(deltaY, 2));

            return pointsDistance;
        }
    }
}
