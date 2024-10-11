using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement
{
    internal class Program
    {
        static List<Dictionary<string, string>> products = new List<Dictionary<string, string>>();

        static void AddProduct()
        {
            var product = new Dictionary<string, string>();
            Console.WriteLine("Enter Product Name: ");
            product.Add("name", Console.ReadLine());

            Console.WriteLine("Enter Product Price: ");
            product.Add("price", Console.ReadLine());

            Console.WriteLine("Enter Stock: ");
            product.Add("stock", Console.ReadLine());

            var id = Guid.NewGuid().ToString();
            product.Add("id", id);
            products.Add(product);
            Console.WriteLine($"product added successfully id = {id}");
        }
        static void UpdateStock()
        {
            Console.WriteLine("Enter the product id:");
            var id = Console.ReadLine();
            foreach (var product in products)
            {
                if (product["id"] == id)
                {
                    Console.WriteLine("Enter the new stock");
                    product["stock"] = Console.ReadLine();
                    break;
                }
            }

        }

        static void GetProductDetails() 
        {
            Console.WriteLine("Enter product id:");
            var id = Console.ReadLine();
            foreach (var product in products)
            {
                if (product["id"] == id)
                {
                    Console.WriteLine("Name: " + product["name"]);
                    Console.WriteLine("price: " + product["price"]);
                    Console.WriteLine("Stock: " + product["stock"]);
                    break;
                }
            }
        }

        static void GetLowStockProduct()
        {
            Console.WriteLine("Enter the minimum stock");
            var count = int.Parse(Console.ReadLine());
            foreach (var product in products)
            {
                var stocks = int.Parse(product["stock"]);
                if (stocks < count)
                {
                    Console.WriteLine("Name: " + product["name"]);
                    Console.WriteLine("price: " + product["price"]);
                }
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1.Add Product");
                Console.WriteLine("2.Update Stock");
                Console.WriteLine("3.Get Product Details");
                Console.WriteLine("4.Get Low Stock products");

            
                var option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        AddProduct();
                        break;
                    case "2":
                        UpdateStock();
                        break;
                    case "3":
                        GetProductDetails();
                        break;
                    case "4":
                        GetLowStockProduct();
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}
