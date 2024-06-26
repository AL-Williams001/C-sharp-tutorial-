﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, AL!");


string firstFriend = "    John    ";
firstFriend = firstFriend.Trim();





string secondFriend = "     Mary    ";


// $ = string interpolation/concatination 
string friends = $"My friends are {firstFriend} and {secondFriend.Trim()}!";

Console.WriteLine(friends);
friends = friends.Replace("Mary", "Scott");
Console.WriteLine(friends);
Console.WriteLine(friends.ToUpper());
Console.WriteLine (friends.Contains("John"));
Console.WriteLine(friends.Length);

// integers, numbers & Math / max is 21billion because of it's memory size per integer
// long is used for large large numbers like the example below and to avoid overflow 
// loncg c = checked(a + b); checked is used to check for overflows
int a = 2100000000;  
int b = 2100000000;
long c = (long)a + (long)b;
Console.WriteLine(c);

// Precision, Casting and Doubles

decimal d = 42.1M;  // explicit type 
decimal e = 38.2M;
decimal f = checked( d + e);
Console.WriteLine($"The answer is {f}");

// Ifs and Conditionals

int g = 5;
int h = 3;
int j = 4;

if ((g + h + j > 10) || (g == h))
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("And the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("Or the first number is not equal to the second");
}

//For Loops
//  Hold this for later
for (
    int i = 0; //initialize or start
    i < 5;// conditional
     i++) // iteration (which for now is incrementing by 1)
{
    if (i == 3){
   Console.WriteLine(i);
    //Do the thing
    }
}


/*
int counter = 10;
do
{
    
    Console.WriteLine($"Hello {counter}");
    counter++;
}
while (counter < 5);
*/


// List T and Collections of Data
var names = new List<string> { "Mike", "Ana", "Felipe" };

names.Add("Mary");
names.Add("Maria");
names.Add("Damian");

foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}