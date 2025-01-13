using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "1234567890";
      string specialChars = "#?!-+*/=";  

      Console.WriteLine("Password: ");
      string input = Console.ReadLine();
      int inputLength = input.Length;

      int score = 0;

      if (input.Length >= minLength){
        score++;
      }
      if (Tools.Contains(input, uppercase)){
        score++;
      }
      if (Tools.Contains(input, lowercase)){
        score++;
      }
      if (Tools.Contains(input, digits)){
        score++;
      }
      if (Tools.Contains(input, specialChars)){
        score++;
      }

      switch (score){
          case 5:
            Console.WriteLine("Password extremely strong");
            break;
          case 4:
            Console.WriteLine("Password extremely strong");
          break;
          case 3:
            Console.WriteLine("Password is strong");
          break;
          case 2:
            Console.WriteLine("Password is medium");
            break;
          case 1:
            Console.WriteLine("Password is weak");
            break;
          default:
            Console.WriteLine("Password doesn't meet the standards");
          break;
      }
      
    }
  }
}