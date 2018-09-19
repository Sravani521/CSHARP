using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateOn04Sep2018
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enterb year");
            int year = int.Parse(Console.ReadLine());

            if (year % 4 == 0&&year%100!=0)
                Console.WriteLine("it is a leap year");
            else if (year % 400 == 0)
                Console.WriteLine("it is a leap year");
            else
                Console.WriteLine("it is not an leap year");
            Console.Read();

        }
    }
}
