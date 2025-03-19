using System;

  class Program
  {
    static void Main(string[] args)
    {
      // Step 1
      Console.WriteLine("Victor Karapunarly IT1050");
      /* This is a multi line comment used to show my name and course
      Victor Karapunarly IT1050*/
      /*For the next step, I have declared a couple of different variables my favorite number is 17 from soccer. Python is the only language I have learned in which I wrote my code. 
 I've only developed one complete program attributing to the decimal answer and I don't think I have done enough with programming to say I have experience.*/ 
      int favnum = 17;
      string favprog = "Python";
      double prognum = 1.5;
      bool progxp = false;
      // Now were are going to display all the variables with their background 
      Console.WriteLine("My favorite number is " + favnum);
      Console.WriteLine("The program I use and like the most is " + favprog);
      Console.WriteLine("Due to my unfinished projects I have made " +  prognum + " programs" );
      Console.WriteLine("Due to my little work in all the languages, I would say my programming experience is " +  progxp);
      //Now we are going to declare a constant for our school name and display it.
      const string schlname = "Cuyahoga Community College";
      Console.WriteLine("I go to " +  schlname);
      /*Our last step before publish is to look back and make sure the names or indentifies i gave 
      the variables are specific but simple enough to discern without confusion*/
    }
  }
