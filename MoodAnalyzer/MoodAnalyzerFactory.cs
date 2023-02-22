using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyzerFactory
    {
        public object CreateMoodAnalyserObject(string className, string construcor)
        {
            string pattern = "." + construcor + "$";
            Match result = Regex.Match(pattern, className);
            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyserType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyserType);
                }
                catch (ArgumentNullException ex)
                {
                    throw new ModalAnalysisExceptin(ModalAnalysisExceptin.ExceptionType.NO_SUCH_CLASS, "class not found");

                }
            }
            else
            {
                throw new ModalAnalysisExceptin(ModalAnalysisExceptin.ExceptionType.NO_SUCH_METHOD, "Method not found");
            }
        }
    }
}

