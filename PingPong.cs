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
      Console.WriteLine(index);
      // Conditional Logic to Manipulate Values Added to List
    }
  } 
}