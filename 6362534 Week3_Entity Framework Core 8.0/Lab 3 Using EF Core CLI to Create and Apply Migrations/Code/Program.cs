using System;
using System.Linq;

class Program
{
    static void Main()
    {
        using (var context = new AppDbContext())
        {
            context.Database.EnsureCreated();

            if (!context.Categories.Any())
            {
                var electronics = new Category { Name = "Electronics" };
                var laptop = new Product { Name = "Laptop", Price = 799.99m, Category = electronics };

                context.Categories.Add(electronics);
                context.Products.Add(laptop);
                context.SaveChanges();

                Console.WriteLine("Database created and sample data added.");
            }
            else
            {
                Console.WriteLine("Database already has data.");
            }
        }
    }
}
