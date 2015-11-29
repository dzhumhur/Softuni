namespace HumanStudentWorker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student : Human
    {
        public Student(string firstName, string lastName, string facultyNumber)
                      : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }
        public string FacultyNumber { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1}",
                            base.ToString(),
                            this.FacultyNumber);
        }
    }
}
