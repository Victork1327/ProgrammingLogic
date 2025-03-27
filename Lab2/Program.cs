using System;

  class Program
  {
    static void Main(string[] args)
    {
            /*This is the second lab of the semester. For this lab we will contunie with variable 
            declaration and adding more function like converting, userinput, and operations*/
            //first Im going to declare varaibles of 6 data types   
            int myNum = 8;
            double myDec = 3.64d;
            float myFlo = 2.12f;
            char myLtr = 'A';
            bool myNo = false;
            string Greet = "Hey Everyone!";
            // now we are going to print all of the variables to the console 
            Console.WriteLine(Greet);
            Console.WriteLine("Here are some numbers I wanted to declare " + myNum);
            Console.WriteLine(myDec);
            Console.WriteLine(myFlo);
            Console.WriteLine("here is my letter " + myLtr);
            Console.WriteLine("Finally is my true/false statment, which is " + myNo);
            /* now we are going to part 2 which is type casting. I'm going to create a diffrent double
            variable and convert it to int with explicit casting */
            double dubValue = 9.78d;
            int DtoI = (int)dubValue;
            //Now were going to convert a bool and a int to a string using convert class.
            int IntToStr = 10;
            bool BooltoStr = true;
            Convert.ToString(IntToStr);
            Convert.ToString(BooltoStr);
            //We will print all of our conversions 
            Console.WriteLine("Double: " + dubValue);
            Console.WriteLine("Double to Interger conversion: " + DtoI);
            Console.WriteLine("Integer to String: " + IntToStr);
            Console.WriteLine("Bool to String: " + BooltoStr);
            //now we are going to add user input to the mix asking for the name and age
            Console.WriteLine("Enter Your First Name: ");
            string FirstName = Console.ReadLine()!;
            Console.WriteLine("Enter Your Current Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hello " + FirstName + " you are " + age);
            Console.WriteLine(" years old.");
            //After the input we are going to show the diffrent types of operations by using two variables 
            int num1 = 8;
            int num2 = 4;
            int sum1 = num1 + 10;
            int sum2 = num2 + 10;
            int diff1 = num1 - 2;
            int diff2 = num2 - 2;
            int prod1 = num1 * 3;
            int prod2 = num2 * 3;
            int quo1 = num1 / 2;
            int quo2 = num2 / 2;
            int mod1 = num1 % 2;
            int mod2 = num2 % 2;
            //after defining all of our operations I will print the result and explain each one
            Console.WriteLine("Sum of 8 and 10 is " + sum1);
            Console.WriteLine("Sum of 4 and 10 is " + sum2);
            Console.WriteLine("Diffrence of 8 and 2 is " + diff1);
            Console.WriteLine("Diffrence of 4 and 2 is " + diff2);
            Console.WriteLine("Product of 8 and 3 is " + prod1);
            Console.WriteLine("Product of 4 and 3 is " + prod2);
            Console.WriteLine("Quotient of 8 and 2 is " + quo1);
            Console.WriteLine("Quotient of 4 and 2 is " + quo2);
            Console.WriteLine("Modulus of 8 and 2 is " + mod1);
            Console.WriteLine("Modulus of 4 and 2 is " + mod1);
            //Now we on to floating point persecion seeing the difference of double and float 
            double doubper = 1.123456789d;
            float floatper = 1.123456789f; 
            Console.WriteLine(doubper); //i chose per at the end to signify percise
            Console.WriteLine(floatper);
            /*after running the code and seeing the outputs, I observed that the double 
            was able to output the entire number while to float only out put up the decimal place with 8*/
        //now we are on the last step in shich we will show increment and decrement.
        int NumTen = 10;
        NumTen++;
        Console.WriteLine("10 incremnted by 1 is " + NumTen);
        NumTen--;
        Console.WriteLine("10 decremnted by 1 after being incremeented by 1 is " + NumTen);
    }
  }

 