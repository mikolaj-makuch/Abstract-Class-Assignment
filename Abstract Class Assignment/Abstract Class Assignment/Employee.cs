using System;

namespace Abstract_Class_Assignment
{
    //Create another class, "Employee" and have it inherit from the Perosn class 
    public class Employee : Person
    {
        public int ID { get; set; }
        //Implement the SayName() method inside of the Employee class
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}
