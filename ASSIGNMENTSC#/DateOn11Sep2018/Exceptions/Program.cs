using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Sep.Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesMan sm = new SalesMan();
            Manager mg = new Manager();
           
            Staff st = new Staff();
            sm.GeneralDet();
            st.GeneralDet();

            //StaffDetails std = new StaffDetails();
            //mg.GeneralDet();
            //mg.SalaryDet();
            //sm.SalaryDet();

            //sm.PersonalDet();

            try
            {
                sm.BonusMethod(500);
            }
            catch(MyCustomException mce)
            {
                Console.WriteLine(mce.Message);
            }

            try
            {
                st.BonusMethod(1000);
            }
            catch(MyCustomException mce)
            {
                Console.WriteLine(mce.Message);
            }
            Console.ReadLine();

        }
    }
}
