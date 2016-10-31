using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {

           
            

            // SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.Speak("Hello, this is the grading program");
            
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);



            GradeStatistics stats = book.ComputerStatistics();

            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);
            
            
            Console.ReadKey();
            
        }
    }
}
