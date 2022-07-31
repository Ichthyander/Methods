using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Обязательная задача*. Два треугольника заданы длинами своих сторон. Определить, площадь какого из них больше 
 * (создать метод для вычисления  площади  треугольника по длинам его сторон).  Для решения задачи можно использовать формулу Герона */

namespace Task_1
{
    class Program
    {
        static double CalcTriangleArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Сравнение площади треугольников");
            Console.WriteLine();
            Console.WriteLine("Введите стороны первого треугольника");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double b1 = Convert.ToDouble(Console.ReadLine());
            double c1 = Convert.ToDouble(Console.ReadLine());
            double area1 = CalcTriangleArea(a1, b1, c1);
            Console.WriteLine("Площадь первого треугольника - {0:.00}", area1);
            Console.WriteLine();
            
            Console.WriteLine("Введите стороны второго треугольника");
            double a2 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());
            double c2 = Convert.ToDouble(Console.ReadLine());
            double area2 = CalcTriangleArea(a2, b2, c2);
            Console.WriteLine("Площадь второго треугольника - {0:.00}", area2);
            Console.WriteLine();

            if (area1 > area2)
            {
                Console.WriteLine("Площадь первого треугольника больше площади второго");
            }
            else if(area1 < area2)
            {
                Console.WriteLine("Площадь второго треугольника больше площади первого");
            }
            else if(area1 == area2)
            {
                Console.WriteLine("Площади равны");
            }
            else
            {
                Console.WriteLine("ОШИБКА! Проверьте правильность набора данных и возможность построения треугольника с указанными сторонами");
            }

            Console.ReadKey();
        }
    }
}
