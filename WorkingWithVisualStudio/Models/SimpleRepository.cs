using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkingWithVisualStudio.Models
{
    public class SimpleRepository
    {
        private static SimpleRepository sharedRepository = new SimpleRepository();
        private Dictionary<string, Product> products = new Dictionary<string, Product>();

        public static SimpleRepository SharedRepository => sharedRepository;

        public SimpleRepository()
        {
            var initialItems = new[]
            {
                new Product{ Name = "Kajak", Price = 275M },
                new Product{ Name = "Kamizelka ratunkowa", Price = 40.10M },
                new Product{ Name = "Wiosło", Price = 98M },
                new Product{ Name = "Kask", Price = 20M }
            };
            foreach(var p in initialItems)
            {
                AddProduct(p);
            }

            products.Add("Błąd", null);
        }

        public IEnumerable<Product> Products => products.Values;

        public void AddProduct(Product p) => products.Add(p.Name, p);
    }
}
