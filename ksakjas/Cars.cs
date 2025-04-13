using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ksakjas
{
    public struct Cars
    {
        public string VIN { get; set; } // VIN-номер двигателя
        public string Brand { get; set; } // Марка
        public string Model { get; set; } // Модель
        public int Year { get; set; } // Год выпуска
        public string Color { get; set; } // Цвет

        // Свойство для вывода информации о машине
        public string Info
        {
            get
            {
                return $"Марка: {Brand}, Модель: {Model}, Год выпуска: {Year}, Цвет: {Color}, VIN: {VIN}";
            }
        }

        // Метод для проверки VIN-номера
        public string CheckVIN(string actualVIN)
        {
            return actualVIN == VIN ? "VIN-номер совпадает." : "VIN-номер не совпадает.";
        }
    }
}
