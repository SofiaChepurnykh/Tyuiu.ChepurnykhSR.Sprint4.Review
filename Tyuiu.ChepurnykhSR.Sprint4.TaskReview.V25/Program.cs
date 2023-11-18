using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ChepurnykhSR.Sprint4.TaskReview.V25.Lib;

namespace Tyuiu.ChepurnykhSR.Sprint4.TaskReview.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Чепурных С. Р. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #4                                                                *");
            Console.WriteLine("* Тема:                                                                   *");
            Console.WriteLine("* Задание #Revie                                                          *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнила: Чепурных Софья Романовна | ИСТНб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр 348561792486. Преобразуйте ее в       *");
            Console.WriteLine("* матрицу 4 на 3 и подсчитайте сумму четных чисел.                        *");
            Console.WriteLine("                                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int n = 4; int m = 3;
            int[,] mtrx = new int[n, m];
            string str = "348561792486";
            int index = 0;
            Console.WriteLine("\nМассив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{str[index]} \t ");
                    index++;
                }

                Console.WriteLine();
            }
            Console.WriteLine();



            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                           *");
            Console.WriteLine("****************************************************************************************");

            Console.WriteLine("Произведение четных чисел:  " + ds.Calculate(n, m, str));

            Console.ReadKey();
        }
    }
}
