using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTest
{
    class TaskTest
    {
        static void Main(string[] args)
        {
            Task t = new Task(WriteY);
            t.Start();
            WriteX();
            Console.ReadKey();
        }

        static void WriteY()
        {
            for (int i = 0; i < 1000; i++)
                Console.Write("Y");
        }

        static void WriteX()
        {
            for (int i = 0; i < 1000; i++)
                Console.Write("X");
        }
    }
}
