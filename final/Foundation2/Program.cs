using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("North", "Salt", "Utah", "USA");
        Console.WriteLine(address.Get_Full_Address());
    }
}