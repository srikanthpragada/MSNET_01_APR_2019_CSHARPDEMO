using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class Product
    {
        // Instance variables 
        private int id;
        private string name;
        private double price;
        // Class variables
        private static int tax = 8;

        public static int Tax
        {
            get
            {
                return Product.tax;
            }
            set
            {
                Product.tax = value; 
            }
        }

        // Constructor 
        public Product(int id, string name, double price = 0)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        public Product(string name)
        {
            this.name = name;
        }

        // Method
        public void Print()
        {
            Console.WriteLine($"{this.id} - {this.name} - {this.price}");
        }

        // Property for name - read/write
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length > 0)
                    this.name = value;
            }
        }
        // Readonly property
        public double NetPrice
        {
            get
            {
                return this.price * (this.price * tax / 100) ;
            }
        }
    }
    class TestProduct
    {
        static void Main(string[] args)
        {
            Product p1;  // object reference

            p1 = new Product(1, "Dell Laptop");  // create object 
            p1.Print();

            Console.WriteLine(p1.Name);
            p1.Name = "";

            Console.WriteLine(p1.NetPrice);



        }
    }
}
