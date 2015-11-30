namespace TheSlum.Interfaces
{
    using System;

    public class Circle : IShape
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
                    throw new ArgumentOutOfRangeException("Radius should be greater than 0");
                }

                this.radius = value;
            }
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * this.Radius;
        }

        public override string ToString()
        {
            return string.Format(" Circle:\n -> Area: {0:f2}, Perimeter: {1:f2}\n",
                                this.CalculateArea(),
                                this.CalculatePerimeter());
        }
    }
}
