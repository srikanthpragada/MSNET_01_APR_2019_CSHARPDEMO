using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class TupleDemo
    {
        static void Main(string[] args)
        {
            var t = Tuple.Create("Abc", 2, 3, 4);
            
            Tuple<int, string> t2 = Tuple.Create(1, "Xyz");
        }
    }
}
