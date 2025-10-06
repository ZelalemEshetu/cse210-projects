using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("32 Oxford Rd", "London", "", "UK");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Sarah Lee", address2);

        // Create products
        Product product1 = new Product("Keyboard", "P001", 50, 2);
        Product product2 = new Product("Mouse", "P002", 20, 1);
        Product product3 = new Product("USB Cable", "P003", 10, 3);
        Product product4 = new Product("Monitor", "P004", 120, 2);

        // Create first order
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        // Create second order
        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Display order 1
        Console.WriteLine("=== Order 1 ===");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():0.00}\n");

        // Display order 2
        Console.WriteLine("=== Order 2 ===");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():0.00}");
    }
}
