using System;
class Strings {
  static void Main() {
    //in c#, all strings must use "double quotes"
    string greeting = "Hello, What's your name?\n";
    string goodbye = "Bye bye\n";

    //in c#, strings are treated like an object that has properties and methods
    //properties are things that describe the object such as length, values, data type, etc
    //methods are built in functions related to that object
    //length is an important property for strings
    Console.WriteLine(greeting.length);
    Console.WriteLine(goodbye.length);

    if (greeting.length > goodbye.length)
    {
      Console.WriteLine("The greeting has more characters than the goodbye.\n");
    }
    Console.WriteLine(greeting.ToUpper()); //makes entire string uppercase
    Console.WriteLine(greeting.ToLower()); //makes entire string lowercase
  }
}