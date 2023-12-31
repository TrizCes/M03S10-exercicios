using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using loja.Mock;
using loja.Model;
using Microsoft.EntityFrameworkCore;

namespace loja.Mutation
{
    public class Mutation
    {
        public readonly Db _database;
        public Mutation(Db database)
        {
            _database = database;
        }

        public Product AddProduct(string name, string price)
        {
            var product = _database.Products.Find(p => p.Name == name);
            if (product != null)
            {
                return product;
            }
            var newProduct = new Product { Name = name, Price = decimal.Parse(price) };

            _database.Products.Add(newProduct);
            return newProduct;
        }
        public Customer UpdateCustomerEmail(string id, string newEmail)
        {
            Customer customerToUpdate = _database.Customers.FirstOrDefault(c => c.Id == int.Parse(id));
            if (customerToUpdate == null)
            {
                throw new ArgumentException("Não encontramos o cliente");
            }
            customerToUpdate.Email = newEmail;
            return customerToUpdate;
        }
    }
}
