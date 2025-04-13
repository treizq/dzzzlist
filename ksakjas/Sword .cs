using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ksakjas
{
    public struct Sword : IWeapon
    {
        public string Quality { get; set; } // Качество (обычное, хорошее, уникальное)

        public string WeaponType => "Меч"; // Вид оружия
        public int Power { get; set; } // Сила оружия
        public string SpecialAbilities => "Увеличивает силу атаки"; // Особые возможности
    }
}
