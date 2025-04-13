using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ksakjas
{
    public class EssentialGoods : ITax
    {
        public string ProductName { get; set; } // Название товара
        public decimal Price { get; set; } // Стоимость товара

        public static string ClassName => "Предметы первой необходимости"; // Статическое поле

        // Метод для расчета цены с налогом (0.5%)
        public decimal AddTax()
        {
            return Price + (Price * 0.005m);
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
