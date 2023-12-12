// Name: Elizabeth Trotter

// Date Revised: 9/12/2023

// Exercise: Mini Challenge # 5 - Mad Lib

// Brief Description: You will be creating your own unique mad lib generator in a console project.
// Your console application needs tp have the following:
// Have 10 fields to enter before you generate the story
// Once you enter in all the pieces, you need to output the story with what was entered.
// Ask the user if they want to play again or not.

// Peer Reviewer: Alexander Soria
// Peer Comments: The mad libs work very well, and the game replays correctly when prompted.

Console.Clear();

string title = "Mini Challenge # 5 - Mad Lib";
Console.WriteLine(title);
string breakPoint = "------------------------------";
Console.WriteLine(breakPoint);

Console.WriteLine("Welcome! Today, we will play a game that involes you choosing various types of words that will be used in a story.");
Console.WriteLine("Instructions: Type a word that falls within the type of category requested. Then, press enter to view the next required input.");
Console.WriteLine(breakPoint);

string playAgain = "yes";

while(playAgain != "NO")
{
// Field 1
Console.Write("Noun: ");
string noun1 = Console.ReadLine() ?? "";

// Field 2
Console.Write("Holiday: ");
string holiday1 = Console.ReadLine() ?? "";

// Field 3
Console.Write("Pronoun (She/He/They/Ze): ");
string pronoun1 = Console.ReadLine() ?? "";

// Field 4
Console.Write("Type of Animal: ");
string animal1 = Console.ReadLine()  ?? "";

// Field 5
Console.Write("Exclamation Word: ");
string exclamation1 = Console.ReadLine()  ?? "";

// Field 6
Console.Write("Color: ");
string color1 = Console.ReadLine()  ?? "";

// Field 7
Console.Write("Noun: ");
string noun2 = Console.ReadLine()  ?? "";

// Field 8
Console.Write("Verb (ending with -ing): ");
string verb1 = Console.ReadLine()  ?? "";

// Field 9
Console.Write("Blunt Object: ");
string object1 = Console.ReadLine()  ?? "";

// Field 10
Console.Write("Number (between 1 - 1000): ");
string hours1 = Console.ReadLine()  ?? "";
Console.WriteLine(breakPoint);

// Story Generator
Console.WriteLine($"A {noun1} ran down the street to get to the work {holiday1} party. {pronoun1} tripped over a {animal1} and screamed, {exclamation1}! ");
Console.WriteLine($"A {color1} {noun2} rushed over to help, but ended up {verb1} the {noun1} with a {object1}. The {noun1} made it to the party {hours1} hours late.");
Console.WriteLine(breakPoint);

// Ask to play again
Console.Write("Do you want to play again? (Enter YES or NO): ");
playAgain = Console.ReadLine()?.ToUpper()  ?? "YES";

//Console.WriteLine(playAgain);
}

Console.WriteLine("Thank you for playing!");
Console.WriteLine(breakPoint);