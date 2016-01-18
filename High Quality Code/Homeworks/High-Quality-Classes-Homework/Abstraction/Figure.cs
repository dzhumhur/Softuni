namespace Abstraction
{
    using System;

    public abstract class Figure : IFigure
    {
        private double width;
        private double height;

        protected Figure(double width, double height)
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
                    throw new ArgumentException("Width should be greater than 0");
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
                    throw new ArgumentException("Height should be greater than 0");
                }

                this.height = value;
            }
        }

        public abstract double CalcPerimeter();
        public abstract double CalcSurface();

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
