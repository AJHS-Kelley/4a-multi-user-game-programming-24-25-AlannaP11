using System;
class RockPaperScissors {
  static void Main() {
    int playerScore = 0;
    int cpuScore = 0;
    string choiceTextInput;
    int playerChoice;
    int cpuChoice;

    Console.WriteLine("Welcome to rock, paper, scissors. The rules are simple. Scissors beats paper, paper beats rock, and rock beats scissors. The winner earns a point each round. If it ends in a draw, no points are awarded. The first player to get 5 points wins.What's your name? Type it in the console and press enter.");
    string playerName = Console.ReadLine();
    Console.WriteLine("Your name is " + playerName);
    Console.WriteLine("So, " + playerName + ", What will you choose?");
    choiceTextInput = Console.ReadLine();
        if (choiceTextInput == "rock" || choiceTextInput == "Rock" || choiceTextInput == "ROCK")
    {
      playerChoice = 1;
      Console.WriteLine($"{playerName} chose Rock!");
    }
    else if (choiceTextInput == "paper" || choiceTextInput == "Paper" || choiceTextInput == "PAPER")
    {
      playerChoice = 2;
      Console.WriteLine($"{playerName} chose Paper!");
    }
    else if (choiceTextInput == "scissors" || choiceTextInput ==  "Scissors" || choiceTextInput == "SCISSORS")
    {
      playerChoice = 3;
      Console.WriteLine($"{playerName} chose Scissors!");
    }
    else
    {
        Console.WriteLine("You may have made a typo. Please try again.");
    }

    Random rnd = new Random();
    cpuChoice = rnd.Next(1, 3);
    Console.WriteLine(cpuChoice);
            if (cpuChoice == 1)
    {
      Console.WriteLine("CPU chose Rock!");
    }
    else if (cpuChoice == 2)
    {
      Console.WriteLine("CPU chose Paper!");
    }
    else
    {
      Console.WriteLine("CPU chose Scissors!");
    }

     while(playerScore <= 5 || cpuScore <=5)
    {
      if (playerChoice == 1 && cpuChoice == 2)
      {
        Console.WriteLine("CPU wins!");
        cpuScore++;
        Console.WriteLine($"{playerName}'s score is {playerScore}");
        Console.WriteLine($"CPU's score is {cpuScore}");
      }
      else if (playerChoice == 1 && cpuChoice == 3)
      {
        Console.WriteLine($"{playerName} wins!");
        playerScore++;
                Console.WriteLine($"{playerName}'s score is {playerScore}");
        Console.WriteLine($"CPU's score is {cpuScore}");
      }
      else if (playerChoice == 2 && cpuChoice == 1)
      {
        Console.WriteLine($"{playerName} wins!");
        playerScore++;
                Console.WriteLine($"{playerName}'s score is {playerScore}");
        Console.WriteLine($"CPU's score is {cpuScore}");
      }
      else if (playerChoice == 2 && cpuChoice == 3)
      {
        Console.WriteLine("CPU wins!");
        cpuScore++;
                Console.WriteLine($"{playerName}'s score is {playerScore}");
        Console.WriteLine($"CPU's score is {cpuScore}");
      }
      else if (playerChoice == 3 && cpuChoice == 1)
      {
        Console.WriteLine("CPU wins!");
        cpuScore++;
                Console.WriteLine($"{playerName}'s score is {playerScore}");
        Console.WriteLine($"CPU's score is {cpuScore}");
      }
      else if (playerChoice == 3 && cpuChoice == 2)
      {
        Console.WriteLine($"{playerName} wins!");
        playerScore++;
                Console.WriteLine($"{playerName}'s score is {playerScore}");
        Console.WriteLine($"CPU's score is {cpuScore}");
      }
      else
      {
        Console.WriteLine("Draw!");
                Console.WriteLine($"{playerName}'s score is {playerScore}");
        Console.WriteLine($"CPU's score is {cpuScore}");
      }
    }





  }
}