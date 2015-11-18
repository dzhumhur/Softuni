namespace _01.Persons
{
    using System;

    class ConsoleClient
    {
        static void Main(string[] args)
        {
            var gosho = new Person("Gosho", 24);
            var dragan = new Person("Dragan", 25, "manol@fg.bgb");
            var pesho = new Person("Pesho", 27, null);
            var manol = new Person("Manol", 37, "manol@abv.bg");

            Console.WriteLine(gosho);
            Console.WriteLine(dragan);
            Console.WriteLine(pesho);
            Console.WriteLine(manol);
        }
    }
}
