using System.Collections;
using System.IO;

namespace Grades
{
    internal interface IGradeTracker : IEnumerable
    {
         void AddGrade(float grade);
        GradeStatistics ComputerStatistics();
        void WriteGrades(TextWriter destination);
        string Name { get; set; }
    }
}