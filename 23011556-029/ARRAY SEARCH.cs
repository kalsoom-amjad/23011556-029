using System;

 public class ARRAY_SEARCH

    {
    public void search()
    {
                   // Declare an array of integers with 10 elements
            int[] numbers = new int[10];

            Console.WriteLine("Enter 10 integers:");

            // Take input from the user to fill the array
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // Ask the user for the number to search
            Console.Write("\nEnter a number to search in the array: ");
            int searchNumber = int.Parse(Console.ReadLine());

            // Flag to track if the number is found
            bool found = false;

            // Perform linear search
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == searchNumber)
                {
                    found = true;
                    break; // Exit loop once found
                }
            }

            // Display result
            if (found)
            {
                Console.WriteLine($"Yes, {searchNumber} exists in the array.");
            }
            else
            {
                Console.WriteLine($"No, {searchNumber} does not exist in the array.");
            }
        }
    }
}
    }
}
