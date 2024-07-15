class Product
{
    private string _name_of_product;
    private string _product_ID;
    private int _price_per_unit;
    private int _quantity_of_each;

    public Product(string product_name, string ID_of_product, int price, int quantity)
    {
        _name_of_product = product_name;
        _product_ID = ID_of_product;
        _price_per_unit = price;
        _quantity_of_each = quantity;
    }

    public int Cost_of_Product()
    {
        return _price_per_unit*_quantity_of_each;
    }
    public string Product_Display()
    {
        return $"Item: {_name_of_product}, ID: {_product_ID}";
    }

}