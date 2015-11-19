namespace _04.SULS
{
    public class OnsiteStudent : CurrentStudent
    {
        private int numberOfVisits;

        public OnsiteStudent(string firstName, string lastName, int age,
                             string studentNumber, double avgGrade, string currCourse, int numberOfVisits)
                            :base (firstName, lastName, age, studentNumber, avgGrade, currCourse)
        {
            this.NumberOfVisits = numberOfVisits;
        }

        public int NumberOfVisits
        {
            get { return this.numberOfVisits; }
            set { this.numberOfVisits = value; }
        }
    }
}
