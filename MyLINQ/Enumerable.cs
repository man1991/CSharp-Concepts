using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQ
{
    public static class Enumerable
    {
        public static IEnumerable<T> Where<T>(this IEnumerable<T> items, Func<T, bool> test)
        {
            foreach (var item in items)
            {
                if (test(item))
                    yield return item;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
