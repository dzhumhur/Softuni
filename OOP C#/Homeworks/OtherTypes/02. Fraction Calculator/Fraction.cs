namespace _02.Fraction_Calculator
{
    using System;
    using System.Numerics;

    public struct Fraction
    {
        private BigInteger numerator;
        private BigInteger denominator;

        public Fraction(BigInteger numerator, BigInteger denominator) : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public BigInteger Numerator
        {
            get { return this.numerator; }
            set
            {
                if (value < -9223372036854775808 || value > 9223372036854775807)
                {
                    throw new ArgumentOutOfRangeException(
                        "Numerator must be in range[-9223372036854775808...9223372036854775807]");
                }

                this.numerator = value;
            }
        }

        public BigInteger Denominator
        {
            get { return this.denominator; }
            set
            {
                if (value == 0)
                {
                    throw new Exception("Denumerator cannot be null");
                }

                if (value < -9223372036854775808 || value > 9223372036854775807)
                {
                    throw new ArgumentOutOfRangeException(
                        "Denominator must be in range[-9223372036854775808...9223372036854775807]");
                }

                this.denominator = value;
            }
        }

        public static Fraction operator +(Fraction fraction1, Fraction fraction2)
        {
            var newFraction = new Fraction();
            if (fraction1.Denominator != fraction2.Denominator)
            {
                fraction1.Numerator *= fraction2.Denominator;
                fraction2.Numerator *= fraction1.Denominator;
                newFraction.Denominator = fraction2.Denominator * fraction1.Denominator;
                newFraction.Numerator = fraction1.Numerator + fraction2.Numerator;
            }
            else
            {
                newFraction.Numerator = fraction1.Numerator + fraction2.Numerator;
                newFraction.Denominator = fraction2.Denominator;

            }
            return newFraction;
        }

        public static Fraction operator -(Fraction fraction1, Fraction fraction2)
        {
            var newFraction = new Fraction();
            if (fraction1.Denominator != fraction2.Denominator)
            {
                fraction1.Numerator *= fraction2.Denominator;
                fraction2.Numerator *= fraction1.Denominator;
                newFraction.Denominator = fraction2.Denominator * fraction1.Denominator;
                newFraction.Numerator = fraction1.Numerator - fraction2.Numerator;
            }
            else
            {
                newFraction.Numerator = fraction1.Numerator - fraction2.Numerator;
                newFraction.Denominator = fraction2.Denominator;

            }
            return newFraction;
        }

        public override string ToString()
        {
            decimal result = (decimal)this.Numerator / (decimal)this.Denominator;

            return string.Format("{0:f27}", result);
        }
    }
}
