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
            var num = new List<int>()
            {
                10,20,30,40,50
            };
            TestComplete(5, num);
            Console.ReadKey();
        }

        static async void TestComplete(int n, List<int> num)
        {
            Console.WriteLine("Line 1");
            List<Task> t = new List<Task>();

            foreach (var item in num)
            {
                var task = new Task<int>(() => ComplexCalculation(item));
                Console.WriteLine("Item value: " + item);
                task.Start();
                t.Add(task);
            }

            Console.WriteLine("Line 2");
            
            //await Task.WhenAll(t.ToArray());
            Task.WaitAll(t.ToArray());
            
            foreach (Task<int> task in t)
            {
                // Not Need Async Keyword
                //var result = task.Result;

                var result = await task;
                Console.WriteLine("Result --- " + result);
            }

            Console.WriteLine("Line 3");
        }

        static int ComplexCalculation(int n)
        {
            /*double x = 2;
            int num = n * 1000000;
            for (int i = 0; i < num; i++)
                x += Math.Sqrt(x) / i;*/
            Console.WriteLine("In Calculation : " + n);
            return (int)n;
        }
    }
}
