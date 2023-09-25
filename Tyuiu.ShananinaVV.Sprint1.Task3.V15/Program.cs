using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ShananinaVV.Sprint1.Task3.V15.Lib;

namespace Tyuiu.ShananinaVV.Sprint1.Task3.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Шананина В. В. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнила: Шананина Валерия Викторовна | ИСТНб-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x;

            Console.WriteLine("Введите скорость первого автомобиля (V1 км/ч):");
            x = Convert.ToInt32(Console.ReadLine());

            int y;

            Console.WriteLine("Введите скорость второго автомобиля (V2 км/ч):");
            y = Convert.ToInt32(Console.ReadLine());

            int z;

            Console.WriteLine("Введите на каком расстоянии автомобили находятся друг от друга (S км):");
            z = Convert.ToInt32(Console.ReadLine());

            int w;

            Console.WriteLine("Введите через сколько часов (T) пути нужно узнать расстояние:");
            w = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Расстояние между автомобилями через T часов (в км) = " + ds.DistanceOverTime(x, y, z, w));

            Console.ReadKey();
        }
    }
}
