using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question18
{
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public override string ToString() => $"{Name} {Price}";
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var product = new List<Product>()
            {
                new Product { Name = "Product1", Price = 30 },
                new Product { Name = "Product2", Price = 400 },
                new Product { Name = "Product3", Price = 600 },
                new Product { Name = "Product4", Price = 100 },
                new Product { Name = "Product5", Price = 20 },
            };
            var filteredProducts = product.Where(p => p.Price > 100).OrderBy(p => p.Price);
            foreach (var item in filteredProducts)
            {
                Console.WriteLine(item);  
            }

        }
    }
}
