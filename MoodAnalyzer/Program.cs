﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("....Mood analyzer....");
            Mood_Analyzing mood_Analyzing = new Mood_Analyzing("I am in happy mood ");
            mood_Analyzing.Analyzingmood();
            Console.ReadLine();
        }
    }
}
