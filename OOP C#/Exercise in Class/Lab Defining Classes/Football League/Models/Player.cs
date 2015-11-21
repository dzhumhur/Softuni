namespace Football_League.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Player
    {
        private const int MinumunAllowedYear = 1980;
        private string firstName;
        private string lastName;
        private decimal salary;
        private DateTime dateOfBirth;
        private Team team;

        public Player(string firstName, string lastName, DateTime dateOfBirth, decimal salary, Team team)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.DateOfBirth = dateOfBirth;
            this.Team = team;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new Exception("Firstname cannot be null or whitespaces, and should be at least 3 symbols");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new Exception("Firstname cannot be null or whitespaces, and should be at least 3 symbols");
                }

                this.lastName = value;
            }
        }

        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be negative");
                }

                this.salary = value;
            }
        }

        public DateTime DateOfBirth
        {
            get { return this.dateOfBirth; }
            set
            {
                if (value.Year < MinumunAllowedYear)
                {
                    throw new ArgumentOutOfRangeException("Date of birth cannot be earlier than " + MinumunAllowedYear);
                }

                this.dateOfBirth = value;
            }
        }

        public Team Team
        {
            get { return this.team; }
            set { this.team = value; }
        }

        public override string ToString()
        {
            var result = string.Format("{0} {1} - {2}",
                                       this.FirstName,
                                       this.LastName,
                                       this.Salary);
            return result;
        }
    }
}
