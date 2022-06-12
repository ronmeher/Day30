using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGenerator
{
    public class CabInvoiceException : Exception
    {
        public enum ExceptionType // taken Enum
        {
            INVALID_RIDE_TYPE,
            INVALI_DISTANCE,
            INVALID_TIME,
            INVALID_RIDES,
            INVALID_USER_ID,
            NULL_RIDES
        }
        ExceptionType type; // variable
        public CabInvoiceException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
