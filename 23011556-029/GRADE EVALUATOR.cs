using System;


public class GRADE_EVALUATOR
{
    public void grade()
    {
        Console.WriteLine("Enter your marks from  (0-100):");

        //input and conversion
        int marks = Convert.ToInt32(Console.ReadLine());

        if (marks >= 85 && marks <= 100)
        {
            Console.WriteLine("Your grade is A");
        }

        //conditional statement for grade B
        else if (marks < 85 && marks >= 70)
        {
            Console.WriteLine("Your grade is B");
        }

        //conditional statement for grade C
        else if (marks < 69 && marks >= 55)
        {
            Console.WriteLine("Your grade is C");
        }

        //conditional statement for grade D
        else if (marks < 54 && marks >= 40)
        {
            Console.WriteLine("Your grade is D");
        }

        //conditional statement for grade F
        else if (marks < 39 && marks >= 0)
        {
            Console.WriteLine("Your grade is F");
        }

        //EXCEPTION HANDLING
        else
        {
            Console.WriteLine("Invalid input, please enter marks between 0-100");
        }
    }

}

