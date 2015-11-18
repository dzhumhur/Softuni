namespace _01.Persons
{
    using System;
    using System.Text.RegularExpressions;

    public class Person
    {
        private int age;
        private string name;
        private string email;

        public Person(string name, int age) : this(name, age, null)
        {

        }

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Age should be in range [1...100]");
                }

                this.age = value;
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Name cannot be empty / whitespaces");
                }

                this.name = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (value == null || Regex.IsMatch(value, ".*?@.*"))
                {
                    this.email = value;
                }
                else
                {
                    throw new Exception("Email is not valid");
                }
            }
        }

        public override string ToString()
        {
            string result = string.Format("---------------\nName: {0}\nAge: {1}\nEmail: {2}\n----------------\n",
                                            this.Name,
                                            this.Age,
                                            this.Email ?? "[unknown email]");
            return result;
        }
    }
}
