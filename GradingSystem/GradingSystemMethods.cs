using System;
using System.Collections.Generic;
using ConsoleTables;
using System.Text.RegularExpressions;
using System.Linq;

namespace GradingSystem
{
    class GradingSystemMethods
    {
        //This class handles the addition and removal of courses plus result summary i.e  
        //total Grade Unit Registered,total Course Unit passed,total Weight point,GPA
        public static List<GradingSystemProperties> ListOfCourses { get; set; } = new List<GradingSystemProperties>();

        public void AddCourseDetails()
        {
            Console.Write("Enter course description: ");
            string courseDescription = Console.ReadLine();
            string pattern = @"(^[A-Z]{3}[0-9]{3}$)";

            if (Regex.IsMatch(courseDescription, pattern))
            {
                Console.Write("Enter course score: ");
                double courseScore = double.Parse(Console.ReadLine());
                Console.WriteLine();

                if (courseScore >= 0 && courseScore <= 100)
                {

                    Console.Write("Enter course unit : ");
                    int courseUnit = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    int courseGradeUnit;
                    string courseGrade;
                    string remark;

                    if (courseScore >= 70 && courseScore <= 100)
                    {
                        courseGrade = Enum.GetName(typeof(Grade), 5);
                        courseGradeUnit = (int)Grade.A;
                        remark = "Excellent";
                    }
                    else if (courseScore >= 60 && courseScore <= 69)
                    {
                        courseGrade = Enum.GetName(typeof(Grade), 4);
                        courseGradeUnit = (int)Grade.B;
                        remark = "Very Good";
                    }
                    else if (courseScore >= 50 && courseScore <= 59)
                    {
                        courseGrade = Enum.GetName(typeof(Grade), 3);
                        courseGradeUnit = (int)Grade.C;
                        remark = "Good";
                    }
                    else if (courseScore >= 45 && courseScore <= 49)
                    {
                        courseGrade = Enum.GetName(typeof(Grade), 2);
                        courseGradeUnit = (int)Grade.D;
                        remark = "Fair";
                    }
                    else if (courseScore >= 40 && courseScore <= 44)
                    {
                        courseGrade = Enum.GetName(typeof(Grade), 1);
                        courseGradeUnit = (int)Grade.E;
                        remark = "Pass";
                    }
                    else
                    {
                        courseGrade = Enum.GetName(typeof(Grade), 0);
                        courseGradeUnit = (int)Grade.F;
                        remark = "Fail";
                    }

                    int courseWeigthPoint = courseGradeUnit * courseUnit;

                    var addToList = new GradingSystemProperties(courseDescription, courseScore, courseUnit, courseGrade, courseGradeUnit, courseWeigthPoint, remark);
                    ListOfCourses.Add(addToList);
                } 
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid Input");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

        }


        public void RemoveCourseDetails(string getCourseToRemove)
        {
            Console.Clear();
            GradingSystemProperties userRemoveChoice = ListOfCourses.Find(i => i.CourseDescription == getCourseToRemove);

            if (userRemoveChoice == null)
            {
                Console.WriteLine("Course not found!!");
            }
            else
            {
                ListOfCourses.Remove(userRemoveChoice);
            }
        }
       
        public static void ResultSummary()
        {
            int totalGradeUnitReg     = ListOfCourses.Select(i => i.CourseGradeUnit).Sum();
            int totalCourseUnitPassed = ListOfCourses.Select(i => i.CourseUnit).Sum();
            int totalWeigthPoint      = ListOfCourses.Select(i => i.CourseWeightPoint).Sum();
            float Gpa = (float)totalWeigthPoint / (float)totalCourseUnitPassed;

            Console.WriteLine($"Total Grade Unit Registered is {totalGradeUnitReg}\n"+ 
                              $"Total Course Unit passed is {totalCourseUnitPassed}\n" + 
                              $"Total Weight point is {totalWeigthPoint}\n" +
                              $"$GPA is {Math.Round(Gpa, 2)}");
        }
    }
}
