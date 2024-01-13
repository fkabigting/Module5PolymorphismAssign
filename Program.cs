using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Define the IQuittable interface
public interface IQuittable
{
    void Quit();
}

// Create a Person class with properties FirstName and LastName
public class Person
{
    public string FName { get; set; }
    public string LName { get; set; }

    // Void method SayName to display the person's full name
    public void SayName()
    {
        Console.WriteLine($"Name: {LName} {FName}");
    }
}

// Create an Employee class that inherits from the Person class and implements IQuittable
public class Employee : Person, IQuittable
{
    // Add an additional property Id of data type int
    public int Id { get; set; }

    // Implement the Quit method defined in the IQuittable interface
    public void Quit()
    {
        Console.WriteLine($"The employee: {LName}, {FName} with ID {Id} has submitted a resignation letter effective immediately.");
    }
}

// Below is the main program 
class Program
{
    static void Main()
    {
        // Instantiate an Employee object and assign values to properties
        Employee employee = new Employee
        {
            FName = "Francis",
            LName = "Kabigting",
            Id = 123
        };

        // Below calls the quit method
        IQuittable quittableEmployee = employee; // Implicitly cast Employee to IQuittable
        quittableEmployee.Quit();
    }
}
