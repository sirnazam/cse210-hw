
using System;

namespace Sirnazam
{
    class Program
    {
        static void Main(string[] args)
        {
            // FIRST CUSTOMER
            Address address1 = new Address(
                "15 Admiralty Way",
                "Lekki",
                "Lagos",
                "Nigeria"
            );

            Customer customer1 = new Customer(
                "Joseph Kelvin",
                address1
            );

            Product product1 = new Product(
                "Laptop",
                "P001",
                750,
                1
            );

            Product product2 = new Product(
                "Wireless Mouse",
                "P002",
                25,
                2
            );

            Order order1 = new Order(customer1);

            order1.AddProduct(product1);
            order1.AddProduct(product2);


            Address address2 = new Address(
                "25 Main Street",
                "New York",
                "New York",
                "USA"
            );

            Customer customer2 = new Customer(
                "John Smith",
                address2
            );

            Product product3 = new Product(
                "Keyboard",
                "P003",
                50,
                1
            );

            Product product4 = new Product(
                "Monitor",
                "P004",
                200,
                2
            );

            Order order2 = new Order(customer2);

            order2.AddProduct(product3);
            order2.AddProduct(product4);


            Console.WriteLine("========== FIRST ORDER ==========");

            Console.WriteLine(order1.GetPackingLabel());

            Console.WriteLine(order1.GetShippingLabel());

            Console.WriteLine(
                $"Total Cost: ${order1.GetTotalCost():F2}"
            );
            
            Console.WriteLine("\n========== SECOND ORDER ==========");

            Console.WriteLine(order2.GetPackingLabel());

            Console.WriteLine(order2.GetShippingLabel());

            Console.WriteLine(
                $"Total Cost: ${order2.GetTotalCost():F2}"
            );
        }
    }
}
