namespace Abstraction
{
    using System;

    class Circle : IFigure
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get { return this.radius; }

            set
            {
                if (value < 0.1)
                {
                    throw new ArgumentException("Radius should be greater than 0");
                }

                this.radius = value;
            }
        }

        public double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }

        public override string ToString()
        {
            var result = string.Format("I am {0}. My perimeter is {1:f2}. My surface is {2:f2}.",
                                        this.GetType().Name,
                                        this.CalcPerimeter(),
                                        this.CalcSurface());
            return result;
        }
    }
}
