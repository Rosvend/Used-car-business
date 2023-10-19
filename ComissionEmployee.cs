using System;
using Employee;


namespace ComissionEmployee
{
    class CommissionEmployee : Employee
    {
        public CommissionEmployee(string name, decimal commission) : base(name, EmployeeType.Commission, commission)
        {
        }
    }
}