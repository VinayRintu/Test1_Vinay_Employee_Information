using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_Vinay_Employee_Information
{
    public class Salary
    {
        double hra, ta, da, tax, bonus, netSalary,salary;
        public void CalculateSalary(double _salary)
        {
            salary = _salary;

            if (salary < 10000)
            {
                hra = salary * 0.1;
                ta = salary * 0.4;
                da = salary * 0.5;
                tax = salary * 0.1;
                bonus = salary * 0.10;
                netSalary = salary + hra + ta + da + bonus - tax;
                Console.WriteLine("HRA :"+hra);
                Console.WriteLine("TA :" + ta);
                Console.WriteLine("DA :" + da);
                Console.WriteLine("TAX :" + tax);
                Console.WriteLine("BONUS :" + bonus);
                Console.WriteLine("NET SALARY :" + netSalary);
            }
            else
            {
                hra = salary * 0.4;
                ta = salary * 0.7;
                da = salary * 0.9;
                tax = salary * 0.5;
                bonus = salary * 0.4;
                netSalary = salary + hra + ta + da + bonus - tax;
                Console.WriteLine("HRA :" + hra);
                Console.WriteLine("TA :" + ta);
                Console.WriteLine("DA :" + da);
                Console.WriteLine("TAX :" + tax);
                Console.WriteLine("BONUS :" + bonus);
                Console.WriteLine("NET SALARY :" + netSalary);
            }
        }

    }
}
