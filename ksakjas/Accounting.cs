using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ksakjas
{
    public class Accounting
    {
        // Метод для расчета подоходного налога (13%)
        public decimal CalculateIncomeTax(ISalary employee, int workingDays)
        {
            employee.WorkingDays = workingDays; // Устанавливаем количество рабочих дней
            decimal salary = employee.CalculateSalary(); // Получаем зарплату
            return salary * 0.13m; // Возвращаем налог
        }
    }
}
