using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace PiCounterApp
{
    class Program
    {
        static void Main()
        {
            try
            {
                UInt64 n;
                Console.WriteLine("Напишите желаемое количество точек, которые будут использованы в программе:");
                n = UInt64.Parse(Console.ReadLine());
                UInt64 totalPoints = n; // Количество случайных точек
                uint insideCircle = 0; // Количество точек внутри круга

                Random random = new Random();

                for (uint i = 0; i < totalPoints; i++)
                {
                    double x = random.NextDouble(); // Случайное число от 0 до 1
                    double y = random.NextDouble(); // Случайное число от 0 до 1

                    // Проверяем, попадает ли точка в круг радиуса 1
                    if (x * x + y * y <= 1)
                    {
                        insideCircle++;
                    }
                }
                // Вычисляем π
                double pi = 4.0 * insideCircle / totalPoints;
                Console.WriteLine($"Приближенное значение числа π: {pi}");
            }
            catch
            {
                Console.WriteLine("Вы ввели неправильное значение!");
            }
            Console.WriteLine("Нажмите Enter, чтобы закончить выполнение программы.");
            Console.Read();
        }
    }
}