using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Phone", "P001", 500, 2);
        Product product2 = new Product("Laptop", "P002", 1000, 1);

        Address address = new Address("123 Main St", "City", "State", "USA");
        Customer customer = new Customer("John Doe", address);

        Order order = new Order(new List<Product> { product1, product2 }, customer);

        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order.GetTotalPrice());
    }
}