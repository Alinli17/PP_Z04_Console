using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Z4_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Вызов функции: " + Func(x));
            Console.ReadKey();
        }
        static double Func(int N, int Begin = 0)
        {
            if (Begin == 0)
            {
                return N / Math.Sqrt(Func(N, ++Begin));
            }
            else
            {
                return N == Begin ? N : Begin + Math.Sqrt(Func(N, ++Begin));
            }
        }
    }
}
