using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateOn03Sep2018
{
    class Operators
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            int c;
            //arithmatic operators
            c = a + b;
            Console.WriteLine("sum is : {0}\n", c);
            c = a - b;
            Console.WriteLine("sub is :{0}", c);
            c = a * b;
            Console.WriteLine("mul is :{0}", c);
            c = a / b;
            Console.WriteLine("quotient is :{0}", c);
            c = a % b;
            Console.WriteLine("remainder is :{0}", c);
            //relational operators
            if (a > b)
                Console.WriteLine("a is greater");
            if (a < b)
                Console.WriteLine("a is lesser");
            if (a >= b)
                Console.WriteLine("a is greater than or equal to b");
            if (a <= b)
                Console.WriteLine("a is less than or equal to b");
            //comparison operators
            if (a == b)
                Console.WriteLine("a is  equal to b");
            if (a != b)
                Console.WriteLine("a is  not equal to b");
            //logical operators
            if ((a != b) & (b != a))

                Console.WriteLine("a & b are different");
            if ((a != b) | (b != a))
                Console.WriteLine("a & b are different");
            if ((a != b) && (b != a))

                Console.WriteLine("a & b are different");
            if ((a == b) || (b == a))
                Console.WriteLine("a & b are different");
            //ternary operator
            int d = ((a > b) ? a : b);
            Console.WriteLine(d);
            //post inc and dec operators
            a++;
            Console.WriteLine("after incrementing a is:{0}", a);
            a = a + 10;
            Console.WriteLine("after incrementing a is:{0}", a);
            a--;
            Console.WriteLine("after decrementing a is:{0}", a);
            a = a - 5;
            Console.WriteLine("after decrementing a is:{0}", a);
            //pre inc and dec operators
            ++a;
            Console.WriteLine(" incrementing a is:{0}", a);
            a += 10;
            Console.WriteLine(" incrementing a is:{0}", a);
            --a;
            Console.WriteLine(" decrementing a is:{0}", a);
            a -= 10;
            Console.WriteLine(" decrementing a is:{0}", a);
            int value = a++ + --a + a-- - a++;
            Console.WriteLine("expression value is:{0}", value);

            Console.ReadLine();
        }
}
