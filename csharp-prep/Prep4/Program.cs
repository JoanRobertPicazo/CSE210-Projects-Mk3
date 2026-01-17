using System;
using System.Collections.Generic; // For list
using System.Linq; // Average


class Program
{
    static void Main(string[] args)
    {
        List<double> numbers = new List<double>();
        double number;
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        do
        {
            Console.Write("Enter a number (0 to quit): ");
            number = double.Parse(Console.ReadLine());

            // Only add numbers to the list that are not 0
            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);

        // Sum the list of numbers
        double sum = 0;
        foreach(double num in numbers)
        {
            sum += num; // Loop through numbers and adds them
        }
        
        // Display sum
        Console.WriteLine($"The sum of the numbers is: {sum}");
        
        // Display the average
        double average = sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        
        // Calculate the largest number
        double largest = numbers[0];
        foreach (double num in numbers)
        {
            if (num > largest)
            {
                largest = num;
            }
        }
        // Display the largest number
        Console.WriteLine($"The largest: {largest}");
        
        // Display the smallest positive number
        double smallestPositive = numbers[0];
        foreach (double num in numbers)
        {
            if (num > 0 && num < smallestPositive)
            {
                smallestPositive = num;
            }    
        }
        
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        
        // Display the sorted list
        numbers.Sort();
        Console.WriteLine($"The sorted list is:");
        
        foreach (double num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}