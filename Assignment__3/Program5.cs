using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class ShoppingCart
    {
        private string productName;
        private double price;
        private int quantity;
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
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }
        public double TotalPrice
        {
            get
            {
                return price * quantity;
            }
        }
        public double Discount
        {
            get
            {
                if (TotalPrice >= 10000)
                    return TotalPrice * 15 / 100;
                else if (TotalPrice >= 5000)
                    return TotalPrice * 10 / 100;
                else
                    return 0;
            }
        }
        public double FinalPrice
        {
            get
            {
                return TotalPrice - Discount;
            }
        }
    }
    internal class Program5
    {
        static void Main(string[] args)
        {
            ShoppingCart p = new ShoppingCart();

            p.ProductName = "Acerlaptop";
            p.Price = 71000;
            p.Quantity = 2;
            Console.WriteLine("Product Name " + p.ProductName);
            Console.WriteLine("Price" + p.Price);
            Console.WriteLine("Quantity " + p.Quantity);
            Console.WriteLine("Total Price" + p.TotalPrice);
            Console.WriteLine("Discount" + p.Discount);
            Console.WriteLine("Final Price" + p.FinalPrice);
        }
    }
}