using System;

class Program
{
    static void Main(string[] args)
    {
        Order order_1 = new Order(new Customer("Misha", new Address("North Street", "Salt Lake ", "Utah", "USA")));
        Product item_1_1 = new Product("Bread","4567", 5, 2);
        order_1.Add_New_Product(item_1_1);
        Product item_1_2 = new Product("Eggs","1234", 3, 1);
        order_1.Add_New_Product(item_1_2);

        Console.WriteLine("Packeging label:");
        order_1.Display_Packiging_Lable();

    }
}