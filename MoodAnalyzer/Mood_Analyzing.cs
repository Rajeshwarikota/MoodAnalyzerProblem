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
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }

    }
 }
