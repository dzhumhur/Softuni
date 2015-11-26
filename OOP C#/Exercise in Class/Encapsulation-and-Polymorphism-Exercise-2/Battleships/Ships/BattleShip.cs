namespace Battleships.Ships
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class BattleShip : Ship, IAttack
    {
        protected BattleShip(string name, double lengthInMeters, double volume) 
                        : base(name, lengthInMeters, volume)
        {

        }

        public abstract string Attack(Ship targetShip);

        public void DestroyShip(Ship target)
        {
            target.IsDestroyed = true;
        }
    }
}
