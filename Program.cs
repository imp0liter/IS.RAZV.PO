using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp4
{
    class Program
    {
        public static void log(string message)
        {
            try
            {
                File.AppendAllText("E:\\log.txt", message);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found!");
            }
        }

        static void Main(string[] args)
        {
            int R, res;
            int M0 = 0;
            int M1 = 0;
            int[] a = new int[8];
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"Введите {i}-й элемент ", i + 1);
                a[i] = int.Parse(Console.ReadLine());
                log("В Массив добавлен элемент: " + a[i] + '\n'); // лог
                if (a[i] % 2 == 0 && a[i] > M0) { M0 = a[i]; } // проверка на нечётность
                if (a[i] != 0 && a[i] > 0) { M1 = a[i]; } // проверка на положительное число
            }
            if (M0 > 0 && M1 > 0) { res = M0 + M1; } else { res = -1; } // проверка соответствию условиям задания
            R = res;
            if (res > 0) { Console.WriteLine($"Вычисленное контрольное значение: " + res);
                log($"Вычисленное контрольное значение: " + res + '\n'); } // лог
            if (R > 0 && R == res) { Console.WriteLine("Контроль пройден");
                log("Контроль пройден" + '\n'); // лог
                                    Console.ReadKey(); }
            else { Console.WriteLine("Контроль не пройден");
                log("Контроль не пройден" + '\n'); // лог
                                    Console.ReadKey(); }
        }
    }
}
