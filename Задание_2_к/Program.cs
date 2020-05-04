using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_к
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            bool prov;
            do
            {
                Console.Write("Введите целое число:");
                prov = int.TryParse(Console.ReadLine(),out a);
                if (!prov)
                    Console.WriteLine("Некорректный ввод");
            } while (!prov);
            if (a % 2 == 0) Console.WriteLine("Введённое число является чётным");
            else Console.WriteLine("Введённое число не является чётным");
            Console.ReadLine();
        }
    }
}
