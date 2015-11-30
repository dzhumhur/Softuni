namespace TheSlum.Shapes
{
    using System;

    public class Rhombus : BasicShape
    {
        private double sideA;

        public Rhombus(double sideA, double width, double height)
                      : base(width, height)
        {
            this.SideA = sideA;
        }

        public double SideA
        {
            get { return this.sideA; }
            set
            {
                if (value < 0.1)
                {
                    throw new ArgumentOutOfRangeException("Side A should be greater than 0");
                }

                this.sideA = value;
            }
        }

        public override double CalculateArea()
        {
            return this.Height * this.Width;
        }

        public override double CalculatePerimeter()
        {
            return this.SideA * 4;
        }
    }
}
