using System;

namespace Employee
{
    class Employee
    {
        public string Name { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public decimal Commission { get; set; }
        public decimal BaseSalary { get; set; }

        public Employee(string name, EmployeeType employeeType, decimal commission = 0, decimal baseSalary = 0)
        {
            Name = name;
            EmployeeType = employeeType;
            Commission = commission;
            BaseSalary = baseSalary;
        }
    }


    enum EmployeeType
    {
        Commission,
        BaseSalary
    }
}