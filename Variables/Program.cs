
// Strings 
// Strings can be any ASCII character
using System.Threading.Tasks.Sources;

string username;
username = "harold";
Console.WriteLine("Hi " + username);

// Intergers 
// Intergers have to have a numbered value 
int score = 1;

// Reading from a variable does not change it 
int a;
int b;

a = 5;
b = 2;
Console.WriteLine("a: " + a + " | " + "b: " + b);

b = a;
Console.WriteLine("a: " + a + " | " + "b: " + b);

a = -3;
Console.WriteLine("a: " + a + " | " + "b: " + b);

// Variable tricks 
// Define a varaible on the same line
int x = 0;

// Define multiple variables 
int var1,var2, var3;

// Variable assignments are expressions, meaning you can assign many things to one value
var1 = var2 = var3 = 10;
Console.WriteLine("var1: " + var1 + " var2: " + var2 + " var3: " + var3);
