using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateOn04Sep2018
{
    class IdentityMatrix
    {

        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("enter n value");
            int n = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Console.Write('1');
                    }
                    else
                        Console.Write('0');
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
