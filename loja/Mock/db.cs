using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using loja.Model;

namespace loja.Mock
{
    public class Db
    {
        public List<Customer> Customers = new List<Customer>
        {
            new Customer (1, "Nini Ceschini", "nini@email.com"),
            new Customer (2, "Fosco Doe", "Fosco@email.com"),
            new Customer (3, "Guaxinim Doe", "Guaxinim@email.com"),
            new Customer (4, "Laranja Doe", "Laranja@email.com"),
        };
        public List<Order> Orders = new List<Order> {
            new Order (1, 1, new DateTime(10-01-01)),
            new Order (2, 1, new DateTime(10-02-01)),
            new Order (3, 1, new DateTime(10-02-03)),
            new Order (4, 2, new DateTime(10-01-01)),
            new Order (5, 2, new DateTime(10-02-01)),
            new Order (6, 2, new DateTime(10-02-03)),
            new Order (7, 3, new DateTime(10-02-01)),
            new Order (8, 3, new DateTime(10-02-03)),
            new Order (9, 4, new DateTime(23-01-01)),
            new Order (10, 4, new DateTime(23-02-01)),
        };

        public List<Product> Products = new List<Product>{
                new Product
                {
                    Name = "Men's Jeans",
                    Price = 49.99m
                },
                new Product
                {
                    Name = "Women's T-Shirt",
                    Price = 19.99m
                },
                new Product
                {
                    Name = "Sneakers",
                    Price = 79.95m
                },
                new Product
                {
                    Name = "Winter Coat",
                    Price = 149.99m
                },
                new Product
                {
                    Name = "Dress Shoes",
                    Price = 69.99m
                }
        };

        public Db() { }
    }
}