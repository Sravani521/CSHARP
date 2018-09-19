using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Sep.Exceptions
{
    class Manager : Employee
    {

        public int Stock;

        public override void SalaryDet()
        {
            Console.WriteLine("enter stock of the manager");
            Stock = Int32.Parse(Console.ReadLine());
            int TotalSalary = Salary + (Stock * 10);
            Console.WriteLine("total salary of manager is" + TotalSalary);
        }

    }
}
