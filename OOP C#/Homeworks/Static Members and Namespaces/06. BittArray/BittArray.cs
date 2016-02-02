namespace _06.BittArray
{
    using System;

    public class BittArray
    {
        private byte[] bits;

        public BittArray(int length)
        {
            this.Bits = new byte[length];
        }

        protected byte[] Bits
        {
            get
            {
                return this.bits;
            }

            set
            {
                if (value.Length < 1 || value.Length > 1000)
                {
                    throw new ArgumentException("BitArray length should be in range [1...1000]");
                }

                this.bits = value;
            }
        }

        public byte this[int index]
        {
            get
            {
                return this.bits[index];
            }

            set
            {
                if (value == 0 || value == 1)
                {
                    this.bits[index] = value;
                }
                else
                {
                    throw new ArgumentException("Value should be 0 or 1");
                }
            }
        }

        public override string ToString()
        {
            var checker = 1;
            var sum = 0;
            foreach (var bit in this.bits)
            {
                if (bit == 1)
                {
                    sum += checker;
                }

                checker *= 2;
            }

            return sum.ToString();
        }
    }
}
