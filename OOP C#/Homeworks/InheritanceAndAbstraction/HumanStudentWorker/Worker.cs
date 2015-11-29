namespace HumanStudentWorker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Worker : Human
    {
        public Worker(string firsName, string lastName, decimal weekSalary, int worksHourPerday)
                     : base(firsName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorksHourPerDay = worksHourPerday;
        }
        public decimal WeekSalary { get; set; }

        public int WorksHourPerDay { get; set; }

        public decimal MoneyPerOur()
        {
            decimal dailySalary = this.WeekSalary / 5;
            decimal moneyPerOur = dailySalary / this.WorksHourPerDay;
            return moneyPerOur;
        }

        public override string ToString()
        {
            return string.Format("{0} - Money Per Hour: {1:f2}",
                            base.ToString(),
                            this.MoneyPerOur());
        }
    }
}
