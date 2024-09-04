using System;
class Template {
  static void Main() {
    int numLives = 3;
    Console.WriteLine("What is your score?");
    int score = Convert.ToInt32(Console.ReadLine());
  {
        if (score < 10000)
  }
      numLives - 1
    {
    else if (score < 100000)
    }
      numLives + 1
    {
    else
    }
        numLives + 2;
    {
Console.WriteLine(numLives);
    if (numLives = 1)
    }
      Console.WriteLine("You have "numLives" life!")
    {
    else
    }
      Console.WriteLine("You have "numLives" lives!");
    {
  }
}