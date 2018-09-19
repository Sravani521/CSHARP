using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateON09Sep2018
{
    class Inheriting
    {
        class Sample
        {
            public int c;
            public void add(int a, int b)
            {
                c = a + b;
                Console.WriteLine(c);
            }
        }
        class Sample1 : Sample
        {

            public void sub(int d, int e)
            {
                c = e - d;
                Console.WriteLine(c);
            }

        }
        class Program
        {
            static void Main(string[] args)
            {
                Sample1 s = new Sample1();
                s.add(2, 3);
                s.sub(3, 4);
                Console.ReadLine();
            }
        }
    }
}
