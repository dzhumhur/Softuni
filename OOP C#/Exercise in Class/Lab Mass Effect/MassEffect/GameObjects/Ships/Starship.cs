namespace MassEffect.GameObjects.Ships
{
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using Enhancements;
    using Locations;

    public abstract class Starship : IStarship
    {
        protected Starship(string name, int health, int shields, int damage, double fuel, StarSystem location)
        {
            this.Name = name;
            this.Health = health;
            this.Shields = shields;
            this.Damage = damage;
            this.Fuel = fuel;
            this.Location = location;
        }

        public int Damage
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<Enhancement> Enhancements
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public double Fuel
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int Health
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public StarSystem Location
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int Shields
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void AddEnhancement(Enhancement enhancement)
        {
            throw new NotImplementedException();
        }

        public IProjectile ProduceAttack()
        {
            throw new NotImplementedException();
        }

        public void RespondToAttack(IProjectile attack)
        {
            throw new NotImplementedException();
        }
    }
}
