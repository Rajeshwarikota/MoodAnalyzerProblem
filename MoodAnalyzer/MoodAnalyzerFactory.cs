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
           Type type = typeof(MoodAnalyzerFactory);
            if (type.Name.Contains(className) || type.FullName.Contains(className))
            {
                if (type.Name.Equals(constructor))
                {
                    ConstructorInfo Info = type.GetConstructor(new[] { typeof(string) });
                    object obj = Info.Invoke(new object[] {});
                    return obj;
                   
                }
                else 
                {
                    throw new ModalAnalysisExceptin(ModalAnalysisExceptin.ExceptionType.NO_SUCH_CLASS, "class not found");

                }
            }
            else
            {
                throw new ModalAnalysisExceptin(ModalAnalysisExceptin.ExceptionType.NO_SUCH_CONSTRUCTOR, "Method not found");
            }

        }
        public static object CreateMoodAnalyserParameterizedObject(string className, string constructor, string message)
        {
            Type type = typeof(MoodAnalyzerFactory);
            if (type.Name.Contains(className) || type.FullName.Contains(className))
            {
                if (type.Name.Equals(constructor))
                {
                    ConstructorInfo Info = type.GetConstructor(new[] { typeof(string) });
                    object obj = Info.Invoke(new object[] { message });
                    return obj;

                }
                else
                {
                    throw new ModalAnalysisExceptin(ModalAnalysisExceptin.ExceptionType.NO_SUCH_CLASS, "class not found");

                }
            }
            else
            {
                throw new ModalAnalysisExceptin(ModalAnalysisExceptin.ExceptionType.NO_SUCH_CONSTRUCTOR, "Method not found");
            }

        }
        public static string InvokeAnalyseMood(string message,string methodName)
        {
            try 
            { 
                    Type type = Type.GetType("MoodAnalyzerFactory.Mood_Analyzing");
                    object MoodAnalyzingobj = MoodAnalyzerFactory.CreateMoodAnalyserParameterizedObject("MoodAnalyzing", "MoodAnalyzer.Mood_Analyzing",message);
                    MethodInfo Info = type.GetMethod(methodName);
                    object Mood = Info.Invoke(MoodAnalyzingobj, null);
                    return MoodAnalyzingobj.ToString();
                
                 
            }
            catch(NullReferenceException)
                {
                    throw new ModalAnalysisExceptin(ModalAnalysisExceptin.ExceptionType.NO_SUCH_METHOD, "Method not found");

                }
            }
        }
}

