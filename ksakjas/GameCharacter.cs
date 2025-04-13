using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ksakjas
{
    public class GameCharacter<T> where T : IWeapon
    {
        public string Name { get; set; } // Имя персонажа
        public string Race { get; set; } // Раса персонажа
        public T Weapon { get; set; } // Оружие
        public int Strength { get; set; } // Сила персонажа

        // Метод для получения информации о персонаже
        public string GetCharacterInfo()
        {
            return $"Имя: {Name}\n" +
                   $"Раса: {Race}\n" +
                   $"Оружие: {Weapon.WeaponType}\n" +
                   $"Сила оружия: {Weapon.Power}\n" +
                   $"Особые возможности: {Weapon.SpecialAbilities}\n" +
                   $"Сила персонажа: {Strength}";
        }

        // Метод для расчета суммарной силы персонажа с оружием
        public int CalculateTotalStrength()
        {
            return Strength + Weapon.Power;
        }
    }
}
