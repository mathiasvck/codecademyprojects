using System;

namespace ArraysReview
{
  class Program
  {
    static void Main(string[] args)
    {
      /* Program to learn the states of the USA 
      by using arrays, input check with for loop*/
      string[] states = {"alabama", "alaska", "arizona", "arkansas","california", "colorado", "connecticut","delaware", "district of columbia","florida","georgia","hawaii","idaho","illinois", "indiana", "iowa","kansas", "kentucky","louisiana","maine", "maryland", "massachusetts", "michigan", "minnesota", "mississippi", "missouri", "montana","nebraska", "nevada", "new hampshire", "new jersey","new mexico", "new york", "north carolina", "north dakota","ohio", "oklahoma", "oregon","pennsylvania", "rhode island","south carolina", "south dakota","tennessee", "texas","utah","vermont", "virgin islands", "virginia","washington", "west virginia", "wisconsin", "wyoming"};

      int numberOfStates = states.Length;
      Console.WriteLine(numberOfStates);

      Console.Write("Do you know your states?\n Let's start, name the states: ");
      string stateInput = Console.ReadLine();
      
// check if state is in the array
      for (int i=0; i<states.Length; i++)
      {
        if (states[i]==stateInput)
        {
          Console.Write("Correct!");
        }else
        {
          Console.Write("Incorrect.");
        }
      }


    }
  }
}
