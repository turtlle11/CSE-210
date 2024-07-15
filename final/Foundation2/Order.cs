class Order
{
    private Customer new_costomer;
    private List<Product> _list_of_products;

    public Order(Customer customer)
    {
        new_costomer = customer;
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
        return $"Customer name: {new_costomer.Get_Name()}\nCustomer address: {new_costomer.Get_Address()}";
    }
}