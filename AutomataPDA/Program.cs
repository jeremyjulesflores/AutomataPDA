using AutomataPDA.Checker;

Console.WriteLine("a.) Palindrome \r\nb.) Brackets");
Console.WriteLine("Answer: ");
string? input = Console.ReadLine();
PDAChecker checker;
Console.WriteLine("Input String(to check): ");
string? stringToCheck = Console.ReadLine();

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

Console.WriteLine(checker.check(stringToCheck));
