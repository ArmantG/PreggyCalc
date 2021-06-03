using System;
using System.Globalization;
using static System.Console;
using PreggyCalc;

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
                displayMenu = Menu.MainMenu();
            }
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
