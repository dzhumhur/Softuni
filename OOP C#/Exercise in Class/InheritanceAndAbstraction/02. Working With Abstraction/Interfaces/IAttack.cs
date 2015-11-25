namespace _02.Working_With_Abstraction.Interfaces
{
    using Characters;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IAttack
    {
        void Attack(Character target);
    }
}
