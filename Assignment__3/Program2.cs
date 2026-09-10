using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class ProductPrice
    {
        private string productName;
        private double price;

        public string ProductName
        {
            get
            {
                return productName;
            }
            set
            {
                productName = value;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public double DiscountPrice
        {
            get
            {
                if (price >= 10000)
                    return price - (price * 20 / 100);
                else if (price >= 5000)
                    return price - (price * 10 / 100);
                else
                    return price;
            } }
    }
    internal class Program2
    {
        static void Main3(string[] args)
        {
            ProductPrice product = new ProductPrice();

            product.ProductName = "AcerLaptop";
            product.Price = 71000;
            Console.WriteLine("Product Name:" + product.ProductName);
            Console.WriteLine("Original Price" + product.Price);
            Console.WriteLine("Final Price:" + product.DiscountPrice);
        }
    }
}