using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.EF
{
    class ListSales
    {
        static void Main(string[] args)
        {
            var ctx = new CatalogEntities();
            ctx.Database.Log = Console.WriteLine;

            foreach(sale s in ctx.sales.Include("product"))
            {
                Console.WriteLine($"{s.invno} - {s.product.prodname} - {s.amount}");
            }
        }
    }
}
