using System;

class Program
{
    static void Main(string[] args)
    {
         // Create addresses
        Address address1 = new Address("654 Main Str", "Princeville", "CA", "USA");
        Address address2 = new Address("321 Balt Str", "Queensville", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("Eze Solomon Nwaka", address1);
        Customer customer2 = new Customer("Chiebere Solomon", address2);

        // Create products
        Product product1 = new Product("Product A", "A133", 21.99, 5);
        Product product2 = new Product("Product B", "B471", 7.92, 8);
        Product product3 = new Product("Product C", "C183", 4.39, 3);
        Product product4 = new Product("Product D", "D069", 9.22, 1);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product1);

        // Display order information
        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.GetTotalPrice());

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.GetTotalPrice());

    }
}