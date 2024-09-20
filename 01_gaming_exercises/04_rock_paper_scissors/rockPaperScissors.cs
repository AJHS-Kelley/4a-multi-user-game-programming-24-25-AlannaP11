using System;
class RockPaperScissors {
  static void Main() {
    //player variables
    int playerScore = 0;
    string choiceTextInput;
    string playerChoice;
    //cpu variables
    int cpuChoice;
    int cpuScore = 0;

    Console.WriteLine("Welcome to rock, paper, scissors. The rules are simple. Scissors beats paper, paper beats rock, and rock beats scissors. The winner earns a point each round. If it ends in a draw, no points are awarded. The first player to get 5 points wins. \nWhat's your name? Type it in the console and press enter.");
    string playerName = Console.ReadLine();
    Console.WriteLine($"Your name is {playerName}");
    Console.WriteLine($"So, {playerName}, What will you choose?");
    
    Random rnd = new Random();

  while(playerScore < 5 && cpuScore < 5)
    {
//player selects here
    //   choiceTextInput = Console.ReadLine().ToLower();
    //     if (choiceTextInput == "rock")
    // {
    //   playerChoice = 1;
    //   Console.WriteLine($"{playerName} chose Rock!");
    // }
    // else if (choiceTextInput == "paper")
    // {
    //   playerChoice = 2;
    //   Console.WriteLine($"{playerName} chose Paper!");
    // }
    // else if (choiceTextInput == "scissors")
    // {
    //   playerChoice = 3;
    //   Console.WriteLine($"{playerName} chose Scissors!");
    // }
    // else
    // {
    //     Console.WriteLine("You may have made a typo. Please try again.");
    // }

           playerChoice = Console.ReadLine().ToLower();
         if (playerChoice == "rock")
     {
       Console.WriteLine($"{playerName} chose Rock!");
     }
     else if (playerChoice == "paper")
     {
       Console.WriteLine($"{playerName} chose Paper!");
     }
     else if (playerChoice == "scissors")
     {
       Console.WriteLine($"{playerName} chose Scissors!");
     }
     else
     {
         Console.WriteLine("You may have made a typo. Please try again.");
     }

    //cpu selects here
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

      //player's choice and cpu's choice are compared, scores are printed
      
      if (playerChoice == "rock" && cpuChoice == 2)
      {
        Console.WriteLine("CPU wins!");
        cpuScore++;
        Console.WriteLine($"{playerName}'s score is {playerScore}");
        Console.WriteLine($"CPU's score is {cpuScore}");
      }
      else if (playerChoice == "rock" && cpuChoice == 3)
      {
        Console.WriteLine($"{playerName} wins!");
        playerScore++;
                Console.WriteLine($"{playerName}'s score is {playerScore}");
        Console.WriteLine($"CPU's score is {cpuScore}");
      }
      else if (playerChoice == "paper" && cpuChoice == 1)
      {
        Console.WriteLine($"{playerName} wins!");
        playerScore++;
                Console.WriteLine($"{playerName}'s score is {playerScore}");
        Console.WriteLine($"CPU's score is {cpuScore}");
      }
      else if (playerChoice == "paper" && cpuChoice == 3)
      {
        Console.WriteLine("CPU wins!");
        cpuScore++;
                Console.WriteLine($"{playerName}'s score is {playerScore}");
        Console.WriteLine($"CPU's score is {cpuScore}");
      }
      else if (playerChoice == "scissors" && cpuChoice == 1)
      {
        Console.WriteLine("CPU wins!");
        cpuScore++;
                Console.WriteLine($"{playerName}'s score is {playerScore}");
        Console.WriteLine($"CPU's score is {cpuScore}");
      }
      else if (playerChoice == "scissors" && cpuChoice == 2)
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