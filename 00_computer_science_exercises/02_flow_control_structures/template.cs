using System;
class FlowControlStructures {
  static void Main() {
    //these blocks of code are used to control how the program executes. basically these blocks of code allow for decisions to be made
    int age = 6;
    double time = 15.5D;
    string catName = "Charles";
    bool likesFood = true;
    //can he vote?
    if (age >= 18) //(age >=18) is the conditional statement
    {
      Console.WriteLine("You can vote!\n");
    }
    else if (age >= 16) //check this next if line 10 is false
    {
      Console.WriteLine ("Not yet! However, you can register! imagine being a minor tho... i personally would never but you do you ig\n");
    }
    else
    {
        Console.WriteLine("You are not old enough to vote. get out of my sight\n");
    }
    /*you can have a sngle if statement by itself. if you hae an else you must also have an if. you can have as many else if statements as needed
    for now, use the else condition to print error messages and logs
    if you are using > or >= in your control structures, check for greatest value first

    */
  }
}