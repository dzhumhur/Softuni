namespace _04.SULS
{
    public class DropoutStudent : Student
    {
        private string dropoutReason;

        public DropoutStudent(string firstName, string lastName, int age,
                              string studentNumber, double avgGrade, string dropoutReason)
                              :base(firstName, lastName, age, studentNumber, avgGrade)
        {
            this.DropoutReason = dropoutReason;
        }

        public string DropoutReason
        {
            get { return this.dropoutReason; }
            set { this.dropoutReason = value; }
        }

        public string Reapply()
        {
            return string.Format("Firstname: {0}\nLastname: {1}\nStudent number: {2}\n" + 
                                "Average grade: {3}\nDropout reason: {4}",
                                this.FirstName,
                                this.LastName,
                                this.StudentNumber,
                                this.AverageGrade,
                                this.DropoutReason);
        }
    }
}
