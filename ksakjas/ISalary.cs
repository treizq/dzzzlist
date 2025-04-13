using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ksakjas
{
    public interface ISalary
    {
        string FullName { get; set; } // ФИО сотрудника
        int WorkingDays { get; set; } // Количество рабочих дней
        decimal CalculateSalary(); // Метод для расчета зарплаты
    }
}
