using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExceptionWorkflow
{
    public class myException : System.Exception
    {
        public myException(string ms)
            : base(ms)
        {
        }
    }

}
