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
}
