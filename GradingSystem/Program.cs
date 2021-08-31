using System;

namespace GradingSystem

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your grading system app! Enjoy the Perfect Experience.");
            Console.WriteLine();
            Console.WriteLine("Enter 1 to start");
           
            int one;
            
            bool success = int.TryParse(Console.ReadLine(), out one);
            if (one != 1 || !success)
            {
                Console.WriteLine("Input is incorrect. select 1 - 4");

                while (one != 1 || !success)
                {
                    Console.Clear();
                    Console.WriteLine("Enter 1 to start");
                    success = int.TryParse(Console.ReadLine(), out one);
                    Console.WriteLine("Input is incorrect. select 1");
                    continue;
                }
            }


            while (one == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("***What do you want to do?: ");
                    Console.WriteLine();
                    Console.WriteLine("***Enter 1 to add course? ");
                    Console.WriteLine("***Enter 2 remove course? ");
                    Console.WriteLine("***Enter 3 print result? ");
                    Console.WriteLine("***Enter 4 to exit the app.");

                    int userInput;
                    bool correct = int.TryParse(Console.ReadLine(), out userInput);
                    if (!correct)
                    {
                        Console.WriteLine("Input is incorrect. select 1 - 4");

                        while (!correct)
                        {
                            Console.Clear();
                            Console.WriteLine("Input is incorrect!");
                            Console.WriteLine();
                            Console.WriteLine("Enter 1 to start");
                            correct = int.TryParse(Console.ReadLine(), out userInput);
                            Console.WriteLine("Input is incorrect. select 1 - 4");
                            continue;
                        }
                    continue;
                    }

                    GradingSystemMethods call = new GradingSystemMethods();

                    if (userInput == 1)
                    {
                        Console.Clear();
                        call.AddCourseDetails();
                    }
                    else if (userInput == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("enter item to remove");
                        string remove = Console.ReadLine();
                        call.RemoveCourseDetails(remove);
                    }
                    else if (userInput == 3)
                    {
                        Console.Clear();
                        GradingSystemPrint.Print();

                    }
                    else if (userInput == 4)
                    {
                        System.Environment.Exit(0);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid selection. Select 1 - 4.");
                    }
                    continue;
                }
            

        }
    }
   
}
