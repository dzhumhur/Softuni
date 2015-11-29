namespace CompanyHierarchy
{
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Person : IPerson
    {
        private int id;
        private string firstName;
        private string lastName;

        public Person(int id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int Id
        {
            get { return this.id; }
            set
            {
                if (value < 1)
                {
                    throw new Exception("Id should be greater than 0");
                }

                this.id = value;
            }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Firstname cannot be empty, null or whitespaces");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Lastname cannot be empty, null or whitespaces");
                }

                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Id: {0}\nFirstname: {1}\nLastname: {2}",
                                this.Id,
                                this.FirstName,
                                this.lastName);
        }
    }
}
