using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.EF
{
    class ListProducts
    {
        static void Main(string[] args)
        {
            var ctx = new CatalogEntities();
            // ctx.Database.Log = Console.WriteLine;

            foreach(var p in ctx.products)
            {
                Console.WriteLine($"{p.prodname} - {p.sales.Sum( s => s.amount)}");
            }
        }
    }
    
}
