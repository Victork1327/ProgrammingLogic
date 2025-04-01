using System.Diagnostics;

namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        /*welcome to lab 3 this week were are going over more operators, 
        boolean logic, else if staments, and switch staments. We are starting with operators*/
        int a = 10;
        int b = 5;
        int c = 15;
        Console.WriteLine("A is greater than B: " + (a>b));
        Console.WriteLine("A it less than C: " + (a<c));
        Console.WriteLine("A is greater than B and C: " + (a>b&&a>c)); 
        Console.WriteLine("A is greater than B or C: " + (a>b||a>c)); // demostrating the "logical or" operator where only of the values have to be true
        //Now we are on to boolean logic
        bool isRaining = true;
        bool haveUmbrella = false;
        if (isRaining == true && haveUmbrella == false)
        {
            Console.WriteLine("Take An Umbrella!");
        }
        else 
        { 
            Console.WriteLine("You're Good to go!");
        } /*In the code above I used an if statement to add a condition on whether to bring an umbrella.
        There was one option in which an umbrella was needed showing why I used the and operator and the
         else for every other possible outcome*/
        //next we are working more with if statements using conditional logic.
        Console.WriteLine("Enter Your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age>0 && age< 5) 
            {
                Console.WriteLine("Ticket is Free!");
            }
            else if (age >= 5 && age <= 12)
            {
                Console.WriteLine("Child Ticket:$5");
            }
            else if (age >= 13 && age <= 64)
            {
                Console.WriteLine("Standard Ticket:$10");
            }
            else if (age >= 65)
            {
                Console.WriteLine("Senior Ticket:$6");
            }
            else
            {
                Console.WriteLine("Error: Not Real Age");
            }/*in this part of the lab we had to use the read line function from last week and the if statmentsto 
            make an interface where someone puts their age and gets a ticket price out. I decided to add 
            an error statement as the else statement in case someone added a negative number*/
     //now we are doing something similar to the last part but with a switch statement this time
    Console.WriteLine("Enter The day Of The Week As A Number: ");
            int day = Convert.ToInt32(Console.ReadLine());
            switch(day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid Day!");
                break;
                /*this is the final part of the code where I used a switch statement as a way to show the days of the week 
                with each day being a case and the default being every other invalid number*/

            }
    }
}
