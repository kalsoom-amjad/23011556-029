using System;



    public class EVENODD
    {
        
    public void EvenOdd()       
    {
            Console.WriteLine("Enter a number to check if it is even or odd:");
            
            //used to convert string data into int type as Console.ReadLine() takes input in string format
            
            int num = Convert.ToInt32(Console.ReadLine());
            
            //checks weather the number inupt isd odd or even using remainder operator
            if (num % 2 != 0)
            {
                Console.WriteLine(num + " is an odd number.");

            }
            else
             {
                    Console.WriteLine(num + " is an even number.");
             }
        } 
    }

