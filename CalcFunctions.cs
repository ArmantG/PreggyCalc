using System;
using static System.Console;
using System.Globalization;

namespace PreggyCalc
{
  public class CalcFunctions
  {
    internal static void PregCalc()

    {
      Clear();
      MenuSel.OptMenu();
      MenuSel choice = new(ReadLine());

      if (choice.Selection == "1")
      {
        try
        {
          DateCalc.DueDate();
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
      else if (choice.Selection == "2")
      {
        try
        {
          DateCalc.ConDate();
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
      else if (choice.Selection == "3")
      {
        WriteLine("Enter the date of the 1st day of your last period - use the format " + CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern);
        ReadLine();

      }
      else if (choice.Selection == "4")
      {
        WriteLine("How many weeks are you now (just weeks, days in next question");
      }
      else if (choice.Selection == "5")
      {
        // stays blank = returns void and automatically returns to main menu
      }

    }


  }
}