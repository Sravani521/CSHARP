using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateOn05Sep2018.School
{
    class MarkList
    {


        class student
        {
            public string stname;
            public string[] sub = new string[6];
            public int[] marks = new int[6];
        }

        class marklist
        {
            public int[] highmark = new int[6];
            public int[] sorta = new int[6];
        }

        class subject
        {
            public string[] sub = new string[6];
            static void Main(string[] args)
            {

                student[] stu = new student[100];
                marklist[] m1 = new marklist[100];
                int i = 0;
                int j = 0;
                int c = 0;
                int d = 0;
                m1[i] = new marklist();

                Console.WriteLine("hello user plz enter the details");
                while (true)
                {

                    for (int k = 1; k <= 6; k++)
                    {
                        stu[i] = new student();
                        Console.WriteLine("Enter the subject no {0}", k);
                        stu[i].sub[k - 1] = Console.ReadLine();
                    }
                    Console.WriteLine("plz enter the name");
                    stu[i].stname = Console.ReadLine();

                    for (int k = 0; k < 6; k++)
                    {
                        Console.WriteLine("enter the {0} subject marks", k);
                        stu[i].marks[k] = int.Parse(Console.ReadLine());

                        if (i > 0)
                        {
                            if (stu[i].marks[k] < stu[i].marks[k])
                            {
                                m1[c].sorta[d] = stu[i].marks[k];
                                Console.WriteLine(m1[c].sorta[d]);
                                d++;
                            }
                            else
                            {
                                m1[c].sorta[d] = stu[i].marks[k];
                                d++;
                            }
                        }
                        else
                        {
                            m1[c].sorta[d] = stu[i].marks[k];
                            d++;


                        }


                    }
                    Console.WriteLine("if you dont want to continue plz enter 0");
                    int n = int.Parse(Console.ReadLine());
                    if (n == 0)
                    {
                        break;
                    }
                    Console.ReadLine();
                }

            }
        }
    }
}
