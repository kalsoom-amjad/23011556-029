using System;


    public class SUM_OF_N
    {
     public void sum()
    {
        Console.WriteLine("Enter a positive integer:");
        int n = Convert.ToInt32(Console.ReadLine());
        ;
        //check wether input is valid
        if (n > 0)
        {

            //intialize a variable sum in which added value to be stored for display
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {

                sum += i;
            }
            Console.Write(sum);
        }

        else
        {
            Console.WriteLine("Invalid input! Please enter a positive integer.");
        }
    }
}
  
