using System;

    internal class FACTORIAL
    {
    public void factorial()
    {
        Console.WriteLine("Enter the number you want factorial of:  ");
        int n = Convert.ToInt32(Console.ReadLine());

        //intialize a data with 1 to calculate factorial witrh 1 because of multiplication identity 
        int fact = 1;

        //intialize a data with 1 to use in while loop
        int i = 1;

        //using while loop to calculate factorial
        while (i <= n)
        {

            //calculation of factoiral
            fact = fact * i;
            i++;
        }
    }
    }

