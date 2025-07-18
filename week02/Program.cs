using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        string letter;

        if (grade >= 90)
            letter = "A";
        else if (grade >= 80)
            letter = "B";
        else if (grade >= 70)
            letter = "C";
        else if (grade >= 60)
            letter = "D";
        else
            letter = "F";

        // Determine + or - sign (stretch)
        string sign = "";
        int lastDigit = grade % 10;

        if (letter != "A" && letter != "F")
        {
            if (lastDigit >= 7)
                sign = "+";
            else if (lastDigit < 3)
                sign = "-";
        }
        else if (letter == "A" && lastDigit < 3)
        {
            sign = "-";
        }

        Console.WriteLine($"Your grade is {letter}{sign}");

        if (grade >= 70)
            Console.WriteLine("Congratulations! You passed the course.");
        else
            Console.WriteLine("Keep trying, you can do better next time!");
    }
}




