// See https://aka.ms/new-console-template for more information
using Test1_Vinay_Employee_Information;

Console.WriteLine("Hello, World!");

Employee objEmployee = new Employee();

Console.WriteLine("Enter Employee Id");
objEmployee.EmployeeId=int.Parse(Console.ReadLine());

Console.WriteLine("Enter Employee Name");
objEmployee.EmployeeName=Console.ReadLine();

Console.WriteLine("Enter Employee Address");
objEmployee.Address=Console.ReadLine();

Console.WriteLine("Enter Employee Salary");
objEmployee.Salary=double.Parse(Console.ReadLine());

objEmployee.DisplayEmployeeDetails();
