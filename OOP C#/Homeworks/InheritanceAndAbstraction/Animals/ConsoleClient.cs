namespace Animals
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
            List<Animal> animals = new List<Animal>()
            {
                new Dog("Roko", 23, "male"),
                new Dog("Sharo", 17, "female"),
                new Frog("Froogyy", 5, "male"),
                new Frog("The Big Frog", 3, "female"),
                new Cat("Lili", 2, "male"),
                new Cat("Sisy", 6, "male"),
                new Kitten("Pisii", 8),
                new Kitten("Mimii", 3),
                new Tomcat("Tomyy", 4),
                new Tomcat("Jefryy", 11)
            };

            double avgAgeDog = animals
                            .Where(a => a is Dog)
                            .Average(a => a.Age);

            double avgAgeFrog = animals
                             .Where(a => a is Frog)
                             .Average(a => a.Age);

            double avgAgeCat = animals
                            .Where(a => a is Cat)
                            .Average(a => a.Age);

            double avgAgeKitten = animals
                            .Where(a => a is Kitten)
                            .Average(a => a.Age);

            double avgAgeTomCat = animals
                            .Where(a => a is Tomcat)
                            .Average(a => a.Age);


            Dictionary<string, double> result = new Dictionary<string, double>()
            {
                ["Dogs Average Age"] = avgAgeDog,
                ["Frogs Average Age"] = avgAgeFrog,
                ["Cats Average Age"] = avgAgeCat,
                ["Kittens Average Age"] = avgAgeKitten,
                ["TomCats Average Age"] = avgAgeTomCat,

            };

            foreach (var animal in result)
            {
                Console.WriteLine("{0}: {1:f2}",animal.Key, animal.Value);
            }
        }
    }
}
