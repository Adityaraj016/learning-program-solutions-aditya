using System.ComponentModel.DataAnnotations;

namespace RetailInventory.Models;

public class Category
{
    public int Id { get; set; }

    [MaxLength(100)] // 👈 Fix here
    public string Name { get; set; }

    public List<Product> Products { get; set; } = new();
}
