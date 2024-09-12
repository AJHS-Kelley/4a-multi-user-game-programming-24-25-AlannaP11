using System;
class Strings {
  static void Main() {
    //in c#, all strings must use "double quotes"
    string greeting = "Hello, What's your name?\n";
    string goodbye = "See you soon!\n";

    //in c#, strings are treated like an object that has properties and methods
    //properties are things that describe the object such as length, values, data type, etc
    //methods are built in functions related to that object
    //length is an important property for strings
    Console.WriteLine(greeting.Length);
    Console.WriteLine(goodbye.Length);

    if (greeting.Length > goodbye.Length)
    {
      Console.WriteLine("The greeting has more characters than the goodbye.\n");
    }

    Console.WriteLine(greeting.ToUpper()); //makes entire string uppercase
    Console.WriteLine(greeting.ToLower()); //makes entire string lowercase

    //string concatenation
    string comboString = greeting + goodbye;
    Console.WriteLine(comboString);
    //another method
    string comboString2 = string.Concat(greeting, goodbye);
    Console.WriteLine(comboString2);

    //string interpolation means to substsitute a variable into a string
    string comboString3 = $"My gureeting is {greeting} and my goodbye is {goodbye}";
    Console.WriteLine(comboString3);
    //another method
    Console.WriteLine("My greeting is " + greeting + "and my goodbye is" + goodbye + "\n");

    //accessing parts of strings
    //index is a specific location of a character in a string. all string indexes start at 0
    Console.WriteLine(goodbye[0]); //prints the character at the index 0
    Console.WriteLine(goodbye[4]); //replace x with what to print the 5th character? 4
    //where is it in my string?
    Console.WriteLine(greeting.IndexOf("y"));
    //finding parts of a string
    string fullName = "Billy Mays";
    //what letter?
    int lastInitial = fullName.IndexOf("M");
    //find the substring
    string lastName = fullName.Substring(lastInitial);
    //print it
    Console.WriteLine(lastName);
  }
}