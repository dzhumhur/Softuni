using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CustomLINQExtensionMethods
{
    class Student
    {
        public int Grade { get; set; }

        public int Age { get; set; }
    }
    class ConsoleClient
    {
        static void Main(string[] args)
        {
            List<int> collection = new List<int> { 1, 2, 3, 6, 4, 11, 3 };
            List<string> collectionString = new List<string> {"pesho", "gosho"};
            List<Student> students = new List<Student>
            {
                new Student { Grade = 6, Age = 16},
                new Student { Grade = 5, Age = 18},
                new Student { Grade = 12, Age = 20},
            };


            Console.WriteLine(string.Join(", ", collection.WhereNot(x => x % 2 == 0)));
            Console.WriteLine(string.Join(", ", collectionString.WhereNot(x => x.Length > 6)));
            Console.WriteLine(students.CustomMax(student => student.Age));
            
        }
    }
}
