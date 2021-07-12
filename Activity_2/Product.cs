using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_2
{
    public class Product
    {
        public static int currentProductId;
        public string description;
        public double price;
        public string productId;
        public string productName;
        public string Description { get; set; }
        public double Price { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }

        static Product()
        {
            currentProductId = 100;
        }
        public Product()
        {
            productId = ("P" + currentProductId);
            currentProductId++;
            Console.WriteLine(productId);
        }
        public Product(string productName, string description, double price)
        {

        }
    }
}
