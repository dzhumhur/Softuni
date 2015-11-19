namespace _04.SULS
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        private string name;

        public Course(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == null || string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Course name cannot be null, empty or whitespaces");
                }
                this.name = value;
            }
        }
    }
}
