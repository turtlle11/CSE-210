class Order
{
    private Customer new_customer;
    private List<Product> _list_of_products;

    public Order(Customer customer)
    {
        new_customer = customer;
        _list_of_products = new List<Product>();
    }

    public List<Product> Add_New_Product(Product new_product)
    {
        _list_of_products.Add(new_product);
        return _list_of_products;
    }

    public void Display_Packiging_Lable()
    {
        foreach (Product product in _list_of_products)
        {
            Console.WriteLine(product.Product_Display());
        }
    }

    public string Display_Shipping_Label()
    {
        return $"Customer name: {new_customer.Get_Name()}\nCustomer address: {new_customer.Get_Address().Get_Full_Address()}";
    }
    public void Display_Total_Price()
    {
        int total_price = 0;
        foreach (Product product in _list_of_products)
        {
            total_price += product.Cost_of_Product();
        }

        if(new_customer.Is_Local() is true)
        {
            total_price += 5;
            Console.WriteLine($"Price for your order: {total_price}");
        }
        else 
        {
            total_price += 35;
            Console.WriteLine($"Price for your order: {total_price}");
        }

    }
}