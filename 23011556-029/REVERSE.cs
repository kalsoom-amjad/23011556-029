using System;

    internal class REVERSE
    {
    public void reverse()
    { 
            Console.WriteLine("enter a value for reverse ");
            int n = int.Parse(Console.ReadLine());

    //while loop method to reverse a number

    int rev = 0;
            //rev to store the reversed number

            while (n > 0)
            {
                int getnum = n % 10;
    //for getting the last digit of the number

    rev = rev* 10 + getnum;
                //multiply rev by 10 and add the last digit to it to  get the reversed number

                n = n / 10; 
                //remove the extra last 0 from the number 

            }
Console.WriteLine("the reversed number is " + rev);
            //to display the reversed number

        }
    }
    

