using System.ComponentModel.DataAnnotations;

namespace loja;

public class Product
{
  public int Id { get; set; }
  [Required] 
  public string Name { get; set; }
  public decimal Price { get; set; }

  public Product()
  {
    this.Id = numRandom();
    this.Name = "";
  }
  public Product(string _name, decimal _price)
  {
    this.Id = numRandom();
    this.Name = _name;
    this.Price = _price;
  }
  private int numRandom()
  {
    Random random = new Random();
    return random.Next(5, 1001);
  }
}
