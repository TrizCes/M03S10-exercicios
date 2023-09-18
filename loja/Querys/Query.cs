using loja.Model;
using loja.Mock;

namespace loja.Querys
{
    public class Query
    {
        public Db database;
        public Query(Db _database)
        {
            database = _database;
        }
        public Query() { }
        public List<Product> GetAllProducts()
        {
            return database.Products;
        }
        public List<Customer> GetAllCustomers()
        {
            return database.Customers;
        }
        public Customer GetCustomer(int id)
        {
            return database.Customers.Find(c => c.Id == id);
        }
        public List<Order> GetOrderByCustomerId(int customerId)
        {
            return database.Orders.FindAll(o => o.CustomerId == customerId);
        }
    }
}
