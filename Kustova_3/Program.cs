using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kustova_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выполнила Кустова Юлия Сергеевна, АЭМ-111");

            double a, b, n, x0, xk, dx;

            Console.Write("Введите A: ");
            a = double.Parse(Console.ReadLine().Replace(".", ","));
            Console.Write("Введите B: ");
            b = double.Parse(Console.ReadLine().Replace(".", ","));
            Console.Write("Введите N: ");
            n = double.Parse(Console.ReadLine().Replace(".", ","));
            Console.Write("Введите X0: ");
            x0 = double.Parse(Console.ReadLine().Replace(".", ","));
            Console.Write("Введите Xk: ");
            xk = double.Parse(Console.ReadLine().Replace(".", ","));
            Console.Write("Введите dX: ");
            dx = double.Parse(Console.ReadLine().Replace(".", ","));

            double x = x0;
            while (x < xk)
            {
                double j = (0.5 * Math.Cos(a * Math.Pow(x, a)) + b) / (Math.Tan(Math.Pow(a * a + b - n, 1.0 / 3)));

                Console.WriteLine("J({0:0.000}) = {1:0.000}", x, j);
                
                x += dx;
            }

            Console.ReadKey(); //ожидание любой клавиши
        }
    }
}