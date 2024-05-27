using System.Text.Json;

namespace FIleStreamAndFileIO
{
    internal class Program
    {
        public static string ProductToJSON(Product product)
        {
            return JsonSerializer.Serialize(product);
        }
        public static Product JSONToProduct(string json)
        {
            return JsonSerializer.Deserialize<Product>(json);
        }
        static void Main(string[] args)
        {
            Product product = new Product
            {
                Id = 1,
                Name = "PC",
                Price = 2000
            };
            string json = ProductToJSON(product);
            Console.WriteLine("Product JSON şeklinde:");
            Console.WriteLine(json);

            Product deserializedProduct = JSONToProduct(json);
            Console.WriteLine("\nJSON-dan mehsula:");
            Console.WriteLine($"Id: {deserializedProduct.Id}, Name: {deserializedProduct.Name}, Price: {deserializedProduct.Price}");
        }
    }
}
