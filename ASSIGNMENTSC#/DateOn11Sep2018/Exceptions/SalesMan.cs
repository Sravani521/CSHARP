using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Sep.Exceptions
{
    class SalesMan : Employee
    {

        public int Commision;
        public string workingcity;
        public int Bonus;



        public override void SalaryDet()
        {
            Console.WriteLine("enter the commision of the salesman");
            Commision = Int32.Parse(Console.ReadLine());

            int TotalSalary = Salary + Commision;
            Console.WriteLine("total salary of salesman is" + TotalSalary);
        }
        public void BonusMethod(int Bonus)
        {
            try
            {
                if (Salary == 0)
                {
                    throw new MyCustomException("Salary not valid");
                }

                if (Salary*10 / 100 > Bonus)
                {
                    throw new MyCustomException("bonus is less than the 10 percent of salary");
                }
            }
            catch(MyCustomException mce)
            {
                Console.WriteLine(mce.Message);
            }
        }

        public override void PersonalDet()
        {
            Console.WriteLine("this is child class method");
            Console.WriteLine("city is " + workingcity);
        }
    }
}
