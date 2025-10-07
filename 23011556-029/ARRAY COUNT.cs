using System;

    public class ARRAY_COUNT
    {
      public void evenodd()
    { 
            // Declare an array to hold 10 integers
            int[] numbers = new int[10];

            // Counters for even and odd numbers
            int evenCount = 0;
            int oddCount = 0;

            Console.WriteLine("Enter 10 integers:");

            // Loop to take input from the user
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // Loop through the array to count even and odd numbers
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    // If number is divisible by 2, it's even
                    evenCount++;
                }
                else
                {
                    // Otherwise, it's odd
                    oddCount++;
                }
            }

            // Display the results
            Console.WriteLine($"\nTotal even numbers: {evenCount}");
            Console.WriteLine($"Total odd numbers: {oddCount}");
        }
    }

    
