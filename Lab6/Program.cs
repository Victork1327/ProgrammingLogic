using System;

class Car
{
  public string? model;//added the "?" to get rid of the warning and make it nullable 
  public string? color;
  
  public int year;
  public void Start(){
    Console.WriteLine("The car is starting."); //creating a start method to later be used
}
  public void Drive(int x){
Console.WriteLine($"The car drove {x} miles.");
  }//making a method with a parameter so that we can interchange the variable 
  public string GetDescription(){
    return $"{year} {color} {model}";//using a method to have one clear description line that could be stored on its own
  }
 public void Repaint(string newColor){
    color = newColor;
    Console.WriteLine($"The car has been repainted to {color}");
 }
  
  public void Display()
  {
    Console.WriteLine("Car Details:");
    Console.WriteLine("Model: " + model);
    Console.WriteLine("Color: " + color);
    Console.WriteLine("Year: " + year);
  }
}

class Program
{
  static void Main()
  {
    // Creating a Car object and assigning values to its properties
    Car myCar = new Car();
    myCar.model = "Civic";
    myCar.color = "Black";
    myCar.year = 2020;

    myCar.Display(); // Calling the Display method
    myCar.Start();//implementing a start method 
    myCar.Drive(50);
    string desc = myCar.GetDescription();//storing the method as a voriable that can be used later on
   Console.WriteLine(desc);
   myCar.Repaint("Red");//using the method to choose a color red now 
   Console.WriteLine(myCar.color);//showing how the color field has been updated

  }
}