namespace _02.CollectionOfProducts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Product : IComparable<Product>
    {
        private string name;
        private double price;

        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Product name cannot be null!");
                }

                this.name = value;
            } 
        }

        public double Price 
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Product price cannot be begative!");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            return "Name: " + this.Name + "\n" + "Price: " + this.Price;
        }

        public int CompareTo(Product other)
        {
            return (int)this.Price.CompareTo(other.Price);
        }
    }
}
