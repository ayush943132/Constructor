using System;
class Customer
{
    string firstname;
    string lastname;

    public Customer()
        : this("#Pascal", "Case")
        {
        }

    //This is a Constructor used to initialize our class fields (i.e. Customer class)
    public Customer(string FirstName, string LastName)
    {
        this.firstname = FirstName;
        this.lastname =  LastName;
    }
    public void PrintfullName()//method to print our customer name 
    {
        Console.WriteLine("The full name is {0}", firstname + " " + lastname);
    }

    internal void PrintfullName(string v1, string v2)
    {
        throw new NotImplementedException();
    }
}

class Constructor
{
    public static void Main()
    {
        Customer C1 = new Customer();
        C1.PrintfullName();// method call 

        Customer C2 = new Customer("A","k");//constructor overloading 
        C2.PrintfullName();
    }
}