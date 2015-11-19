namespace _04.SULS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SeniorTrainer : Trainer
    {
        public SeniorTrainer(string firstName, string lastName, int age) 
                       : base (firstName, lastName, age)
        {

        }

        public void DeleteCourse(string courseName, List<Course> courses)
        {
            if (courseName != null && !string.IsNullOrWhiteSpace(courseName))
            {
                var course = courses.FirstOrDefault(c => c.Name.Equals(courseName));
                if (course != null)
                {
                    courses.Remove(course);
                    Console.WriteLine("The course {0} has been deleted", courseName);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("The course {0} could not be found", courseName);
                    Console.WriteLine();
                }
            }
        }
    }
}
