using System;

namespace Constructor
{
    //class
    public class Person
    {
        //object
        public string name;
        public int age;

        //constructor with parameter
        public Person(string personName, int personAge)
        {
            name = personName;
            age = personAge;

            Console.WriteLine("Nikita Pradhan");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //defining class and calling
            //new Person();

            //defining class and calling constructor
            Person person1= new Person("Nikita Pradhan", 28);

            Console.WriteLine("Name: " + person1.name);
            Console.WriteLine("Age: " + person1.age);

            Console.ReadLine();
        }
    }
}
