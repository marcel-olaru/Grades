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

          
            
            GradeBook book = new GradeBook();
            

            try
            {
                Console.WriteLine("Enter a name");
                book.Name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
            

            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
            book.WriteGrades(Console.Out);


            GradeStatistics stats = book.ComputerStatistics();

            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest" , stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
            WriteResult(stats.Description, stats.LetterGrade);

            //int[] ages = { 2, 21, 40, 72, 100 };
            //foreach (int value in ages)
            //{
            //    Console.WriteLine(value);
            //}

            //for (int i=0; i<7; i++)
            //{

            //    Console.WriteLine(ages[i]);
            //}
           
            
            Console.ReadKey();
            
        }
        static void WriteResult(string description, string result)
        {
            Console.WriteLine($"{description}:{result}");
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description}:{result:F2}");
        }
    }
}
