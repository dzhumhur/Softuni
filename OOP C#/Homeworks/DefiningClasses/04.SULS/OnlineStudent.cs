namespace _04.SULS
{
    public class OnlineStudent : CurrentStudent
    {
        public OnlineStudent(string firstName, string lastName, int age,
                             string studentNumber, double avgGrade, string currCourse)
                            :base (firstName, lastName, age, studentNumber, avgGrade, currCourse)
        {

        }
    }
}
