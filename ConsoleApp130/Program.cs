using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp130
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine($"x squared:{Square(x)}");
            Console.ReadLine();
        }

        static int Square(int y)
        {
            return y * y;
        }

    }
}
