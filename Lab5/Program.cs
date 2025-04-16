namespace Lab5;

class Program
{
    static void Main(string[] args)
    {//now we are onto lab 5 focusing on arrays.
        string[] seasons = {"Spring", "Summer", "Fall", "Winter"};
        foreach (string season in seasons)
        {
            Console.WriteLine("Season: " + season);
        }/*pretty simple there are many ways in declaring and intalizating arrays 
        I like this way the most as its clear to me. Now we add a user input elemnt for days of the week*/
        string[] days = {"Monday","Tuesday","Wednesday","Thursday","Friday", "Saturday","Sunday"};
        int usrnm;   
        do{
            Console.Write("Enter a number (1-7): ");
         usrnm = Convert.ToInt32(Console.ReadLine());
        } while (usrnm <=0 || usrnm >7);//Make sure to use an or stament so that function correctly loops.
         Console.WriteLine("That day is: " + days[usrnm-1]);//usrnm = user number
         //now we will combine two strings to create an output that has books and their respective authors.
         string[] Books = {"The Hunger Games", "UnOrdinary", "Animal Farm"};//I enjoyed animal farm so I
         string[] Authors = {"Suzanne Collins", "Chelsea Han", "George Orwell"};// will keep George Orwell as one of my authors. 
         for (int i = 0; i<Books.Length; i++){ 
            Console.WriteLine($"Book {i+1}: {Books[i]} by {Authors[i]}");//I kept seeing the "$"symbol during my resarch 
            // and couldnt remember if we reviewed it or not, either way I learned it was for interpolated strings so I 
            // decided to use it and it made my coding a lot easier.
            /* now onto sorting*/
         }
            int[] temps = { 65, 72, 78, 70, 68 };
            Array.Sort(temps);
            Console.Write("Sorted Temperatures:");
            for (int Sorttemp=0; Sorttemp<temps.Length; Sorttemp++){//sorttemp=sorted temeratures.
                Console.Write(temps[Sorttemp] +" "); 
         }
          Console.WriteLine(" "); //Used this to seperate the sorted temps and higest temp to like cleaner on the output.
         Console.WriteLine("Highest Temperature: " + temps[4]);
         Console.WriteLine("Lowest Temperature: " + temps[0]);
         int[] CountDown = {5, 4, 3, 2, 1,};
         Array.Reverse(CountDown);//reversed the order so now its 1-5
        Console.Write("Countdown:");
         for (int CountUp=0; CountUp<temps.Length; CountUp++){
                Console.Write(CountDown[CountUp] +" "); 
    }
    }
}
