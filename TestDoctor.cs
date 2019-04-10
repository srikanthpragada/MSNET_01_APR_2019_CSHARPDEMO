using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    abstract class Doctor
    {
        protected string name, dept;
        public Doctor(string name, string dept)
        {
            this.name = name;
            this.dept = dept;
        }
        public virtual void Print()
        {
            Console.WriteLine(this.name);
            Console.WriteLine(this.dept);
        }
        // must be overridden in derived class 
        public abstract int GetPay();
    }

    class RDoctor : Doctor
    {
        protected int salary;
        public RDoctor(string name, string dept, int salary)
           : base(name, dept)
        {
            this.salary = salary;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine(this.salary);
        }
        public override int GetPay()
        {
            return this.salary;
        }
    }

    class Consultant : Doctor
    {
        protected int nvisits, charge;
        public Consultant(string name, string dept, int nvisits, int charge)
           : base(name, dept)
        {
            this.nvisits = nvisits;
            this.charge = charge;

        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine(this.nvisits);
            Console.WriteLine(this.charge);
        }
        public override int GetPay()
        {
            return this.nvisits * this.charge;
        }
    }

    class TestDoctor
    {
        static void Main(string[] args)
        {
            Doctor d;

            d = new RDoctor("Dr. Dean", "PED", 300000);
            d.Print(); // Runtime Polymorphism 
            Console.WriteLine(d.GetPay()); // Runtime Polymorphism 

            d = new Consultant("Dr. Steve", "CARD", 20,2000);
            d.Print();
            Console.WriteLine(d.GetPay());
        }
    }
}
