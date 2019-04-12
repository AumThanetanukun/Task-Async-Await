using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastAwait
{
    class TaskAwait
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Line 1");
            //Console.WriteLine(ComplexCalculation());
            Task<int> t = new Task<int>(()=>ComplexCalculation());
            t.Start();
            var awaiter = t.GetAwaiter();
            awaiter.OnCompleted(()=>
            {
                Console.WriteLine("Line ?");
                int result = awaiter.GetResult();
                Console.WriteLine(result);
            });
            Console.WriteLine("Line 2");
            Console.ReadKey();
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
