using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateOn05Sep2018.School
{
    class student
    {
        public string name;
        public int rollnumber;
        public int[] marks = new int[6];
        public float percentage;


    }
    class subject
    {
        public string subname;
        public student student1;
        public int highestmarks;

    }
    class studentlist
    {
        static student[] stu = new student[10];
        static subject[] sub = new subject[6];

        static void Main(string[] args)
        {

            float total;
            Console.WriteLine("enter the details");
            
            for (int i = 0; i < 6; i++)
            {
                sub[i] = new subject();
                Console.WriteLine("Enter the {0} subject name  ", i+1);
                sub[i].subname = Console.ReadLine();
            }
            int j;
            for (j = 0; j < stu.Length; j++)
            {
                stu[j] = new student();
                Console.WriteLine("enter student name");
                stu[j].name = Console.ReadLine();
                Console.WriteLine("enter the rollnumber");
                stu[j].rollnumber = int.Parse(Console.ReadLine());

                total = 0;
                for (int k = 0; k < 6; k++)
                {
                    Console.WriteLine("enter the marks in subject :{0}",k+1);
                    stu[j].marks[k] = Convert.ToInt32(Console.ReadLine());

                    total = total + stu[j].marks[k];

                }
                Console.WriteLine("total marks are{0}", total);
                stu[j].percentage = (total / (sub.Length * 100)) * 100;
                Console.WriteLine("total percentage is {0}", stu[j].percentage);
               // Console.WriteLine("student percentage details"+" "+ stu[j].name+"\t\t"+ total+"\t\t"+ stu[j].percentage);

                if (j == 0)
                {
                    //Console.WriteLine("swapping");
                    for (int hmark = 0; hmark < 6; hmark++)
                    {

                        sub[hmark].student1 = stu[j];
                        sub[hmark].highestmarks = stu[j].marks[hmark];
                    }
                }
                else
                {
                    gethighmark(stu[j]);
                }
                if (j != 0)
                {
                    swap(j);
                }

                Console.WriteLine("if you want to exit plz enter yes else press any key");
                string decision = Console.ReadLine();
                if (decision == "yes")
                {
                    break;
                }

            }
            Console.WriteLine("result details are");
            Console.WriteLine("StudentName" + "\t\t" + "TotalMarks" + "\t\t" + "Percentage");
            for (int a = 0; a < 3; a++)
            {
                Console.WriteLine(stu[a].name + "\t\t\t" + total + "\t\t\t" + stu[a].percentage);
            }
            Console.WriteLine("subject \t studentname \t highestmarks ");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(sub[i].subname + "\t\t" + sub[i].student1.name + "\t\t" + sub[i].highestmarks);

            }


            Console.ReadLine();
        }
        public static void swap(int noofstudents)
        {
            student temp = new student();

            for (int i = noofstudents; i > 0; i--)
            {
                if (stu[i].percentage > stu[i - 1].percentage)
                {
                    temp = stu[i];
                    stu[i] = stu[i - 1];
                    stu[i - 1] = temp;

                }
                else
                    break;

            }
        }

        public static void gethighmark(student student2)
        {
            for (int i = 0; i < sub.Length; i++)
            {
                if (sub[i].highestmarks < student2.marks[i])
                {
                    sub[i].student1 = student2;
                    sub[i].highestmarks = student2.marks[i];
                }
            }

        }

        

    }
}
