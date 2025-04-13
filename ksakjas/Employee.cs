using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ksakjas
{
    public struct Employee
    {
        public string LastName { get; set; } // Фамилия
        public string FirstName { get; set; } // Имя
        public string MiddleName { get; set; } // Отчество
        public string Position { get; set; } // Должность
        public int YearOfHiring { get; set; } // Год принятия на работу

        // Свойство для вывода информации о сотруднике
        public string Info
        {
            get
            {
                return $"{LastName} {FirstName} {MiddleName}, Должность: {Position}, Год принятия: {YearOfHiring}";
            }
        }

        // Метод для получения стажа сотрудника
        public int GetExperience(int currentYear)
        {
            return currentYear - YearOfHiring;
        }
    }
}
