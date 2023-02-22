using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{

    public class Mood_Analyzing
    {
        string message;
        public Mood_Analyzing(string message)
        {
            this.message = message;
        }
        public Mood_Analyzing()
        {

        }

        public string Analyzingmood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new ModalAnalysisExceptin(ModalAnalysisExceptin.ExceptionType. EMPTY_MESSAGE, "Mood should not be empty");
                }
                if (message.ToLower().Contains("sad"))
                {
                    Console.WriteLine("sad");
                    return "sad";
                }
                else
                {
                    Console.WriteLine("happy");
                    return "happy";
                }

            }
            catch (NullReferenceException)
            {
                throw new ModalAnalysisExceptin(ModalAnalysisExceptin.ExceptionType.NUll_MESSAGE, "Mood should not be empty");
                //Console.WriteLine(ex.Message);
                //return ex.Message;
            }
        }

    }
 }
