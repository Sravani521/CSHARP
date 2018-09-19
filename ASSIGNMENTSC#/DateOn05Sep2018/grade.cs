using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateOn05Sep2018
{

    class acuvate
    {

        public string Name;
        public int Grade;

    }

    class Grade

    {

        static void Main(string[] args)
        { 
            int[] count = new int[12];
            int[] tstudent = new int[2];
            acuvate[] a = new acuvate[1000];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = new acuvate();
                Console.WriteLine("plz enter the details");

                Console.WriteLine("plz enter the name");
                a[i].Name = Console.ReadLine();
                Console.WriteLine("plz enter the rollnumber");
                int rollnumber = int.Parse(Console.ReadLine());

            entergrade:
                Console.WriteLine("plz enter the grade");
                int grade = int.Parse(Console.ReadLine());

                if ((grade <= 12) && (grade != 0))
                {
                    if (count[grade - 1] > 22)
                    {
                        Console.WriteLine("Sorry, Seats Not Available!");
                        goto entergrade;
                    }

                    a[i].Grade = grade;
                    count[grade - 1]++;
                }
                else
                {
                    Console.WriteLine("plz enter the valid grade");
                    goto entergrade;
                }

                Console.WriteLine(" to continue plz enter yes or no");
                string decide = Console.ReadLine().ToLower();
                if (decide == "no")
                {
                    break;
                }

               
            }
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("no of students in grade:{0} is :{1}", i + 1, count[i]);
            }
            Console.Read();
        }

    }
}


