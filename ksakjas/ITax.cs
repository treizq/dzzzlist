using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ksakjas
{
    public interface ITax
    {
        string ProductName { get; set; } // Название товара
        decimal Price { get; set; } // Стоимость товара
        decimal AddTax(); // Метод для расчета цены с налогом

        static string ClassName => "Налог"; // Статическое поле для названия класса
    }
}
