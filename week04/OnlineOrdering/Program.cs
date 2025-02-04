using System;

class Program
{
    static void Main(string[] args)
    {
        // Create customer addresses
        Address address1 = new Address("111 Main St", "Winnipeg", "MB", "USA");
        Address address2 = new Address("456 Maple Ave", "London", "ONT", "Canada");

        // Create customers
        Customer customer1 = new Customer("Glenn Soriano", address1);
        Customer customer2 = new Customer("Mary Soriano", address2);

        // Create products
        Product product1 = new Product("Laptop", "P123", 999.99, 1);
        Product product2 = new Product("Headphones", "P456", 249.99, 2);
        Product product3 = new Product("Smartphone", "P789", 799.99, 1);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);

        // Display Order 1 details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalPrice():0.00}\n");

        // Display Order 2 details
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalPrice():0.00}");
    }
}
