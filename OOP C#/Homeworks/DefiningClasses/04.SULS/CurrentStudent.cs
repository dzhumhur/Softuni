namespace _04.SULS
{
    public class CurrentStudent : Student
    {
        public CurrentStudent(string firstName, string lastName, int age,
                                string studentNumber, double avgGrade, string currCourse)
                               : base (firstName, lastName, age, studentNumber, avgGrade)
        {
            this.CurrentCourse = currCourse;
        }

        public string CurrentCourse { get; set; }

        public override string ToString()
        {
            return string.Format("Firstname: {0}\nLastname: {1}\nStudent number: {2}\n" +
                                "Average grade: {3}\nCurrent course: {4}\n",
                                this.FirstName,
                                this.LastName,
                                this.StudentNumber,
                                this.AverageGrade,
                                this.CurrentCourse);
        }
    }
}
