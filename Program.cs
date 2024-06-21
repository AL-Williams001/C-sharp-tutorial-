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


