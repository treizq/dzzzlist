using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ksakjas
{
    public class TransportRental<T> where T : ITransport
    {
        public string ClientName { get; set; } // ФИО клиента
        public T Transport { get; set; } // Транспорт
        public int RentalTime { get; set; } // Время аренды в минутах

        // Метод для получения информации об аренде
        public string GetRentalInfo()
        {
            return $"ФИО клиента: {ClientName}\n" +
                   $"Вид транспорта: {Transport.TransportType}\n" +
                   $"Стоимость аренды за минуту: {Transport.CostPerMinute:C2}р\n" + // Форматирование валюты
                   $"Время аренды: {RentalTime} минут";
        }

        // Метод для расчета полной стоимости аренды
        public decimal CalculateTotalCost()
        {
            return Transport.CostPerMinute * RentalTime;
        }
    }

}
