using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MassEffect.GameObjects.Locations;

namespace MassEffect.GameObjects.Ships
{
    public class Dreadnought : Starship
    {
        public Dreadnought(string name, StarSystem location) 
            : base(name, health, shields, damage, fuel, location)
        {
        }
    }
}
