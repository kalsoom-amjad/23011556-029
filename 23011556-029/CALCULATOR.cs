using System;


    public class CALCULATOR
    {
    public void calculator()
    {

        Console.WriteLine("Enter any two number on which you want to perform calculation: ");

        //entery of 2 numbers and conversion
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        // now menu  driven prgram so user can choose operation
        Console.WriteLine("Enter your choice from below list: ");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        //user choice
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:

                //for addition  
                Console.WriteLine("Addition of " + num1 + " and  " + num2 + " is: " + (num1 + num2));
                break;
            case 2:

                //for substraction
                Console.WriteLine("Substraction  of " + num1 + "  and  " + num2 + " is: " + (num1 - num2));
                break;
            case 3:

                //for multiplication
                Console.WriteLine("Multiplication of " + num1 + "  and  " + num2 + " is:   " + (num1 * num2));
                break;
            case 4:

                //for division
                Console.WriteLine("Division of " + num1 + "  and  " + num2 + " is: " + (num1 / num2));
                break;
            default:

                //if user enter invalid choice
                Console.WriteLine("Invalid input, please enter valid choice");
                break;
        }
        Console.ReadLine();
    }
}

