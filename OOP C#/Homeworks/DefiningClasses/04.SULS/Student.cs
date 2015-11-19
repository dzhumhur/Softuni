namespace _04.SULS
{
    public class Student : Person
    {
        private string studentNumber;
        private double averageGrade;

        public Student(string firstName, string lastName, int age, 
                        string studentNumber, double avgGrade)
                        : base (firstName, lastName, age)
        {
            this.StudentNumber = studentNumber;
            this.AverageGrade = avgGrade;
        }
        public string StudentNumber
        {
            get { return this.studentNumber; }
            set { this.studentNumber = value; }
        }

        public double AverageGrade
        {
            get { return this.averageGrade; }
            set { this.averageGrade = value; }
        }
    }
}
