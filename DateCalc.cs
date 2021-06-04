using System;
using static System.Console;
using System.Globalization;

namespace PreggyCalc
{
public class DateCalc
{
  internal static void DueDate()
  {
    WriteLine("Enter your due date - use the format " + CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern);
    var dueDateInput = ReadLine();

    var dueDate = Convert.ToDateTime(dueDateInput);
    // TODO: Add secondary question to get cycle length, then add
    // TODO: calculation as part of the output.
    WriteLine();
    WriteLine("Your conception date is = " + dueDate.AddDays(-266).ToShortDateString() + "\n" + "This is an estimate and falls within the following possible range:  \n" + dueDate.AddDays(-280).ToShortDateString() + " to " + dueDate.AddDays(-266).ToShortDateString());

    WriteLine();
    WriteLine("Your most likely 1st day of last period date is = " + dueDate.AddDays(-280).ToShortDateString());

    WriteLine();
    TimeSpan weeks = DateTime.Now.Subtract(dueDate);
    TimeSpan days = DateTime.Now.Subtract(dueDate);
    double weeksPreg = (weeks.TotalDays + 280) / 7;
    double weeksPreg2 = Math.Truncate(weeksPreg);
    double daysPreg = (days.TotalDays + 280) % 7; double daysPreg2 = Math.Truncate(daysPreg);
    // TODO: Need to add the LMP calculation.
    WriteLine("You are currently {0} weeks and {1} days pregnant",
    arg0: weeksPreg2,
    arg1: daysPreg2);
    WriteLine();
    WriteLine("You have about {0} weeks remaining...", arg0: 40 - Math.Truncate(weeksPreg));
    ReadLine();
  }

  internal static void ConDate()
  {
    WriteLine("Enter your conception date - use the format " + CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern);
    ReadLine();
  }

}
}
