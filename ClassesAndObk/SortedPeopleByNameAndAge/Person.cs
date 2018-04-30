using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    private string firstName; //fields
    private string lastName;  //fields
    private int age;          //fields
    private decimal salary;      

    public string FirstName  //property
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { firstName = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    public decimal Salary
    {
        get { return salary; }
        set { salary = value; }
    }
   // public decimal Salary { get => Salary1; set => Salary1 = value; }

    public Person(string firstName, string lastName, int age) //Constructor
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    }

    public Person(string firstName, string lastName, int age, decimal salary) : this (firstName, lastName, age)
    {
        this.salary = salary;
    }

    public void IncreaseSalary(decimal percentage)
    {
        if (age > 30)
        {
            salary = salary + salary * (percentage / 100);
        }
        else
        {
            salary = salary + salary * (percentage / 200);
        }
    }

    public override string ToString() //Method
    {
        return $"{firstName} {lastName} recieves {salary} leva on his {age} ages.";
    }
}

