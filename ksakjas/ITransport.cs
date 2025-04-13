using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ksakjas
{
    public interface ITransport
    {
        string TransportType { get; } // Вид транспорта
        decimal CostPerMinute { get; } // Стоимость аренды за минуту
    }
}
