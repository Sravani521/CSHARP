using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Sep.Exceptions
{
   public  class MyCustomException:Exception
    {
        public override string Message=>base.Message;
        public MyCustomException(string message, System.Exception inner) : base(message, inner) { }
        public MyCustomException(string Mess):base(Mess)
        {
           
        }

    }
}
