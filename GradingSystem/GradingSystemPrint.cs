using System;
using System.Collections.Generic;
using System.Text;
using ConsoleTables;

namespace GradingSystem
{
    class GradingSystemPrint
    {
        //This class handles the printing of all inputs.
         
        public static void Print()
        {
            Console.Clear();
            var table = new ConsoleTable($"Course & Code", $"Score", $"Course Unit", $"Grade", $"Grade Unit", $"Weight Point", $"Remark");

            foreach (var item in GradingSystemMethods.ListOfCourses)
            {
                table.AddRow($"{ item.CourseDescription}", $"{item.CourseScore}", $"{item.CourseUnit}", $"{item.CourseGrade}", $"{item.CourseGradeUnit}", $"{item.CourseWeightPoint}", $"{item.Remark}");
            }
            Console.WriteLine(table);
            GradingSystemMethods.ResultSummary();
        }
    }
}
