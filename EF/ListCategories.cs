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

            // L2E  - Linq To Entities 
            var cats = from c in ctx.Categories
                       where c.Code.StartsWith("P")
                       select c;


            var cats2 = from c in ctx.Categories
                        orderby c.Code
                        select new
                        {
                            Code = c.Code.Substring(0, 1),
                            Description = c.Description.ToUpper()
                        };

            foreach (var c in cats2)
                Console.WriteLine($"{c.Code} - {c.Description}");

            var phone = (from c in ctx.Categories
                         where c.Description.Contains("phones")
                         select c).FirstOrDefault();
        }
    }
}
