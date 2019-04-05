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
        // Constructor 
        public Product(int prodid, string prodname, double prodprice=0)
        {
            id = prodid;
            name = prodname;
            price = prodprice; 
        }
        // Method
        public void Print()
        {
            Console.WriteLine($"{id} - {name} - {price}");
        }
    }
    class TestProduct
    {
        static void Main(string[] args)
        {
            Product p1;  // object reference

            p1 = new Product(1,"Dell Laptop");  // create object 
            // p1.id = 101;
            p1.Print();

            Product p2 = new Product(2, "Bose Headphones", 20000);
            p2.Print(); 

        }
    }
}
