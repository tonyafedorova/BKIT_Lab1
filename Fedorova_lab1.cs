using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                string A1, B1, C1;
                Double A, B, C;
                Console.Write("Введите A: \n");
                A1 = Console.ReadLine();
                Console.Write("Введите B: \n");
                B1 = Console.ReadLine();
                Console.Write("Введите C: \n");
                C1 = Console.ReadLine();
                if (Double.TryParse(A1, out A) & Double.TryParse(B1, out B) & Double.TryParse(C1, out C))
                {
                    Double d = (B * B) - (4 * A * C);
                    double X1, X2;
                    if (d > 0)
                    {
                        X1 = (Math.Sqrt(d) - B) / (2 * A);
                        X2 = (-Math.Sqrt(d) - B) / (2 * A);
                        Console.WriteLine("Ответ: X1={0}, X2={1}", X1, X2);
                    }
                    else if (d == 0)
                    {
                        X1 = -B / 2 * A;
                        Console.WriteLine("Ответ: X={0}", X1);
                    }
                    else Console.Write("Уравнение не имеет рационального решения \n");
                }
                else Console.WriteLine("Нужно вводить числа\n");
            }
            while (i > 0);

        }
    }
}
