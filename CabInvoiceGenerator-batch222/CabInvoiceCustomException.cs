using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator_batch222
{
    public class CabInvoiceCustomException:Exception
    {
        public readonly ExceptionType exceptionType;
        public enum ExceptionType
        {
            INVALID_DISTANCE,
            INVALID_TIME
        }
        public CabInvoiceCustomException( ExceptionType exceptionType,string message) : base(message)
        {
            this.exceptionType = exceptionType;
        }
    }
}
