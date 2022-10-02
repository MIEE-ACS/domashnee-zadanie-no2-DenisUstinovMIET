// ВАРИАНТ 17
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    class Program
    {
        static double Segment1(double x)//расчет первого сегмента графика 
        {
            double y = 1;
            return y;
        }
        static double Segment2(double x, double r)//расчет второго сегмента графика 
        { //центр окружности 
            double a = -1; double y;
            //по уравнению окружности
            y = Math.Sqrt(Math.Pow(r, 2) - Math.Pow(x - a, 2));
            return -y;
        }
        static double Segment3(double x)//расчет третьего сегмента графика 
        { //центр окружности 
            double y = -2;
            return y;
        }
        static double Segment4(double x)//расчет четвертого сегмента графика 
        { //центр окружности
            double y = x - 4;
            return y;
        }
        static void Main(string[] args)
        {
            Console.Write("Все точки функции с шагом аргумента 0,2:\n");
            for (double x = -5; x < 5.1; x += 0.2)// знак <= не работает по непонятным причинам
            {
                if ((x > -3.1) && (x < -2.9))// знак == не работает по непонятным причинам
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment1(x));
                }
                if (x < -3)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment1(x));
                }
                else if (x < -1)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment2(x, 2));
                }
                else if (x < 2)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment3(x));
                }
                else
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment4(x));
                }
            }

            double r;
            Console.Write("Введите радиус: ");
            while (!double.TryParse(Console.ReadLine(), out r))
                Console.Write("Введите радиус в виде числа:");

            if (r < 2) r = 0;//того чтобы, при меньших значениях был разрыв второго рода

            while (true)
            {
                Console.Write("Введите аргумент функции: ");
                double x;
                while (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.Write("Ошибка ввода! Введите аргумент функции в виде числа:");
                }
                if (x == -3)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment1(x));
                }
                if (x < -5)
                {
                    Console.WriteLine("Функция не определена");
                }
                else if (x < -3)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment1(x));
                }
                else if (x < -1)
                {
                    if (r == 0)
                        Console.WriteLine("y({0:0.00}) = Разрыв второго рода", x);
                    else
                        Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment2(x, r));
                }
                else if (x < 2)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment3(x));
                }
                else if (x <= 5)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment4(x));
                }
                else
                {
                    Console.WriteLine("Функция не определена");
                }
            }
        }
    }
}