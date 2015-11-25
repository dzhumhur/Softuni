namespace _02.Working_With_Abstraction.Characters
{
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Priest : Character, IHeal
    {
        public Priest() 
               : base (125, 200, 100)
        {

        }

        public override void Attack(Character target)
        {
            target.Health -= this.Damage;
            this.Health += this.Damage / 10;
        }

        public void Heal(Character target)
        {
            this.Mana -= 100;
            target.Health += 150;
        }
    }
}
