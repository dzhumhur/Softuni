namespace Battleships.Ships
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IAttack
    {
        string Attack(Ship target);
    }
}
