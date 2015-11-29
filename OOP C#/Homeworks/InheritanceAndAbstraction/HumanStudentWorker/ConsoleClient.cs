namespace HumanStudentWorker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class ConsoleClient
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Manol", "Manolev", "12346"));
            students.Add(new Student("Ivan", "Draganov", "42346"));
            students.Add(new Student("Dragan", "Ivanov", "62346"));
            students.Add(new Student("Petkan", "Kaloyanov", "112346"));
            students.Add(new Student("Kaloyan", "Petkanov", "92346"));
            students.Add(new Student("Ivelin", "Kirlov", "82346"));
            students.Add(new Student("Kiril", "Ivelinov", "72346"));
            students.Add(new Student("Svetlin", "Nakov", "62346"));
            students.Add(new Student("Preslav", "Preslavov", "52346"));
            students.Add(new Student("Nikolay", "Nikolov", "42346"));

            students = students.OrderBy(s => s.FacultyNumber).ToList();
            //students.ForEach(Console.WriteLine);
            //Console.WriteLine();

            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Kiril", "Domuschiev", 3000, 15));
            workers.Add(new Worker("Dimitar", "Berbatov", 4000, 7));
            workers.Add(new Worker("Samuil", "Georgiev", 3100, 7));
            workers.Add(new Worker("Petkan", "Proshanov", 3101, 8));
            workers.Add(new Worker("Ivelin", "Damqnov", 4500, 10));
            workers.Add(new Worker("Kaloyan", "Kirlov", 5000, 14));
            workers.Add(new Worker("Matey", "Ivelinov", 1450, 20));
            workers.Add(new Worker("Vladimir", "Nakov", 8000, 17));
            workers.Add(new Worker("Proshen", "Preslavov", 6000, 17));
            workers.Add(new Worker("Nikola", "Nikolov", 10000, 6));

            workers = workers.OrderByDescending(w => w.MoneyPerOur()).ToList();
            //workers.ForEach(Console.WriteLine);

            List<Human> humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);
            humans = humans
                    .OrderBy(h => h.FirstName)
                    .ThenBy(h => h.LastName)
                    .ToList();

            humans.ForEach(Console.WriteLine);
        }
    }
}
