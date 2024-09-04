//Data Types and Operators, Alannna Patterson, v0.0
using System;
class DataTypesOperators {
  static void Main() {
    //comment baybeeeee yeaaah
    /*for when youre really yapping, EVERYTHING is a comment until it ends like this*/
    
    //data types. C# is statically typed. This means that once a variable has a data type, it cannot change.

    //a float is a decimal number, can be positive or negative, includes 0.0
    //A double is a decimal number, can be positive or negative, includes, most commonly used.
    //An integer is a whole number, shortened as int, positive or negative, includes 0.

    //variables are buckets with a name to store data inside.
    //to declare is to create a variable
    //to declare but not assign:
    //dataType variableName;
    int myInteger;
    double myDouble;

    //to declare and assign:
    int myInteger2 = 1;
    double myDouble2 = 2.05D;

    //Strings are collections of letters, numbers, special characters, etc.
    string myString = "Here's a string!";

    //Booleans are called bool, means true or false
    bool myBoolean = true;

    //character, shortened to char, a single character
    char myChar = 'S';

    //assigning values after declaration
    myInteger = 5;
    myDouble = 3.6D;
    myString = "no more strings for you";
    myBoolean = false;
    myChar = 'H';

    //printing variables to the console terminal
    // Console.WriteLine(myInteger);
    // Console.WriteLine(myDouble);

    // //printing expressions to the console terrminal
    // Console.WriteLine(myInteger - 3);
    // Console.WriteLine(myDouble + 4);

    //arithmetic operators. adding an integer and a double only works if the new variable is a double.
    //addition
    int myNewInt = myInteger + myInteger2;
    double myNewDouble = myDouble + myDouble2;
    double myNewNumber = myInteger + myDouble;
    //subtraction
    myNewNumber = myDouble - myInteger;
    //division
    myNewNumber = myDouble / myInteger;
    //multiplication
    myNewNumber = myDouble * myInteger;
    //modulus, divides then reterns the remainder
    //most commonly used to determine even or odd
    myNewNumber = myDouble % 2;
    int students = 6;
    int numSlices = 36;
    int leftOvers;
    leftOvers = numSlices % students;
    //increment/decrement, most frequently used in loops
    int x = 0;
    x++; //what is x equal to now
    //increment ++ adds 1 to the current value and makes the variable into the new value
    x--;
    //decrement -- subtracts 1 from the current value and makes the variable into the new value
    //special assignment operators
    x += 1;
    x *= 1;
    x /= 1;
    x -= 1;
    x %= 1;
    //take current value, perform calculation, replace variable with new value

    //comparison operators
    //evaluate expression, return true or false
    int y = 5;
    int z = 3;
    //is equal to, is the value on the left equal to the value on the right
    // Console.WriteLine(y == z);
    // //not equal to, is the value on the left not equal to the value on the right
    // Console.WriteLine(y != z);
    // //greater than
    // Console.WriteLine(y > z);
    // //less than
    // Console.WriteLine(y < z);
    // //greater than or equal to
    // Console.WriteLine(y >= z);
    // //less than or equal to
    // Console.WriteLine(y <= z);

    //logical operators
    int b = 1;
    double c = 2.0D;
    string favColor = "Blue";
    //logal and &&, all statements must be true
    // Console.WriteLine(b > 1 && c != 5.0D); //this is false because b is not greater than 1
    // Console.WriteLine(b == 1 && c < 10.0D); //both statements are true, so this whole thing is true
    // //if one expression is most likely false, check for it first
    // Console.WriteLine(hasPurpleKey == true && playerLevel > 5);
    // //logical or ||, if one statement is true, the whole thing is true
    // Console.WriteLine(b > 1 || c != 5.0D); //true because c is not equal to 5.0
    // Console.WriteLine(b == 2 || c > 10.0D); //false because neither statement is true
    // //check for most likely true first
    // Console.WriteLine(hasPurpleKey == true && playerLevel > 3);
    //logical not !, returns the opposite value of the expression
    // Console.WriteLine(b > -1); //true
    // Console.WriteLine(!(b > -1)); //false

    //reading user input from the console/terminal
    // Console.WriteLine("What is your player name? Type it and press Enter.\n");
    // //create a variable to store the data
    // string playerName = Console.ReadLine();
    //Console.ReadLine(); only returns strings
    // Console.WriteLine("What is your age? Type it and press Enter.\n");
    // string age = Console.ReadLine();
    // Console.WriteLine(age + age);
    //adding strings together is called concatenation
    //print the variable to the screen
    //Console.WriteLine("Your player name is " + playerName);
    //inputting NUMBERS from the console
    Console.WriteLine("How many people are rapidly approaching your location? Enter an integer value and press Enter.\n");
    int numPeople = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(numPeople + numPeople);



  }
}