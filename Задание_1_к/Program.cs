using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1_к
{
    class Program
    {
        static void Main(string[] args)
        {
            float P = 0;
            do
            {
                Console.Write("Введите периметр равностороннего треугольника: ");
                float.TryParse(Console.ReadLine(), out P);
                if(P <=0)
                    Console.WriteLine("Некорректный ввод.");
            } while (P <= 0);
            double S = ((P / 3) * (P / 3) * Math.Sqrt(3)) / 4;
            Console.Write("Площадь равностороннего треугольника с периметром P = {0} равна {1}",P,S);
            Console.ReadLine();
        }
    }
}
