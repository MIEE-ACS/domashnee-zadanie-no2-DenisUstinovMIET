﻿// ВАРИАНТ 17
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

            Console.Write("Введите радиус: ");
            double r = double.Parse(Console.ReadLine());
            if (r<2) r = 0;

            while (true)
            {
                Console.Write("Введите аргумент функции: ");
                double x = double.Parse(Console.ReadLine());

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

