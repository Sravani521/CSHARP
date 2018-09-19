using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateON09Sep2018
{
    class Overriding1
    {
            public int id, number;
            public string name, address;

            public virtual int samplemeth()
            {
                Console.WriteLine("enter the details");
                id = int.Parse(Console.ReadLine());
                number = int.Parse(Console.ReadLine());
                name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());
                address = Console.ReadLine();
                Console.WriteLine("first details are:{0}\t{1}:\t{2}:\t{3}", id, number, name, address);
                return id;
            }
            public int ageconversion(DateTime dt)
            {
                return DateTime.Today.Year - dt.Year;
            }
        }
        class OverrideSample : Overriding1
    {
            public override int samplemeth()
            {
                Console.WriteLine("enter the details");
                id = int.Parse(Console.ReadLine());
                number = int.Parse(Console.ReadLine());
                name = Console.ReadLine();

                address = Console.ReadLine();
                Console.WriteLine("second details are:{0}\t{1}:\t{2}:\t{3}", id, number, name, address);
                return id;
            }

        }
        class OverrideSample2 : OverrideSample
        {
            public override int samplemeth()
            {
                Console.WriteLine("enter the details");
                id = int.Parse(Console.ReadLine());

                name = Console.ReadLine();
                Console.WriteLine("third details are:{0}\t{1}", id, name);
                return id;
            }
        }
        class Final
        {
            static void Main(string[] args)
            {
                 Overriding1 vs = new Overriding1();
                OverrideSample os = new OverrideSample();
                vs.samplemeth();
                Overriding1 vs1 = new OverrideSample2();
                vs1.samplemeth();
                Console.ReadLine();
            }
        }
    }
}
