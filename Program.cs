using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength = 8;
      string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowerCase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "0123456789";
      string specialChars = "!?^%$£";

      Console.WriteLine("Please enter a password you'd like to check: ");
      string userInput = Console.ReadLine();
      int score = 0;
      //check password length
      if (userInput.Length >= minLength)
      {
        score++;
      }
      //check if password contains uppercase chars
      if (Tools.Contains(userInput, upperCase))
      {
        score++;
      }
      //check if password contains lowercase chars
      if (Tools.Contains(userInput, lowerCase))
      {
        score++;
      }
      //check if password contains numbers
      if (Tools.Contains(userInput, digits))
      {
        score++;
      }
      //check if password contains special chars
      if (Tools.Contains(userInput, specialChars))
      {
        score++;
      }
      //show password score to user
      switch (score)
      {
        case 5:
          Console.WriteLine("Your password is extremely strong!");
          break;
        case 4:
          Console.WriteLine("Your password is extremely strong!");
          break;
        case 3:
          Console.WriteLine("Your password is strong");
          break;
        case 2:
          Console.WriteLine("Your password could be better...");
          break;
        case 1:
          Console.WriteLine("Your password is weak. We recommend you try another");
          break;
        default:
          Console.WriteLine("Your password does not meet our standards");
          break;
      }

    }
  }
}
