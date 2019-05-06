using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.EF
{
    class ManipulateCategory
    {
        static void Main(string[] args)
        {
            var ctx = new InventoryContext();
            ctx.Database.Log = Console.WriteLine;

            // Insert a new category 

            var nc = new Category { Code = "c1", Description = "Category 1" };
            Console.WriteLine("After creation " + ctx.Entry(nc).State);
            ctx.Categories.Add(nc);
            Console.WriteLine("After Addition " + ctx.Entry(nc).State);
            ctx.SaveChanges();


            // Delete existing category 

            /*
            var dc = ctx.Categories.Find("c1");
            if (dc != null)
            {
                ctx.Categories.Remove(dc);   // Delete 
                ctx.SaveChanges();
            }
            else
                Console.WriteLine("Sorry! Category not found!");
            */

            // Update existing category 
            var c = ctx.Categories.Find("ph");
            Console.WriteLine("After loading "  + ctx.Entry(c).State); // Unchanged

            if (c != null)
            {
                c.Description = "Phones";
                Console.WriteLine("After change " + ctx.Entry(c).State); // Modified
                ctx.SaveChanges();
                Console.WriteLine("After saving " + ctx.Entry(c).State); // Unchanged 
            }
            else
                Console.WriteLine("Sorry! Category not found!");

        }
    }
}
