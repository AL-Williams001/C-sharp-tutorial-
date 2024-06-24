// See https://aka.ms/new-console-template for more information
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

