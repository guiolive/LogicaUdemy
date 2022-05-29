using System;
using System.Globalization;

namespace URI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double D = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double diferenca = (A * B) - (C * D);

            Console.WriteLine("DIFERENCA = " + diferenca);




            

        }
    }
}
