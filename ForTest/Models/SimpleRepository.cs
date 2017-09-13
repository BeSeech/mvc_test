using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace mvc_test.Models
{
    public class SimpleRepository : IRepository
    {
        private static SimpleRepository sharedRepository = new SimpleRepository();
        private Dictionary<string, Product> products = new Dictionary<string, Product>();
        public static SimpleRepository SharedRepository => sharedRepository;

        public IEnumerable<Product> Products => products.Values;

        public void AddProduct(Product p) => products.Add(p.Name, p);

        public SimpleRepository()
        {
            var initialItems = new[]
            {
                new Product {Name="Kayak", Price = 275},
                new Product {Name="Lifejacket", Price = 48.95M},
                new Product {Name="Soccer ball", Price = 19.5M},
                new Product {Name="Corner flag", Price = 34.95M},
            };
            foreach (var p in initialItems)
            {
                AddProduct(p);
            }

        }

    }
}