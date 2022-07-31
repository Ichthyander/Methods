using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Обязательная задача*. Создать метод для вычисления объема и площади поверхности куба по длине его ребра.*/

namespace Task_2
{
    class Program
    {
        static void GetCubeParams (int a, out double area, out double volume)
        {
            area = 6 * Math.Pow((double)a, 2);
            volume = Math.Pow((double)a, 3);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление площади поверхности и объема куба");
            Console.WriteLine();
            Console.WriteLine("Введите длину ребра куба");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            double area, volume;
            GetCubeParams(a, out area, out volume);

            Console.WriteLine("Площадь куба - {0:.00}\nОбъём куба - {1:.00}", area, volume);
            Console.ReadKey();
        }
    }
}
