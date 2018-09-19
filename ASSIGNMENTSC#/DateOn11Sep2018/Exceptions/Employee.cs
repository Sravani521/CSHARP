using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Sep.Exceptions
{
     public abstract class Employee
    {
        public int Id;
        public string Name;
        public int Salary;
        public abstract void SalaryDet();
        //public int bonus;

        public void GeneralDet()
        {
            Console.WriteLine("enter the details of the employee");
            Console.WriteLine("enter id");
            Id = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            Name = Console.ReadLine();
            Console.WriteLine("enter salary");
            Salary = int.Parse(Console.ReadLine());
            Console.WriteLine("dispaly details" + " " + Id + " " + Name + " " + Salary);
        }


        public virtual void PersonalDet()
        {
            Console.WriteLine("this is base class method");

        }


    }
}
