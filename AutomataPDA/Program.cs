using AutomataPDA.Checker;
PDAChecker checker;
//GIVEN STRINGS

//given 1
var given = "racecar";
Console.WriteLine("Given: "+given);
checker = new PalindromeChecker();
Console.WriteLine("Palindrome: ");
execute(given, checker);
checker = new BracketChecker();
Console.WriteLine("Bracket: ");
execute(given,checker);

//given 2
given = "{[]}([])";
Console.WriteLine("\r\n\r\nGiven: " + given);
checker = new PalindromeChecker();
Console.WriteLine("Palindrome: ");
execute(given, checker);
checker = new BracketChecker();
Console.WriteLine("Bracket: ");
execute(given, checker);

//given 3
given = "([{}])";
Console.WriteLine("\r\n\r\nGiven: " + given);
checker = new PalindromeChecker();
Console.WriteLine("Palindrome: ");
execute(given, checker);
checker = new BracketChecker();
Console.WriteLine("Bracket: ");
execute(given, checker);

//given 4
given = "aabb";
Console.WriteLine("\r\n\r\nGiven: " + given);
checker = new PalindromeChecker();
Console.WriteLine("Palindrome: ");
execute(given, checker);
checker = new BracketChecker();
Console.WriteLine("Bracket: ");
execute(given, checker);


//USER INPUT

Console.WriteLine("\r\n\r\n\r\n----------------\r\nTry It:");
Console.WriteLine("a.) Palindrome \r\nb.) Brackets");
Console.WriteLine("Answer: ");
string? input = Console.ReadLine();
switch (input)
{
    case "a":
        Console.WriteLine("Palindrome Mode Eng Eng Eng");
        checker = new PalindromeChecker();
        break;
    case "b":
        Console.WriteLine("Bracket Mode Eng Eng Eng");
        checker = new BracketChecker();
        break;
    default:
        throw new ArgumentException();
}

Console.WriteLine("Input String(to check): ");
string? stringToCheck = Console.ReadLine();

Console.WriteLine(checker.check(stringToCheck));


void execute(string userInput, PDAChecker pdaChecker)
{
    Console.WriteLine(pdaChecker.check(userInput));
}
