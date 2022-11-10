using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlonWork_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус круга = ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите значение координаты x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите значение координаты y = ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            double lenght = Circle.GetLenght(r);
            Console.WriteLine("Длина окружности = {0}", lenght);
            Console.WriteLine();

            double square = Circle.GetSquare(r);
            Console.WriteLine("Площадь круга = {0}", square);
            Console.WriteLine();

            double point = Circle.CheckPoint(r, x, y);
            Console.WriteLine("Длина окружности = {0}", square);
            Console.WriteLine(point);

            Console.ReadKey();
        }
    }
}
