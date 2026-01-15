using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain;
        
        // Create a loop for the user to keep playing
        do
        {
            // Generate the magic number randomly
            Random randomGenerator = new Random();
            int magicNum = randomGenerator.Next(1, 101);
            
            int counter = 0;
            double guess;
            
            do
            {
                // Ask user for their Guess
                Console.Write("What is your guess?: ");
                guess = double.Parse(Console.ReadLine());
            
                // increase counter by 1
                counter++; 
            
                // Tell the user they need to guess higher
                if (magicNum > guess)
                {
                    Console.WriteLine("Guess Higher");
                }
                // Tell the user they need to guess lower
                else if (magicNum < guess)
                {
                    Console.WriteLine("Guess Lower");
                }
            } while (magicNum != guess); 
        
            // Tell the user they have guessed the magic number
            Console.WriteLine($"You guessed it the magic number was: {magicNum}!");
            Console.WriteLine($"It took you {counter} to guess the magic number!");
        
            // Ask user if they would like to play again
            Console.Write("Would you like to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        } while (playAgain == "yes");
    }
}