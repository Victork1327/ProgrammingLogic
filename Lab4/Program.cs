using System.Net.WebSockets;

namespace Lab4;

class Program
{
    static void Main(string[] args)
    { //For lab 4 we are focusing on loops while still building on last week. 
    // The first part is a simple for loop printing numbers 1-10.
    Console.WriteLine("1-10 Ascension: ");//I will be adding lines like this for clarity
      for (int asc = 1; asc<11; asc++) 
      {
        Console.WriteLine(asc); //asc = ascending order variable 
      } /*we gave this loop guidlines knowing it would end after 10 outputs, 
      now we are going to print the even numbers 1-20.*/
      Console.WriteLine("1-20 Even Ascension: ");
        for (int evas = 1; evas < 21; evas++)
     {
       if (evas % 2 == 0)
       {
       Console.WriteLine(evas); //evas = even ascent 
       }
     }    
     //With this scenario we could have done "evas = evas + 2" but the modulous method also works 
     //we wrote the if stament to exclude the odd numbers. Now we are going to use a while loop to go from 5-1.
     Console.WriteLine("5-1 Descension: ");
     int desc = 5;
     while (desc>0)
     {
        Console.WriteLine(desc);
        desc--;
     }/*very similair to the ascencion loop except using while. 
     Now we are going to build from last week using console read line and a do while loop.*/
         /* Console.WriteLine("Enter A Number Greater Than 100: ");
            int hund = Convert.ToInt32(Console.ReadLine()); */
          /*int hund;
          do  
            {
            Console.WriteLine("Enter A Number Greater Than 100: ");
            int hund = Convert.ToInt32(Console.ReadLine());
            }
            while (hund != hund);
            Console.WriteLine("Succes, Number is greater than 100!"); 8*/
           Console.WriteLine("Multiples of 10 starting from 10-1000: ");
            int mult = 10;
     while (mult<1001)
     {
        Console.WriteLine(mult);
        mult= mult + 10;
     }
Console.WriteLine("Star Pattern: ");
        for (int row = 1; row<=10; row++)
{
    for (int col = 1; col<=row; col++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

    }
}
