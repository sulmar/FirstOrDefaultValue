using System;
using System.Linq;

namespace FirstOrDefaultValue
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr2 = Enumerable.Range(0, 10);

            var c1 = arr2.FirstOrDefault(x => x > 11) == 0;

            var c2 = arr2.FirstOrDefault(x => x > 11, -1) == -1;

            var c3 = arr2.SingleOrDefault(x => x > 11, -1) == -1;

            var c4 = arr2.LastOrDefault(x => x > 11, -1) == -1;


        }
    }
        

}
