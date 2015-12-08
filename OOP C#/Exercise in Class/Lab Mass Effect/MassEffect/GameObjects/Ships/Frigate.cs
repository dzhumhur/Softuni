namespace MassEffect.GameObjects.Ships
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Locations;

    public class Frigate : Starship
    {
        private int projectilesFired;

        public Frigate(string name, StarSystem location) 
            : base(name, 60, 50, 30, 220, location)
        {
            this.ProjectilesFired = projectilesFired;
        }

        public int ProjectilesFired
        {
            get { return this.projectilesFired; }
            set { this.projectilesFired = value; }
        }
    }
}
