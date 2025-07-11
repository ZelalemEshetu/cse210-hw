using System;

class Program
{
    static void Main(string[] args)
    {
        //ask for first name
        Console.Write("What is your first name?");
        string firstName = Console.ReadLine();

        //ask for last name
        Console.Write("What is your last name?");
        string lastName = Console.ReadLine();

        //output in the correct format
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}