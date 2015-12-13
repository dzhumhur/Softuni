namespace _02.Interest_Calculator
{
    public delegate decimal GetSimpleInterest(decimal money, decimal interest, int years);

    public class InterestCalculator
    {
        private GetSimpleInterest interestCalc;

        public InterestCalculator(decimal money, decimal interest, int year, GetSimpleInterest interestCalc)
        {
            this.Money = money;
            this.Interest = interest;
            this.Year = year;
            this.interestCalc = interestCalc;
        }

        public decimal Money { get; set; }

        public decimal Interest { get; set; }

        public int Year { get; set; }

        public override string ToString()
        {
            return string.Format("{0:f4}", this.interestCalc(this.Money, this.Interest, this.Year));
        }
    }
}
