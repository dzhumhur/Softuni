using DeffiningClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient
{
    class ConsoleClient
    {
        static void Main(string[] args)
        {
            Dog djoni = new Dog();
            Dog sharo = new Dog("Sharo", "pitbull");
            Dog chocho = new Dog("Chocho", "ulichna");

            djoni.Bark();
            sharo.Bark();
            chocho.Bark();
        }
    }
}
