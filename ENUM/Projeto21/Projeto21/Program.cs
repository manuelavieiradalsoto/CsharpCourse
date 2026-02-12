using Projeto21.Entities;
using Projeto21.Entities.Enums;
using System;
using System.Diagnostics;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birthdate (DD/MM/YYYY): ");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus os = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int items = int.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthday);
            Order order = new Order(DateTime.Now, os, client);
            


            for (int i =0; i<items; i++) { 
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, productPrice, product);
                order.AddItem(orderItem);

            }


            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.Write(order);
        }
    }
}