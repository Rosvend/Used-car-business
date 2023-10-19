using System;
using Employee;

namespace BaseSalaryEmployee
{
    class BaseSalaryEmployee : Employee
    {
        public BaseSalaryEmployee(string name, decimal baseSalary) : base(name, EmployeeType.BaseSalary, baseSalary)
        {
        }
    }
}