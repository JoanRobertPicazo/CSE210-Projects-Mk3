namespace Sandbox;

public class Person
{
    // get allows you to retrieve, and set allows you to change the value
    public string Name  { get; set; } 
    public int Age  { get; set; }
    public bool HasPet  { get; set; }

    // Constructor 
    public Person(string name, int age, bool hasPet)
    {
        Name = name;
        Age = age;
        HasPet = hasPet;
    }
    public void Greeting()
    {
        Console.WriteLine($"Hi my name is {Name} and my age is {Age} and it is {HasPet} that I have a pet");
    }
}