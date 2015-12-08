using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MassEffect.GameObjects.Locations;

namespace MassEffect.GameObjects.Ships
{
    public class Cruiser : Starship
    {
        public Cruiser(string name, StarSystem location)
            : base(name, health, shields, damage, fuel, location)
        {
        }
    }
}
