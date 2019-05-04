using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.EF
{
    class ListCategories
    {
        static void Main(string[] args)
        {
            var ctx = new InventoryContext();
            ctx.Database.Log = Console.WriteLine; 

            foreach(Category c in ctx.Categories)
                Console.WriteLine($"{c.Code} - {c.Description}");
        }
    }
}
