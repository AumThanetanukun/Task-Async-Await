using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class AsyncAwait
    {
        static void Main(string[] args)
        {
            TestComplete();
            Console.ReadKey();
        }

        static async void TestComplete()
        {
            Console.WriteLine("Line 1");
            Task<int> t = new Task<int>(() => ComplexCalculation());
            t.Start();
            Console.WriteLine("Line 2");
            Console.WriteLine("Line 3");
            var result = await t;
            Console.WriteLine(result);
            Console.WriteLine("Line 4");
            Console.WriteLine("Line 5");
        }

        static int ComplexCalculation()
        {
            double x = 2;
            for (int i = 0; i < 100000000; i++)
                x += Math.Sqrt(x) / i;
            return (int)x;
        }
    }
}
