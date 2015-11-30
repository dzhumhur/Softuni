namespace TheSlum.Shapes
{
    using System;
    using Interfaces;

    public abstract class BasicShape : IShape
    {
        private double width;
        private double height;

        protected BasicShape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get { return this.width; }
            set
            {
                if (value < 0.1)
                {
                    throw new ArgumentOutOfRangeException("Width should greater than 0");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get { return this.height; }
            set
            {
                if (value < 0.1)
                {
                    throw new ArgumentOutOfRangeException("Height should greater than 0");
                }

                this.height = value;
            }
        }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();

        public override string ToString()
        {
            return string.Format(" {0}:\n -> Area: {1}, Perimeter: {2}\n",
                                this.GetType().Name,
                                this.CalculateArea(),
                                this.CalculatePerimeter());
        }
    }
}
