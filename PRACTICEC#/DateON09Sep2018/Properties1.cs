using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateON09Sep2018
{
    class Properties1
    {
        public class PersonalInformation//base
        {
            private string name;
            private int age;

            public string _name
            {
                get { return name; }
                set { name = value; }
            }

            public int _age
            {
                get { return age; }
                set { age = value; }
            }


            public PersonalInformation()
            {

            }
            public PersonalInformation(string ename, int eage, DateTime dob)
            {

                name = ename;
                age = eage;
            }


            public virtual void display(string name, int age)
            {
                Console.WriteLine("displaying the personal details:{0}\t{1}", name, age);
            }


            public void print()
            {
                Console.WriteLine("details are:{0}\t :{1}", name, age);
            }
            public int ageconversion(DateTime dt)
            {
                return DateTime.Today.Year - dt.Year;
            }
        }
        class Student : PersonalInformation//derived
        {
            public int rollnumber;
            public string section;
            public Student()
            {

            }

            public Student(string stname, DateTime stdob)
            {
                _name = stname;
                _age = ageconversion(stdob);
            }

            public Student(int strollnumber, string stsection)
            {
                rollnumber = strollnumber;
                section = stsection;
            }

            public override void display(string name, int age)
            {
                _name = name;
                _age = age;
                Console.WriteLine("displaying the student details:{0}\t{1}", name, age);
            }
            public void display()
            {
                Console.WriteLine("displaying the student details:{0}\t{1}", _name, _age);
            }

        }
        class Teacher : PersonalInformation//derived
        {

            public Teacher(string subject, int salary) : base()
            {

            }
            public Teacher(string tcname, DateTime tcdob)
            {
                _name = tcname;
                _age = ageconversion(tcdob);
            }

        }
        class School
        {
            static void Main(string[] args)
            {
                Student s = new Student();
                Teacher t = new Teacher("abc", DateTime.Parse("07-09-1994"));
                s.print();
                t.print();
                PersonalInformation pi = new PersonalInformation();
                pi.display("vani", 20);
                PersonalInformation st = new Student();
                st._name = "a";
                st._age = 9;
                st.display("ahgsdf", 43);

                Console.ReadLine();
            }
        }
    }
}
