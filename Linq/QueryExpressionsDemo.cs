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


            //var top2books = books.OrderByDescending(b => b.Price)
            //                     .Skip(2)
            //                     .Take(2);
            //Console.WriteLine("Top 2 books by price");
            //foreach (Book b in top2books)
            //    Console.WriteLine($"{b.Title} - {b.Price}");


            //var avgprice = books.Average(b => b.Price);

            //Console.WriteLine("Books costlier than avg price");
            //var costlybooks = books.Where(b => b.Price > avgprice);

            //foreach (Book b in costlybooks)
            //    Console.WriteLine($"{b.Title} - {b.Price}");

            // Get book by Walther

            //var book = books.Where(b => b.Author == "Walther")
            //                .SingleOrDefault();
            //Console.WriteLine(book);

            //var firstbook = books.Where(b => b.Author == "Walther")
            //                     .OrderByDescending(b => b.Price)
            //                     .FirstOrDefault();

            //Console.WriteLine(book);



        }
    }
}
