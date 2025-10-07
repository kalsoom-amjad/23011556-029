using System;

    public class MULTILPICATION_TABLE
    { public void table(){
        Console.WriteLine("ENTER THE NUMBER YOU WANT TABLE OF");

        //converson into int type data
        int n = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Multiplication_Table of" + " " + n + " is: ");
        Console.WriteLine("-----------------------------------------");
        //loop to display table of n input by user

        for (int i = 0; i <= 10; i++)
        {

            //multiplication 
            int m = i * n;

            //for display 
            Console.WriteLine(n + " * " + " " + i + "  = " + m);
        }
    }
}

