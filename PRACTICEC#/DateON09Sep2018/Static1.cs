using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateON09Sep2018
{

    public static class Sta
    {
        static Sta()
        {
            //it is not useful;
        }
        //int a;
        //public int b;
        static int c;
        public static int d = 0;
        public void method1()
        {

        }
        static void method2()
        {

        }
    }
    public class Sta1
    {
        public void mnsdb()
        {


            Sta.d = 0;
        }
        static void Main(string[] args)
        {

            Sta.d = 0;


        }
    }
    static class asd
    {
        static void Main(string[] args)
        {
            Sta1 s = new Sta1();
            s.mnsdb();
        }
    }

}
