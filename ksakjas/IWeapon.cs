using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ksakjas
{
    public interface IWeapon
    {
        string WeaponType { get; } // Вид оружия (меч/лук)
        int Power { get; } // Сила оружия
        string SpecialAbilities { get; } // Особые возможности оружия
    }
}
