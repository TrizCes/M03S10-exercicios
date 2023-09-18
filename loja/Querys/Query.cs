namespace loja.Querys
{
    public class Query
    {
        public List<Product> GetAllProducts()
        {
            return new List<Product>{
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
        }
    }
}
