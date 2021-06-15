using System;

namespace Homework_Template
{
    class Program
    {
        static void Main(string[] args)
        {
            string result;

            do
            {
                result = DisplayMenu();
                Run(result);
            }
            while (result.ToUpper() != "E");

            Console.WriteLine(" Good Bye...");

        }
        public static string DisplayMenu()
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Rob Sorbo\nHomework Week 3");
            Console.WriteLine();
            Console.WriteLine("Hit [1] to run Exercise 1.");
            Console.WriteLine("Hit [2] to run Exercise 2.");
            Console.WriteLine("Hit [3] to run Exercise 3.");
            Console.WriteLine("Hit [4] to run Exercise 4.");
            Console.WriteLine("Hit [5] to run Exercise 5.");

            Console.WriteLine();
            Console.WriteLine("Hit [E]: Exit;");
            Console.WriteLine();
            Console.WriteLine();

            var result = Console.ReadLine();
            return result;


        }
        private static bool Run(string exeArg)

        {
            switch (exeArg.ToLower())
            {

                case "1":
                    DoExe1();
                    return true;

                case "2":
                    DoExe2();
                    return true;

                case "3":
                    DoExe3();
                    return true;

                case "4":
                    DoExe4();
                    return true;

                case "5":
                    DoExe5();
                    return true;

                default:
                    Console.WriteLine("Exiting the Program!");
                    return true;
            }
        }
        private static void DoExe1()
        {
            // Add code for Exercise 1 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.


            //Declared variable MSU
            string MSU = "Missouri State University College of Business";

            //Find appopriate starting point, then grabbing the subsequent substring.
            int startPoint = MSU.IndexOf(" ") + 1;
            string word2 = MSU.Substring(startIndex: startPoint, length: MSU.IndexOf(value: " ", startPoint) - startPoint);

            //Generate the output
            Console.WriteLine($"Exercise 1: \nSecond word: {word2}");
        }
        private static void DoExe2()
        {
            // Add code for Exercise 2 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.
            //How I got the day of the week: https://www.tutorialspoint.com/chash-program-to-get-current-day-of-week
            //Date and Time formatting: https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings 

            //Variables used
            string myName = "Rob";
            DayOfWeek today = DateTime.Today.DayOfWeek;
            DateTime currentDate = DateTime.Now;

            Console.WriteLine("Exercise 2:");

            //Output 1: Composite Formatting
            string Output1;
            Output1 = String.Format("Composite Formatting:\nHello, {0}! Today is {1}, it's {2:MM/dd/yy hh:mm tt} now.", myName, today, currentDate);
            Console.WriteLine(Output1);

            Console.WriteLine();

            //Output 2: String interpolation
            Console.WriteLine("String Interpolation:\nHello, {0}! Today is {1}, it's {2:MM/dd/yy hh:mm tt} now.", myName, today, currentDate);

        }
        private static void DoExe3()
        {
            // Add code for Exercise 3 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.


            Console.WriteLine("Exercise 3:");

            Console.WriteLine("The path is C:\\Windows\\System32");
            Console.WriteLine(@"The path is C:\Windows\System32");
        }
        private static void DoExe4()
        {
            // Add code for Exercise 4 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.
            Console.WriteLine("Exercise 4:\n");

            //Variables
            const double WITHHOLDING_RATE = 15;
            string hoursAsString, rateAsString;
            double hours, rate;
            double gross, withholding, net;

            //Prompts
            Console.Write("Enter the number of hours you worked this week >> ");
            hoursAsString = Console.ReadLine();
            Console.Write("Enter your hourly rate >> ");
            rateAsString = Console.ReadLine();

            //data type conversion
            hours = Convert.ToDouble(hoursAsString);
            rate = Convert.ToDouble(rateAsString);

            //Calculations: gross = rate*hours, withholding = gross * 15%, net = gross-withholding
            gross = hours * rate;
            withholding = gross * WITHHOLDING_RATE / 100; // 15/100 = 15%
            net = gross - withholding;

            //Outputs
            Console.WriteLine("You worked {0} hours at {1} per hour",
            hours, rate.ToString("C"));
            Console.WriteLine("Gross pay is {0}", gross.ToString("C"));
            Console.WriteLine("Withholding is {0}", withholding.ToString("C"));
            Console.WriteLine("Net pay is {0}", net.ToString("C"));
        }
        private static void DoExe5()
        {
            // Add code for Exercise 5 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.


            string name, bossName;
            bool areNamesTheSame;


            Console.Write("Enter your name >> ");
            name = Console.ReadLine();
            Console.Write("Hello {0}! Enter the name of your boss >> ", name);
            bossName = Console.ReadLine();
            areNamesTheSame = String.Equals(name, bossName);
            Console.WriteLine("It is {0} that you are your own boss.", areNamesTheSame);
        }
    }
}