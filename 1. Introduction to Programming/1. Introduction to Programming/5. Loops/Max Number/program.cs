using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n = ");
            var n = int.Parse(Console.ReadLine());
            var max = -1000000000000000;

            for (int i = 1; i <= n; i++)

            {
                var num = int.Parse(Console.ReadLine());
                if (num > max)
                {
                    max = num;
                }
            }

            Console.WriteLine("max = " + max);



        }
    }
}
