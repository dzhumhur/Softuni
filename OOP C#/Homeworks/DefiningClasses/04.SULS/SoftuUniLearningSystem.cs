namespace _04.SULS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SoftuUniLearningSystem
    {
        static void Main(string[] args)
        {
            var courses = new List<Course>
            {
                new Course("C#"),
                new Course("JavaScript"),
                new Course("ASP.NET MVC"),
                new Course("Database"),
            };

            var trainers = new List<Trainer>
            {
                new JuniorTrainer("Emil", "Ivanov", 19),
                new JuniorTrainer("Grigor", "Dimitrov", 20),
                new SeniorTrainer("Nikolay", "Kostov", 25),
                new SeniorTrainer("Georgi", "Georgiev", 27)
            };

            Console.WriteLine("All Courses: ");
            courses.ForEach(c => Console.WriteLine("-" + c.Name));

            Console.WriteLine();
            
            var seniorTrainer = new SeniorTrainer("Nasko", "Atanasov", 19);

            //Console.WriteLine("All Courses after adding new one");
            seniorTrainer.CreateCourse("Java", courses);
            //courses.ForEach(c => Console.WriteLine("-" + c.Name));

            Console.WriteLine();

            seniorTrainer.DeleteCourse("C#", courses);
            //Console.WriteLine("All Courses after deleting one");
            Console.WriteLine("All Courses: ");
            courses.ForEach(c => Console.WriteLine("-" + c.Name));
            Console.WriteLine();

            var students = new List<Student>
            {
                new OnlineStudent("Pesho", "Peshov", 24, "1332543", 4.44, "C#"),
                new OnsiteStudent("Gosho", "Goshov", 23, "1453565", 3.33, "Java", 8),
                new OnsiteStudent("Manol", "Georgiec", 26, "1875644", 5.99, "C#", 5),
                new OnsiteStudent("Pavel", "Pavlov", 21, "1987543", 4.99, "C#", 9),
                new DropoutStudent("Kiril", "Kirilov", 24, "13676564", 3.33, "He was very nervous"),
                new GraduateStudent("Preslav", "Nikolaev", 24, "13676564", 6.00),
            };

            var currentStudents = students
                                  .Where(st => st is CurrentStudent)
                                  .OrderBy(st => st.AverageGrade)
                                  .ToList();

            currentStudents.ForEach(Console.WriteLine);
        }
    }
}
