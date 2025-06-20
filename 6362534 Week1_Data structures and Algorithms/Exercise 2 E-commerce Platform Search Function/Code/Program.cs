using System;
using System.Linq;

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string Category { get; set; }

    public Product(int productId, string productName, string category)
    {
        ProductId = productId;
        ProductName = productName;
        Category = category;
    }

    public override string ToString()
    {
        return $"{ProductId}: {ProductName} ({Category})";
    }
}

class Program
{
    static void Main()
    {
        Product[] products = new Product[]
        {
            new Product(101, "Laptop", "Electronics"),
            new Product(102, "Shoes", "Fashion"),
            new Product(103, "Phone", "Electronics"),
            new Product(104, "Watch", "Accessories"),
        };

        // Unsorted array - Linear Search
        Console.WriteLine("🔍 Linear Search:");
        var found1 = LinearSearch(products, "Phone");
        Console.WriteLine(found1 != null ? found1.ToString() : "Product not found");

        // Sorted array - Binary Search
        var sortedProducts = products.OrderBy(p => p.ProductName).ToArray();
        Console.WriteLine("🔍 Binary Search:");
        var found2 = BinarySearch(sortedProducts, "Phone");
        Console.WriteLine(found2 != null ? found2.ToString() : "Product not found");
    }

    static Product LinearSearch(Product[] products, string productName)
    {
        foreach (var product in products)
            if (product.ProductName.Equals(productName, StringComparison.OrdinalIgnoreCase))
                return product;
        return null;
    }

    static Product BinarySearch(Product[] products, string productName)
    {
        int left = 0, right = products.Length - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            int cmp = string.Compare(products[mid].ProductName, productName, StringComparison.OrdinalIgnoreCase);
            if (cmp == 0) return products[mid];
            else if (cmp < 0) left = mid + 1;
            else right = mid - 1;
        }
        return null;
    }
}
