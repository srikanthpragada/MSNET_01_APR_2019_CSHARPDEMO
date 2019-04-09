using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class Customer
    {
        private int id;
        private string name, email;
        private int total_amount;

        public Customer(int id, string name, string email)
        {
            this.id = id;
            this.name = name;
            this.email = email;
        }

        public Customer(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public string EmailAddress
        {
            get
            {
                return this.email; 
            }
            set
            {
                this.email = value; 
            }
        }

        public int Points
        {
            get
            {
                return this.total_amount / 100; 
            }
        }
        public void Purchase(int amount)
        {
            this.total_amount += amount;
        }
    }

    class TestCustomer
    {
        static void Main(string[] args)
        {
            Customer c = new Customer(1, "Mr. Gates");
            c.EmailAddress = "gates@microsoft.com";
            c.Purchase(10000);
            c.Purchase(5000);
            Console.WriteLine(c.Points);
        }
    }
}
