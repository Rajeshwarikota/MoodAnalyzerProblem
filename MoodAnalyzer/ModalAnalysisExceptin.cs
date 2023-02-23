using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class ModalAnalysisExceptin : Exception
    {

        //enum for exceptions type
        public enum ExceptionType
        {
            NUll_MESSAGE,EMPTY_MESSAGE,
            NO_SUCH_CLASS,NO_SUCH_METHOD, NO_SUCH_CONSTRUCTOR
        }
        // variable type 
        public ExceptionType Type;
        public ModalAnalysisExceptin(ExceptionType type,string Message)
        {
            Type = type;
        }
    }
}
