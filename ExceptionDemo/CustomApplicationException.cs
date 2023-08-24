using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{

    public class CustomApplicationException : ApplicationException
    {
        public CustomApplicationException()
        {

        }

        public CustomApplicationException(string message):base(message)
        {

        }
        public CustomApplicationException(string message, Exception innerException) : base(message, innerException) { }

    }
}
