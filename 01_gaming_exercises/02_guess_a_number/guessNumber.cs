using System;
class GuessNumber {
  static void Main() {
    int numGuesses = 0;
    int maxGuesses = 4;
    int guess;

    //generate secret number here
    Random rnd = new Random(); //create an object named rnd that is a copy of the random() class
    int secretNumber = rnd.Next(101); //generate from 0 to 100
    // int secretNumber = rnd.Next(25, 1000); //generate from 25 to 1000
    // Console.WriteLine(secretNumber); //comment out after testing

    //while loop
    while(numGuesses < maxGuesses)
    {
      Console.WriteLine("Please guess an integer between 0 and 100");
      guess = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine(guess);
      numGuesses++;
    }
      //guess the number here
      //compare the guessed number to the secret number
      //if match, print win, if not, give a hint. is it too high or too low?
      //+1 to numGuesses
      //check if numGuesses > maxGuesses
      //if true, print loss, if false, guess again

  }
}