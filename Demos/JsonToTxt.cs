using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
class Product
{
    public string? name { get; set; }
    public int price { get; set; }
    public int quantity { get; set; }
}
class Shop
{
    public List<Product> items { get; set; } = new();
}
class Shopping
{
    public static void Main()
    {
        Shop shop = new Shop();
        shop.items.Add(new Product { name = "Laptop", price = 50000, quantity = 2 });
        shop.items.Add(new Product { name = "Mobile", price = 20000, quantity = 3 });
        shop.items.Add(new Product { name = "Mouse", price = 500, quantity = 5 });
        shop.items.Add(new Product { name = "Keyboard", price = 1000, quantity = 4 });
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true,
            TypeInfoResolver = new DefaultJsonTypeInfoResolver()
        };
        string? data = JsonSerializer.Serialize(shop, options);
        Console.WriteLine(data);

        File.WriteAllText("Shop.json", data);
        string? jdata = File.ReadAllText("Shop.json");
        
        Shop? result = JsonSerializer.Deserialize<Shop>(jdata, options);
        Console.WriteLine("\nDeserialized Data:");
        
        if (result != null)
        {
            foreach (Product p in result.items)
            {
                Console.WriteLine($"Name: {p.name}, Price: {p.price}, Quantity: {p.quantity}");
            }
        }
    }
}