using System.ComponentModel.DataAnnotations;

namespace RetailInventory.Models;

public class Product
{
    public int Id { get; set; }

    [MaxLength(100)] // 👈 Fix here
    public string Name { get; set; }

    public decimal Price { get; set; }

    public int CategoryId { get; set; }

    public Category Category { get; set; }
}
