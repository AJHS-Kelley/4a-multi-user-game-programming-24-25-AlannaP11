using System;
class RPS {
  static void Main() {
    //player variables
    int playerScore = 0;
    ///string choiceTextInput;
    int playerChoice;
    //cpu variables
    int cpuChoice;
    int cpuScore = 0;

    int numDraws = 0;
    int loopCount = 0;
    int loopsReqs = 0; //reqs is universal abbreviation for requests, req for request
    Console.WriteLine("How many loops do you need?\nType an integer and press enter.");
    loopsReqs = Convert.ToInt32(Console.ReadLine());

    
      if (playerScore == 5)
    {
      Console.WriteLine("Player has won the game! Thanks for playing!");
    }
    else if (cpuScore == 5)
    {
      Console.WriteLine($"CPU has won the game! Thanks for playing!");
    }
    
    
    Random rnd = new Random();

  while(loopCount < loopsReqs)
    {


    //cpu selects here
    cpuChoice = rnd.Next(1, 4);
    // Console.WriteLine(cpuChoice);
            if (cpuChoice == 1)
    {
      // Console.WriteLine("CPU chose Rock!");
    }
    else if (cpuChoice == 2)
    {
      // Console.WriteLine("CPU chose Paper!");
    }
    else
    {
      // Console.WriteLine("CPU chose Scissors!");
    }

    //player selects here
    playerChoice = rnd.Next(1, 4);
    // Console.WriteLine(cpuChoice);
            if (playerChoice == 1)
    {
      // Console.WriteLine("Player chose Rock!");
    }
    else if (playerChoice == 2)
    {
      // Console.WriteLine("Player chose Paper!");
    }
    else
    {
      // Console.WriteLine("Player chose Scissors!");
    }


      //player's choice and cpu's choice are compared, scores are printed
        if (playerChoice == 1 && cpuChoice == 1)
      {
        numDraws = numDraws + 1;
      }
        else if (playerChoice == 2 && cpuChoice == 2)
      {
        numDraws = numDraws + 1;
      }
        else if (playerChoice == 3 && cpuChoice == 3)
      {
        numDraws = numDraws + 1;
      }
      else if (playerChoice == 1 && cpuChoice == 2)
      {
        // Console.WriteLine("CPU wins!\n");
        // cpuScore++;
        cpuScore = cpuScore + 1;
      }
      else if (playerChoice == 1 && cpuChoice == 3)
      {
        // Console.WriteLine("Player wins!\n");
        // playerScore++;
        playerScore = playerScore + 1;
      }
      else if (playerChoice == 2 && cpuChoice == 1)
      {
        // Console.WriteLine("Player wins!\n");
        // playerScore++;
        playerScore = playerScore + 1;
      }
      else if (playerChoice == 2 && cpuChoice == 3)
      {
        // Console.WriteLine("CPU wins!\n");
        // cpuScore++;
        cpuScore = cpuScore + 1;
      }
      else if (playerChoice == 3 && cpuChoice == 1)
      {
        // Console.WriteLine("CPU wins!\n");
        // cpuScore++;
        cpuScore = cpuScore + 1;
      }
      else if (playerChoice == 3 && cpuChoice == 2)
      {
        // Console.WriteLine("Player wins!\n");
        // playerScore++;
        playerScore = playerScore + 1;
  
      }
      // else
      // {
      //   // Console.WriteLine("Draw!\n");
      //   // numDraws++;
      //   numDraws = numDraws + 1;
      // }
      loopCount++;
    }
    Console.WriteLine($"Number of player wins: {playerScore}");
    Console.WriteLine($"Number of CPU wins: {cpuScore}");
    Console.WriteLine($"Number of draws: {numDraws}");
  }
}