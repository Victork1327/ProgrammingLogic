using System.Net.WebSockets;

namespace Lab4;

class Program
{
    static void Main(string[] args)
    { /*For lab 4 we are focusing on loops while still building on last week. 
 The first part is a simple for-loop printing of numbers 1-10.*/
    Console.WriteLine("1-10 Ascension: ");//I will be adding lines like this for clarity
      for (int asc = 1; asc<11; asc++) 
      {
        Console.WriteLine(asc); //asc = ascending order variable 
      } /*we gave this loop guidelines knowing it would end after 10 outputs, 
 now we are going to print the even numbers 1-20.*/
      Console.WriteLine("1-20 Even Ascension: ");
        for (int evas = 1; evas < 21; evas++)
     {
       if (evas % 2 == 0)
       {
       Console.WriteLine(evas); //evas = even ascent 
       }
     }    
     //With this scenario we could have done "evas = evas + 2" but the modulus method also works 
     //we wrote the if statement to exclude the odd numbers. Now we are going to use a while loop to go from 5-1.
     Console.WriteLine("5-1 Descension: ");
     int desc = 5;
     while (desc>0)
     {
        Console.WriteLine(desc);
        desc--;
     }/*Very similar to the ascension loop except for using while. 
 Now we are going to build from last week using a console read line and a do-while loop.*/
         int hund;
        do 
        {
          Console.Write("Enter a number greater than 100: ");
            hund = Convert.ToInt32(Console.ReadLine());
        }    
            while (hund < 101);
            Console.WriteLine( hund + " is greater than 100!");//used this for clarity to show that the program ended.
            // This one was the most confusing for me but after being given an explanation I understood what I did wrong. 
        //Now we are going to write the multiples of 10 in ascending order from 10 to 1000.
           Console.WriteLine("Multiples of 10 starting from 10-1000: ");
            int mult = 10;
         while (mult<1001) 
       {
        Console.WriteLine(mult);
        mult= mult + 10;
      }//pretty similar to our other ascending loops just using "+ 10" instead of "++"
      //for the last one we need to make a triangle shape that is 10 by 10.
Console.WriteLine("Star Pattern: ");
        for (int row = 1; row<=10; row++)
{
    for (int col = 1; col<=row; col++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}/*this one was a little confusing I used a tutorial on how to make a rectangle with characters and then used 
that to help make the triangle with the logic that to make the slant the column needed to rely on the row.*/ 

    }
}
