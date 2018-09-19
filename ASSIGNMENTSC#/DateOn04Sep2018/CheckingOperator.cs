using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program using a switch statement that takes one character value
//    from the user and checks whether the entered value is an arithmetic operator,
//    logical operator, conditional operator, relational operator or something else.
namespace DateOn04Sep2018
{
    class CheckingOperator
    {
        static void Main(string[] args)
        {
            int flag;

            do
            {
                Console.WriteLine("enter the character");
                string str = Console.ReadLine();

                switch (str)
                {
                    case "+":
                    case "-":
                    case "*":
                    case "/":
                    case "%":
                        Console.WriteLine("arithmatic operator");
                        break;
                    case "&":
                    case "|":
                    case "!":
                    case "&&":
                    case "||":
                        Console.WriteLine("logical operator");
                        break;
                    case "<":
                    case ">":
                    case ">=":
                    case "<=":
                    case "!=":
                    case "==":
                        Console.WriteLine("conditional operator");
                        break;

                    default:
                        Console.WriteLine("it is another character");
                        break;
                }

                Console.WriteLine("if you want to continue press 1 else 0");

                flag = int.Parse(Console.ReadLine());

            } while (flag == 1);

            Console.ReadKey();
        }

    }

}

}
