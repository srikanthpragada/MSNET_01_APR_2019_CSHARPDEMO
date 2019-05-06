using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.EF
{
    class TransDemo
    {
        static void Main(string[] args)
        {
            var ctx = new InventoryContext();
            ctx.Database.Log = Console.WriteLine;

            // Operation 1
            var c1 = ctx.Categories.Find("c1");
            c1.Description = "Category 1";

            // Operation 2
            var c2 = new Category { Code = "c2", Description = "Category 2" };
            ctx.Categories.Add(c2);

            ctx.SaveChanges();
        }
    }
}
