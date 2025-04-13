using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ksakjas
{
    public struct Bow : IWeapon
    {
        public int Range { get; set; } // Дальность (от 1 до 100)
        public int Accuracy { get; set; } // Точность (от 1 до 100)

        public string WeaponType => "Лук"; // Вид оружия
        public int Power => (Range + Accuracy) / 2; // Сила оружия (среднее значение)
        public string SpecialAbilities => "Увеличивает точность атаки"; // Особые возможности
    }
}
