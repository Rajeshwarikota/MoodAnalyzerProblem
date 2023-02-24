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
        public static object CreateMoodAnalyserObject(string className, string constructor)
      {
            //Assembly assembly = Assembly.GetExecutingAssembly();
            //Type moodAnalyserType = assembly.GetType(className);
            //return Activator.CreateInstance(moodAnalyserType);

            string pattern = "." + constructor + "$";
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
                throw new ModalAnalysisExceptin(ModalAnalysisExceptin.ExceptionType.NO_SUCH_CONSTRUCTOR, "Method not found");
            }

        }
    }
}

