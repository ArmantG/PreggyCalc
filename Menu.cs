using System;
using static System.Console;

namespace PreggyCalc
{
  public class Menu
  {
    internal static bool MainMenu()
    {
      Clear();
      WriteLine("Choose an option: ");
      WriteLine("1: Pregnancy Calculator");
      WriteLine("2: Exit");
      string option = ReadLine();

      if (option == "1")
      {
        CalcFunctions.PregCalc();
        return true;
      }
      else
      {
        return false;
      }
    }
  }

  public class MenuSel
  {
    private string selection;

    internal static void OptMenu()
    {
      WriteLine("1: Enter your due date");
      WriteLine("2: Enter your conception date");
      WriteLine("3: Enter your 1st day of your last period date");
      WriteLine("4: Enter your current weeks & days");
      WriteLine("5: Return to main menu");
    }

    public MenuSel(string menuOption)
    {
      Selection = menuOption;
    }

    public string Selection
    {
      get { return selection;  }
      set { if (value == "1" || value == "2" || value == "3" || value == "4" || value == "5")
        {
          selection = value;
        }
        else
        {
          selection = "";
        }
          }
    }
  }


}
