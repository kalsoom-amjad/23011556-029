using System;

    public class MINMAX
    {
     public void array()
    {
        
            int[] numbers = new int[10];
            // take an array of 10 inout by user
            Console.WriteLine("Enter 10 integers:");
            //iterate using for loop for finding minimum and maximum
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int max = numbers[0];
            int min = numbers[0];
           //comparsion loop 
            foreach (int num in numbers)
            {
                if (num > max)
                    max = num;
                if (num < min)
                    min = num;
            }

            Console.WriteLine($"\nMaximum value: {max}");
            Console.WriteLine($"Minimum value: {min}");
        }
    }

