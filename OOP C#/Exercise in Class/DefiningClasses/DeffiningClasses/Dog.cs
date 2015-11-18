using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeffiningClasses
{
    public class Dog
    {
        public Dog() : this(null, null)
        {

        }

        public Dog(string name, string breed)
        {
            this.Breed = breed;
            this.Name = name;
        }

        public string Name { get; set; }

        public string Breed { get; set; }

        public void Bark()
        {
            Console.WriteLine("{0} ({1}) said : Bauuuu!",
                            this.Name ?? "[unnamed dog]",
                            this.Breed ?? "[unknown breed]");
        }
    }
}
