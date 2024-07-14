class Order
{
    private Customer new_costomer;
    private List<Product> _order;

    public Order()
    {
          new_costomer = new Customer("");
          _order = new List<Product>();
    }

    public List<Product> Add_New_Product(Product new_product)
    {
        _order.Add(new_product);
        return _order;
    }
}