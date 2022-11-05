using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_Vinay_Employee_Information
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public string? Address { get; set; }
        public double Salary { get; set; }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee Id :  "+EmployeeId);
            Console.WriteLine("Employee Name : "+EmployeeName);
            Console.WriteLine("Employee Address : "+Address);
            Console.WriteLine("Employee Salary : "+Salary);

            Salary objSalary = new Salary();
            objSalary.CalculateSalary(Salary);
        }
    }
}
