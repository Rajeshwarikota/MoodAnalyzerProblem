﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
   
    public class Mood_Analyzing
    {
        public string message;
        public Mood_Analyzing(string message)
        {
            this.message = message; 
        }

        public string Analyzingmood()
        {
            if ( message.ToLower().Contains("happy"))
            {
                Console.WriteLine("happy");
                return "happy";
            }
            else 
            {
                Console.WriteLine("sad");
                return "sad";
            }
        }
    }
}