using System;

namespace JoshGressman.MaxCalc
{
  class Program
  {
    static void Main()
    {
      //Input max 8 rep lift
      while(true)
      {
        Console.Write("Enter Your 8 Rep Max or type \"quit\" to exit");

        var entry = Console.ReadLine();

        if(entry.ToLower() == "quit")
        {
          break;
        }
        else
        {
          var liftTotal = double.Parse(entry);

          var maxLift = liftTotal * .80;

          Console.WriteLine("Your Max Lift is " + maxLift);
        }



      }
      //return the 1 rep max value of 80 % of the lift

      //Use a conditional depending on weight
    }
  }
}
