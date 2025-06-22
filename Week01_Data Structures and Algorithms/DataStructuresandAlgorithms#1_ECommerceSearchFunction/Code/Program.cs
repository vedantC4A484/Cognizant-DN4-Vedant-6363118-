using ECommercePlatformSearch;
using System;

class Program
{
    static void Main(string[] args)
    {
        Product[] products = {
            new Product(1, "Laptop", "Electronics"),
            new Product(2, "Headphones", "Electronics"),
            new Product(3, "Desk", "Furniture"),
            new Product(4, "Chair", "Furniture"),
            new Product(5, "Notebook", "Stationery")
        };

        // Binary search needs sorted array
        Array.Sort(products, (a, b) => a.ProductName.CompareTo(b.ProductName));

        Console.Write("Search for: ");
        string name = Console.ReadLine();

        Product resultLinear = ProductSearch.LinearSearch(products, name);
        Product resultBinary = ProductSearch.BinarySearch(products, name);

        Console.WriteLine("\nLinear Search Result:");
        Console.WriteLine(resultLinear?.ToString() ?? "Not Found");

        Console.WriteLine("\nBinary Search Result:");
        Console.WriteLine(resultBinary?.ToString() ?? "Not Found");
    }
}
