using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ksakjas
{
    public class DepartmentHead : ISalary
    {
        public string FullName { get; set; } // ФИО сотрудника
        public int WorkingDays { get; set; } // Количество рабочих дней

        // Метод для расчета зарплаты (количество дней * 2500)
        public decimal CalculateSalary()
        {
            return WorkingDays * 2500;
        }

        // Метод для вывода информации в консоль
        public void Print()
        {
            Console.WriteLine($"Должность: Глава отдела");
            Console.WriteLine($"ФИО сотрудника: {FullName}");
            Console.WriteLine($"Количество рабочих дней: {WorkingDays}");
            Console.WriteLine($"Зарплата: {CalculateSalary():C2}");
        }
    }
}
