using System;

class Program
{
    static void Main(string[] args)
    {
        // Create 6 products
        Product securityCamera = new Product("SentryCam Pro", "SC1001", 149.99, 1);
        Product headphones = new Product("QuietBeats Pro", "QB2001", 199.99, 1);
        Product powerBank = new Product("Portable Solar Power Bank", "SCP3001", 49.99, 2);
        Product blender = new Product("BlendMaster 5000", "BM5001", 99.99, 1);
        Product fitnessTracker = new Product("FitTrack Pro", "FTP6001", 79.99, 1);

        // Create 2 customers
        Customer johnSmith = new Customer("John Smith", "123 Oak Street", "Springfield", "IL", "United States");
        Customer emmaJohnson = new Customer("Emma Johnson", "456 Maple Avenue", "Toronto", "ON", "Canada");

        // Create 2 orders
        Order order1 = new Order(johnSmith);
        order1.AddProduct(securityCamera);
        order1.AddProduct(headphones);
        order1.AddProduct(powerBank);

        Order order2 = new Order(emmaJohnson);
        order2.AddProduct(blender);
        order2.AddProduct(fitnessTracker);
        order2.AddProduct(headphones);

        // Display packing label, shipping label, and the total price
        Console.WriteLine("Order 1:\n");
        Console.WriteLine("Packing Label:");
        Console.WriteLine($"{order1.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label:");
        Console.WriteLine($"{order1.GetShippingLabel()}\n");
        Console.WriteLine($"Total Price:");
        Console.WriteLine($"{order1.CalculateTotalCost()}\n");

        Console.WriteLine("Order 2:\n");
        Console.WriteLine("Packing Label:");
        Console.WriteLine($"{order2.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label:");
        Console.WriteLine($"{order2.GetShippingLabel()}\n");
        Console.WriteLine($"Total Price:");
        Console.WriteLine($"{order2.CalculateTotalCost()}");
    }
}