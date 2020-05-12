using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Z4_1_
{
    class Program
    {
        static void notation(int i, ref string s)
        {
            if (i > 0)
            {
                notation(i / 2, ref s);
                s += (i % 2).ToString();
            }
            if (i == 0) Console.Write("");
            if (i < 0) Console.Write("Проверьте число, которое хотите перевести!");
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число, которое хотите перевести: ");
            int val_10 = int.Parse(Console.ReadLine());
            string val_2 = "";
            notation(val_10, ref val_2);
            Console.Write("Число " + val_10 + " в двоичной сс = " + val_2);
            Console.ReadKey();
        }
    }
}
