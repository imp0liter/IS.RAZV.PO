using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace gigadolg
{
    class Program
    {
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
                if (a[i] % 2 == 0 && a[i] > M0) { M0 = a[i]; } // проверка на нечётность
                if (a[i] != 0 && a[i] > 0) { M1 = a[i]; } // проверка на положительное число
            }
            if (M0 > 0 && M1 > 0) { res = M0 + M1; } else { res = -1; } // проверка соответствию условиям задания
            R = res;
            if (res > 0)    { Console.WriteLine($"Вычисленное контрольное значение: " + res); }
            if (R > 0 && R == res) { Console.WriteLine("Контроль пройден"); Console.ReadKey(); }
            else { Console.WriteLine("Контроль не пройден"); Console.ReadKey(); }

        }      
    }
}   
    

