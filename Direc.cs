using System;
using Microsoft.Extensions.FileSystemGlobbing.Internal.PathSegments;
using Microsoft.VisualBasic;

namespace DotNetDependencies{

public class Direc{
  public static void main(Strings[] args){
     // Prompt the user to enter an integer
        Console.WriteLine("Enter an integer:");

        // Read the input from the user as a string
        string? input = Console.ReadLine();

        // Attempt to parse the input string to an integer
        if (int.TryParse(input, out int number))
        {
            // If successful, display the parsed integer
            Console.WriteLine("Parsed integer: " + number);
        }
        else
        {
            // If parsing fails (e.g., input is not a valid integer), display an error message
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    

  }
}
}
