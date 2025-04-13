using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ksakjas
{
    public struct Car : ITransport
    {
        public string LicensePlate { get; set; } // Гос. номер
        public string Brand { get; set; } // Марка
        public string Model { get; set; } // Модель
        public string Color { get; set; } // Цвет
        public string TransportType => "Автомобиль"; // Вид транспорта
        public decimal CostPerMinute => 2.0m; // Стоимость аренды за минуту
    }
}
