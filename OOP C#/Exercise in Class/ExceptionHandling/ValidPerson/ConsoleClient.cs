namespace ValidPerson
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
            CheckIfPersonIsValid("Pesho", "Peshov", 24);
            CheckIfPersonIsValid(string.Empty, "Goshev", 31);
            CheckIfPersonIsValid("Manol", null, 63);
            CheckIfPersonIsValid("Stoyan", "Kolev", -1);

        }

        public static void CheckIfPersonIsValid(string firstName, string lastName, int age)
        {
            try
            {
                var currPerson = new Person(firstName, lastName, age);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
                Console.WriteLine();
            }
        }
    }
}

