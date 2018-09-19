using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateOn03Sep2018
{
    class StringFun
    {
        static void Main(string[] args)
        {
            string str = "sravani makthala";
            string str1 = "TraINEe";//tRAineE
            string str2 = "    hello    hii  ";
            string str3 = "hii";
            char[] a = str.ToCharArray();
            Console.WriteLine("length of the string is" + " " + str.Length);
            Console.WriteLine("Uppercase is" + " " + str.ToUpper());
            Console.WriteLine("Lowercase is" + " " + str1.ToLower());
            Console.WriteLine("trimming the spaces both sides is" + " " + str2.Trim());
            Console.WriteLine("trimming starting spaces is" + " " + str2.TrimStart());
            Console.Write("trimming the end spaces is" + " " + str2.TrimEnd());

            Console.WriteLine(str3);
            Console.WriteLine("contains the specified char or anything boolean value is " + " " + str.Contains('a'));
            Console.WriteLine(str.Contains("vani"));

            foreach (char c in a)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("substring is" + " " + str.Substring(0, 5));
            Console.WriteLine("starting with is" + " " + str.StartsWith("sra"));
            string result = Regex.Replace(str1, "[a-zA-Z]", c => Char.IsUpper(c.Value[0]) ?
                                     Char.ToLower(c.Value[0]).ToString() :
                                      Char.ToUpper(c.Value[0]).ToString());
            Console.WriteLine(result);
            String[] breaking = str.Split(' ');
            foreach (string s in breaking)
                Console.WriteLine("splitting is" + s);
            string str5 = new string(str.Reverse().ToArray());
            Console.WriteLine("reverse of string is" + " " + str5);
            Console.WriteLine("cloning is" + " " + str.Clone());
            Console.WriteLine("comparing is" + " " + str2.CompareTo(str3));
            Console.WriteLine("ending with is" + " " + str.EndsWith("la"));
            Console.WriteLine("getting hash code is" + " " + str.GetHashCode());
            Console.WriteLine("getting type is" + " " + str.GetType());
            Console.WriteLine("getting type of code is " + " " + str.GetTypeCode());
            Console.WriteLine("index of the char is" + " " + str.IndexOf('a'));
            Console.WriteLine("lastindex of the char is" + " " + str.LastIndexOf('a'));
            Console.WriteLine("replacing a char is" + " " + str.Replace(' ', '-'));
            Console.WriteLine("removing the char is" + " " + str.Remove(12, 1));
            Console.WriteLine("inserting cahr is" + " " + str.Insert(0, "c#"));
            str1 = string.Copy(str);
            Console.WriteLine("copying string is" + str1);
            Console.WriteLine("concat 2 strings is" + " " + string.Concat(str1, str2));

            Console.ReadLine();
        }
}
