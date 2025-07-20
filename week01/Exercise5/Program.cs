using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Display a welcome message
        DisplayWelcome();

        // Step 2: Ask for and get user's name
        string userName = PromptUserName();

        // Step 3: Ask for and get user's favorite number
        int userNumber = PromptUserNumber();

        // Step 4: Calculate the square of the number
        int squaredNumber = SquareNumber(userNumber);

        // Step 5: Display the result
        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        return number;
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}
