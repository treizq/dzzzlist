using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ksakjas
{
    public class LuxuryGoods : ITax
    {
        public string ProductName { get; set; } // Название товара
        public decimal Price { get; set; } // Стоимость товара

        public static string ClassName => "Предметы роскоши"; // Статическое поле

        // Метод для расчета цены с налогом (20%)
        public decimal AddTax()
        {
            return Price + (Price * 0.20m);
        }

        // Метод для вывода информации в консоль
        public void Print()
        {
            Console.WriteLine($"Класс: {ClassName}");
            Console.WriteLine($"Название товара: {ProductName}");
            Console.WriteLine($"Стоимость товара (без налога): {Price:C2}");
            Console.WriteLine($"Стоимость товара (с налогом): {AddTax():C2}");
        }
    }
}
