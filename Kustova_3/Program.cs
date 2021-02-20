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
                var pow = Math.Pow(a * a + b - n, 1.0 / 3);
                if (Math.Abs(pow % Math.PI - Math.PI / 2) > 0.000001)
                {
                    var tan = Math.Tan(pow);
                    if (tan != 0)
                    {
                        double j = (0.5 * Math.Cos(a * Math.Pow(x, a)) + b) / tan;

                        Console.WriteLine("J({0:0.000}) = {1:0.000}", x, j);
                    }
                    else
                    {
                        Console.WriteLine("J({0:0.000}) = ошибка! деление на 0", x);
                    }
                }
                else
                {
                    Console.WriteLine("J({0:0.000}) = ошибка! тангенс не вычисляется (PI/2)", x);
                }
                
                x += dx;
            }

            Console.ReadKey(); //ожидание любой клавиши
        }
    }
}