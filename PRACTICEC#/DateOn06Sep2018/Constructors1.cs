using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateOn06Sep2018
{
        class Example
        {
            int eid;
            string ename;
            string adrs;
            int mblnumber;
            public Example()
            {

            }

            public Example(int id, string name)
            {
                eid = id;
                ename = name;
            }
            public Example(string address, int number)
            {
                adrs = address;
                mblnumber = number;

            }
            public void display()
            {
                Console.WriteLine(adrs);
                Console.WriteLine(mblnumber);
            }
            public void print()
            {
                Console.WriteLine(eid);
                Console.WriteLine(ename);
            }
        }
        class Constructors1
        {
            static void Main(string[] args)
            {
                Example e = new Example(1, "sravani");
                e.print();
                Example d = new Example("sghad", 425);
                e.display();
                Console.ReadLine();

            }
        }
    }
}
