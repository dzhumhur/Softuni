namespace _04.SULS
{
    public class Person
    {
        private string firstname;
        private string lastname;
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
        public string FirstName
        {
            get { return this.firstname; }
            set { this.firstname = value; }
        }

        public string LastName
        {
            get { return this.lastname; }
            set { this.lastname = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
    }
}
