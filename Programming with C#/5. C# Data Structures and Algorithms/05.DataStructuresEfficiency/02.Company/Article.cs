namespace _02.Company
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Article : IComparable<Article>
    {
        private string barcode;
        private string vendor;
        private string title;
        private decimal price;

        public Article(string barcode, string vendor, string title, decimal price)
        {
            this.Barcode = barcode;
            this.Vendor = vendor;
            this.Title = title;
            this.Price = price;
        }

        public string Barcode 
        {
            get
            {
                return this.barcode;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid barcode!");
                }

                this.barcode = value;
            } 
        }

        public string Vendor
        {
            get
            {
                return this.vendor;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid vendor!");
                }

                this.vendor = value;
            }
        }

        public string Title
        {
            get
            {
                return this.title;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid title!");
                }

                this.title = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be zero or negative!");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            return "Article: " + this.Title + ", Price: " + this.Price + ", Barcode: " + this.Barcode + ", Vendor: " + this.Vendor;
        }

        public int CompareTo(Article other)
        {
            return this.Title.CompareTo(other.Title);
        }
    }
}
