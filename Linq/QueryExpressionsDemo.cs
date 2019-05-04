using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.Linq
{
    class QueryExpressionsDemo
    {
        static void Main(string[] args)
        {
            var books = Book.GetBooks();
            var selbooks = from b in books
                           where b.Price > 500
                           orderby b.Price descending 
                           select b;

            foreach (Book b in selbooks)
                Console.WriteLine($"{b.Title} - {b.Price}");


            var netbooks = from b in books
                           select new { b.Title, NetPrice =  b.Price * 1.12 };

            foreach(var b in netbooks)
                Console.WriteLine($"{b.Title} - {b.NetPrice}");


            var avgprice = books.Average(b => b.Price);

            Console.WriteLine("Books costlier than avg price");
            var costlybooks = from b in books
                              where b.Price > avgprice
                              select b;

            foreach (Book b in costlybooks)
                Console.WriteLine($"{b.Title} - {b.Price}");

            // Get book by Walther

            var book = (from b in books
                       where b.Author == "Walther"
                       select b).SingleOrDefault();

            Console.WriteLine(book);
        }
    }
}
