using RetailInventory.Data;
using RetailInventory.Models;

using var context = new AppDbContext();

// Add a category if none exists
if (!context.Categories.Any())
{
    var category = new Category { Name = "Electronics" };
    category.Products.Add(new Product { Name = "Laptop", Price = 999.99M });
    category.Products.Add(new Product { Name = "Smartphone", Price = 499.99M });

    context.Categories.Add(category);
    context.SaveChanges();
    Console.WriteLine("Sample data added.");
}
else
{
    var products = context.Products.ToList();
    Console.WriteLine("Products in database:");
    foreach (var product in products)
    {
        Console.WriteLine($"- {product.Name} (${product.Price})");
    }
}
