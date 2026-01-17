using System;

class Program
{
    static void Main(string[] args)
    {
        // Call DisplayWelcome Function
        DisplayWelcome();
        
        // Call PromptUserName Function
        string name = PromptUserName();
        
        // Call PromptUserNumber Function
        int number = PromptUserNumber();

        // Call PromtUserBirthYear Function
        int birthYear;
        PromtUserBirthYear(out birthYear);

        // Call SquareNumber Function
        int square = SquareNumber(number);

        // Call DisplayResult Function
        DisplayResult(name, square, birthYear);
    }
    
    // DisplayWelcome Function - Displays the message, "Welcome to the Program!"
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    
    // PromptUserName Function - Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
    // PromptUserNumber Function - Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber()
    {
        Console.Write("Please enter you favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    
    // PromtUserBirthYear Function - out integer as a parameter and prompts the user for the year they were born
    static int PromtUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());
        return birthYear;
    }

    // SquareNumber Function - Accepts an integer as a parameter and returns that number squared (as an integer)
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    
    /* DisplayResult Function - Accepts the user's name, the squared number, and the user's birth year. Display the user's
     name and a squared number. Calculate how many years old they will be this year and display that.*/
    static void DisplayResult(string name, int square, int birthYear)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
        Console.WriteLine($"{name} you will turn {2026 - birthYear} this year");
    }
    
}