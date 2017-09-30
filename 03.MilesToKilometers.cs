using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());
            double milesToKilometers = miles * 1.60934;

            Console.WriteLine($"{milesToKilometers:F2}");


        }
    }
}