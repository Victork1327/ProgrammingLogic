namespace Lab8;
class Animal//creating the base/parent class
{
    public virtual void animalSound()//adding virtual so that the child classes can override 
    {
        Console.WriteLine("The animal makes a sound");//output for animal object
    }
}
class Cat : Animal //semicolon for inheritance/creation of child class
{
    public override void animalSound()//overriding the method so that a different output can be used  
    {
        Console.WriteLine("The cat says: meow");//child class/cat output
    }
}
class Dog : Animal //another child class except its "dog" instead of cat.
{
    public override void animalSound()//again another use of the overide modifier to recieve a diffrent output from the parent class
    {
        Console.WriteLine("The dog says: bow wow"); //dog output
    }
}
class Program
{
    static void Main(string[] args)//main class
    {
        Animal myAnimal = new Animal();//creating objects for every class 
        Animal myCat = new Cat();// referencing the parent class
        Animal myDog = new Dog();

        myAnimal.animalSound();// calling the sound method for all the objects now
        myCat.animalSound();// all of theese will output the given "console.writeline" from the respective class.
        myDog.animalSound();
    }
}
