using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ksakjas
{
    public struct Scooter : ITransport
    {
        public string Model { get; set; } // Модель самоката
        public int Year { get; set; } // Год выпуска самоката
        public string TransportType => "Самокат"; // Вид транспорта
        public decimal CostPerMinute => 0.5m; // Стоимость аренды за минуту
    }
}
