using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter x:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("enter y:");
            double y = Convert.ToDouble(Console.ReadLine());

            double result = Math.Log(x) / Math.Log(y);

            Console.WriteLine($"log-{y}({x})={result}");
        }
    }
}
