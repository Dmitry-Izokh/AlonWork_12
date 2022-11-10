using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlonWork_12
{
    static class Circle
    {
        static public double GetLenght(double r)
        {
            return 2 * Math.PI * r;
        }
        static public double GetSquare(double r)
        {
            return Math.PI * r * r;
        }
        static public double CheckPoint( double r, double x, double y)
        {
            double hypotenuse = Math.Sqrt(x * x + y * y);
            if (hypotenuse <= r)
            {
                return $"Точка принадлежит кругу";
            }
            else
            {
                return $"Точка НЕ принадлежит кругу";
            }
             
        }
    }
}
