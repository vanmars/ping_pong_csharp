using System;
using System.Collections.Generic;

public class Program {

  static void Main(){
    //UI Interface
    Console.WriteLine("Welcome to Ping Pong !");
    Console.WriteLine("----------------------");
    Console.WriteLine("Please enter a number.");
    string inputtedNumberString = Console.ReadLine();
    int inputtedNumber = int.Parse(inputtedNumberString);

    // For Each Loop to Add Values to List
    for(int index=1; index<=inputtedNumber; index++)
    {
      // Conditional Logic to Manipulate Values Added to List
      if (index%3 == 0)
      {
        Console.WriteLine("ping");
      }
      else if (index%5 == 0)
      {
        Console.WriteLine("pong");
      }
      else
      {
        Console.WriteLine(index);
      }
      
    }
  } 
}