namespace _02.CollectionOfProducts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Wintellect.PowerCollections;

    public class Store
    {
        private OrderedBag<Product> products;

        public Store()
        {
            this.products = new OrderedBag<Product>();
        }

        public void Add(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException("Cannot add null product!");
            }

            this.products.Add(product);
        }

        public ICollection<Product> FindInRange(double minPrice, double maxPrice)
        {
            return this.products.Range(new Product(string.Empty, minPrice), true, new Product(string.Empty, maxPrice), true).Take(20).ToList();
        }
    }
}
