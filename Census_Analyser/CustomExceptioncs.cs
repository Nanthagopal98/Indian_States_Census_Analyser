using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Census_Analyser
{
    public class CustomExceptioncs : Exception
    {
        public enum ExceptionType
        {
            INCORRECT_FILE_TYPE,FILE_NOT_FOUND,INCORRECT_DELIMITER,INCORRECT_HEADER
        }
        public ExceptionType type;
        public CustomExceptioncs(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
