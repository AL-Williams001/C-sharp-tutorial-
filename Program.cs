// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

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
// var names = new string [] { "Mike", "Ana", "Felipe" }; Array

// names.Add("John");// LIST <T> method

// names = [..names, "Damian"];
// foreach (var name in names)
// {
//     Console.WriteLine($"Hello {name.ToUpper()}!");
// }


//Sorting and Searching Lists,


var numbers = new List<int> { 46, 56, 99, 48, 67, 78};

Console.WriteLine($"I found 99 at index {numbers.IndexOf(99)}");
numbers.Sort();
Console.WriteLine($"I found 99 at index {numbers.IndexOf(99)}");
// foreach (var number in numbers)
// {
//     Console.WriteLine($"{number}");
// }


//Language Integrated Query (LINQ) - Used to query collections

//Specify the date source
List<int> scores = [3, 45, 82, 97, 92, 100,  81, 60];


//Define the query expression
// IEnumerable<int> scoreQuery =
//     from score in scores
//     where score > 80
//     orderby score descending
//     select score;

//LINQ Method Syntax
var scoreQuery = scores.Where(s => s > 80).
    OrderByDescending(s => s);
    


List<int> myScores = scoreQuery.ToList();

foreach (var score in myScores)
{
    Console.WriteLine(score);
}


//Object-orientated Programming
 Console.WriteLine("Hello, OOP!");


var p1 = new Person("Scott", "Hanselman", new DateOnly(1970, 1, 1));

var p2 = new Person("David ", "Fowler", new DateOnly(1986, 1, 1));

p1.Pets.Add(new Dog("Fredo"));
p1.Pets.Add(new Dog("Barney"));

p2.Pets.Add(new Cat("Beyonce"));


List<Person> people = [p1, p2];

foreach (var person in people)
{
    Console.WriteLine($"{person}");

    foreach(var pet in person.Pets)
    {
        Console.WriteLine($"     {pet}");
    }
}


 public class Person(string firstname, string lastname, DateOnly birthday)
{
    public string First { get; } = firstname;
    public string Last { get; } = lastname;  
    public DateOnly Birthday { get; } = birthday;

    public List<Pet> Pets { get; } = new();

    public override string ToString()
    {
        return $"Human {First} {Last}";
    }

}

public abstract class Pet(string firstname)
{
    public string First { get; } = firstname;
    public abstract  string MakeNoise();

     public override string ToString()
    {
        return $"{First} and I am a {GetType().Name} and I {MakeNoise()}";
    }
}

public class Cat (string firstname) : Pet(firstname)
{
    public override string MakeNoise() => "meow";
}

public class Dog (string firstname) : Pet(firstname)
{
    public override string MakeNoise() => "bark";
}


 

        