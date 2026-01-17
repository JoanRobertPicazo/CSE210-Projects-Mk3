using System;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("John", 20, true);
            Person person2 = new Person("Jane", 18, false);
            
            // Run method
            person1.Greeting();
            person2.Greeting();
            
        }
    }
}