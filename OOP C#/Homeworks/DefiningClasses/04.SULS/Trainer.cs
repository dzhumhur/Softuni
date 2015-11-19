namespace _04.SULS
{
    using System;
    using System.Collections.Generic;

    public class Trainer : Person
    {
        public Trainer(string firstName, string lastName, int age) 
                       : base (firstName, lastName, age)
        {

        }
        public void CreateCourse(string courseName, List<Course> courses)
        {
            if (courseName != null && !string.IsNullOrWhiteSpace(courseName))
            {
                var course = new Course(courseName);
                courses.Add(course);
                Console.WriteLine("Added a new course: {0}", courseName);
            }
        }
    }
}
