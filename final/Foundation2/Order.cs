class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(List<Product> products, Customer customer)
    {
        this.products = products;
        this.customer = customer;
    }

    public decimal GetTotalPrice()
    {
        decimal totalPrice = 0;
        foreach (Product product in products)
        {
            totalPrice += product.GetPrice();
        }
        totalPrice += customer.GetShippingCost();
        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in products)
        {
            packingLabel += $"{product.GetName()} - {product.GetProductId()}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return "Shipping Label:\n" + customer.GetAddress().ToString();
    }
}