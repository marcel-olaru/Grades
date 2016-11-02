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
            
            
            //book.NameChanged += new NameChangedDelegate(OnNameChanged);
            // the C# compiler is smart enough to now that you want to create a new delegate so you can remove the new instances 
            //book.NameChanged += new NameChangedDelegate(OnNameChanged2);

            book.NameChanged += OnNameChanged;



            //book.NameChanged += OnNameChanged2;
            //book.NameChanged += OnNameChanged2;
            //book.NameChanged -= OnNameChanged2;
            //what happens when you add on name changed twice and substract once ? will it remove bowth subscriptions?
            //book.NameChanged = null;




            book.Name = "Pompi's Grade book";
            book.Name = "Grade book";
            book.Name = null;


            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);



            GradeStatistics stats = book.ComputerStatistics();

            Console.WriteLine(book.Name);
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest" , (int)stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
            
            
            Console.ReadKey();
            
        }

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Grade book changing name from {args.ExistingName} to {args.NewName}");
        }

        /*static void OnNameChanged2(string existingName, string newName)
        {
            Console.WriteLine("###");
        }
        */
        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description}:  {result:F2}");
        }
    }
}
