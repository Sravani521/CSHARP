using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Sep.Exceptions
{
  class Staff : Employee
    {
        public int Bonus;

        public void BonusMethod(int Bonus)
        {
            try
            {
                if (Salary == 0)
                {
                    throw new MyCustomException("Salary not valid");
                }

                if (Salary * 10 / 100 > Bonus)
                {
                    throw new MyCustomException("bonus is less than the 10 percent of salary");
                }
            }
            catch (MyCustomException mce)
            {
                Console.WriteLine(mce.Message);
            }
        }
        public override void SalaryDet()
        {
            Console.WriteLine("enter the bonus of the staff");
            Bonus = Int32.Parse(Console.ReadLine());
            int TotalSalary = Salary + Bonus;
            Console.WriteLine("total salary of the staff is" + TotalSalary);
        }

       // public abstract float GetDetails();

    }
}
