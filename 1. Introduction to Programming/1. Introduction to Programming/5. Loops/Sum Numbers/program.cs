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
            Console.WriteLine("Enter the numbers:");
            var sum = 0;

            for (int i = 0; i < n; i++)

            {
                var num = int.Parse(Console.ReadLine());
                sum = sum + num;

            }

            Console.WriteLine("sum =" + sum);


        }
    }
}
