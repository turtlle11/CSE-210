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

        Console.WriteLine("\nShipping label:");
        Console.WriteLine(order_1.Display_Shipping_Label());
        order_1.Display_Total_Price();

        Order order_2 = new Order(new Customer("Dima", new Address("3 Blin", "Massy", "Paris", "France")));
        Product item_2_1 = new Product("Milk","3628", 4, 5);
        order_2.Add_New_Product(item_2_1);
        Product item_2_2 = new Product("Ice-cream","2943", 7, 10);
        order_2.Add_New_Product(item_2_2);

        Console.WriteLine("\nPackeging label:");
        order_2.Display_Packiging_Lable();

        Console.WriteLine("\nShipping label:");
        Console.WriteLine(order_2.Display_Shipping_Label());
        order_2.Display_Total_Price();
    }
}