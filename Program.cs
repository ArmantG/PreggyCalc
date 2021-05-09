using System;
using System.Globalization;
using static System.Console;

namespace ConceptCalc
{
    public class Program
    {
        // Main Program
        public static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }

        // Menu Function
        private static bool MainMenu()
        {
            Clear();
            WriteLine("Choose an option: ");
            WriteLine("1: Pregnancy Calculator");
            WriteLine("2: Exit");
            string option = ReadLine();

      if (option == "1")
      {
        PregCalc();
        return true;
      }
      else
      {
        return false;
      }
        }

        // COMMENT: Menu Extensions

        private static void PregCalc()
        {
            Clear();

            WriteLine("1: Enter your due date");
            WriteLine("2: Enter your conception date");
            WriteLine("4: Enter your 1st day of your last period date");
            WriteLine("4: Enter your current weeks & days");
            WriteLine("5: Return to main menu");
            string option = ReadLine();

            if (option == "1")
            {
                try
                {
                WriteLine("Enter your due date - use the format yyyy/mm/dd");
                string dueDateInput = ReadLine();

                DateTime dueDate = DateTime.Parse(dueDateInput, new CultureInfo("en-ZA"));
               // TODO: Add secondary question to get cycle length, then add
               // TODO: calculation as part of the output. 
                WriteLine();
                WriteLine("Your conception date is = " + dueDate.AddDays(-266).ToShortDateString() + "\n" + "This is an estimate and falls within the \nfollowing possible range:  " + dueDate.AddDays(-252).ToShortDateString() + " to " + "\n" + dueDate.AddDays(-280).ToShortDateString());

                WriteLine();
                TimeSpan weeks = DateTime.Now.Subtract(dueDate);
                TimeSpan days = DateTime.Now.Subtract(dueDate);
                double weeksPreg = (weeks.TotalDays + 280) / 7;
                double weeksPreg2 = Math.Truncate(weeksPreg);
                double daysPreg = (days.TotalDays + 280) % 7;                    double daysPreg2 = Math.Truncate(daysPreg);
                    // TODO: Need to add the LMP calculation.  
                WriteLine("You are currently {0} weeks and {1} days pregnant",
                arg0: weeksPreg2,
                arg1: daysPreg2);
                WriteLine();
                WriteLine("You have about {0} weeks remaining...", arg0: 40 -Math.Truncate(weeksPreg));
                ReadLine();

                }
                catch (FormatException ex)
                {
                    WriteLine("You did not enter a valid date or use the correct format, please read the instructions carefully and try again, idiot...");
                }
                catch (Exception ex)
                {
                    WriteLine("You did not enter a valid date or use the correct format, please read the instructions carefully and try again, idiot...");
                }
                finally
                {
                    PregCalc();
                }
            }
            else if (option == "2")
            {
                WriteLine("Enter your conception date - use the format mm/dd/yyyy");


            }
            else if (option == "3")
            {
                WriteLine("Enter the date of the 1st day of your last period - use the format mm/dd/yyyy");


            }
            else if (option == "4")
            {
                WriteLine("how many weeks are you now (just weeks, days in next question");
            }
            else if (option == "5")
            {
                // stays blank = returns void and automatically returns to main menu
            }

        }


        ///////////////////////////////////
        // COMMENT: Calculation functions..


        /*
        if (option == "1") 
              {
                    WriteLine("Enter your conception date - use the format mm/dd/yyyy");
                    string conDate = ReadLine();
                    DateTime conDate2 = DateTime.Parse(conDate, new CultureInfo("en-ZA"));
                    WriteLine("Your due date is = " + conDate2.AddDays(266).ToShortDateString() + " This is an estimate and falls within the following possible range:  " + conDate2.AddDays(252).ToShortDateString() + " to " + conDate2.AddDays(280).ToShortDateString());
                 } 
                 else if (option == "2") 
                 {
                   WriteLine("Enter the date of the 1st day of your last period - use the format mm/dd/yyyy");
                    string perDate = ReadLine();
                    DateTime perDate2 = DateTime.Parse(perDate, new CultureInfo("en-ZA"));
                    WriteLine("Your due date is = " + perDate2.AddDays(280).ToShortDateString() + " This is an estimate and falls within the following possible range:  " + perDate2.AddDays(266).ToShortDateString() + " to " + perDate2.AddDays(294).ToShortDateString());
                 } 
                 else if (option == "3") 
                 {
                   WriteLine("how many weeks are you now (just weeks, days in next question");
                    string weeksInput = ReadLine();
                    WriteLine("how many days are you now");
                    string daysInput = ReadLine();
                    int weeks = Int32.Parse(weeksInput);
                    int days = Int32.Parse(daysInput);
                    DateTime currentDate = DateTime.Now;
                    WriteLine("Likely due date : " + currentDate.AddDays(280 - (weeks*7) - days).ToShortDateString() + "Please keep in mind that this date is an estimate and falls within a date range: " + currentDate.AddDays(266 - (weeks*7) - days).ToShortDateString()) + " to " + currentDate.AddDays(294 - (weeks*7) - days).ToShortDateString();
                 }
        */

    }

    // Need menu to select DueDate, current weeks/days, Conception or LMP
    // Need inputs 
    // Need Class/method for DueDate, Current weeks/days, conception or LMP
    // Need function to return star sign 
    // Need function to return current weeks/days
    //Output should include date range of possible conception
    //Output should include date range for possible due date
    //Output should incluce date range for possible LMP


}
