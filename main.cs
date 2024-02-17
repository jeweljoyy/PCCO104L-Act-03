using System;

class Program {
  public static void Main (string[] args) {
    string input = "";

    while (input != "goodbye")//goodbye instead of exit
    {
      Console.WriteLine("Give you greetings! ");
      input = Console.ReadLine();
      Console.WriteLine("You said " + input + ",");
    }
      Console.WriteLine("See you next time!");
  }
}