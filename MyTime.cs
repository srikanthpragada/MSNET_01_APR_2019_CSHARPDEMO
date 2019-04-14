using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class MyTime : IComparable<MyTime>
    {
        // Auto implemented property 
        public int Hours { get; set; }
        public int Mins { get; set; }
        public int Secs { get; set; }

        public int TotalSeconds
        {
            get
            {
                return Hours * 3600 + Mins * 60 + Secs;
            }
        }
        public override string ToString()
        {
            return $"{Hours:00}:{Mins:00}:{Secs:00}";
        }

        public override bool Equals(object obj)
        {
            MyTime other = obj as MyTime;
            return this.TotalSeconds == other.TotalSeconds;
        }
        // Compare this with other and return int (0, >0, <0)
        public int CompareTo(MyTime other)
        {
            return this.TotalSeconds - other.TotalSeconds;
        }
    }

    class TestMyTime
    {
        static void Main(string[] args)
        {
            // Object initialization 
#region  First Demo 
            /*
            MyTime t1 = new MyTime { Hours = 10, Mins = 20, Secs = 30 };
            MyTime t2 = new MyTime { Hours = 10, Mins = 20, Secs = 30 };

            Console.WriteLine(t1 == t2);
            Console.WriteLine(t1.Equals(t2));
            Console.WriteLine(t1.ToString());
            */
            #endregion

            MyTime [] times =
              { new MyTime {Hours = 10, Mins = 20, Secs= 10},
                new MyTime {Hours = 1, Mins = 30, Secs= 50},
                new MyTime {Hours = 1, Mins = 10, Secs= 50},
                new MyTime {Hours = 20, Mins = 10, Secs= 5},
                new MyTime {Hours = 20, Mins = 10, Secs= 40}};

            Array.Sort(times);

            foreach(var t in times)
                Console.WriteLine(t);

        }
    }
}
