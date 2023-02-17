using System;

namespace MoodAnalyaser_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MoodAnalyaser analyse = new MoodAnalyaser("I am in any mood");
            Console.WriteLine( analyse.AnalyseMood());
        }
    }
}
