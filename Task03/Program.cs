using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices.ComTypes;

/*
 * Пользователем с клавиатуры вводится целое число N > 0.
 * В программе сформировать и вывести на экран целочисленный массив из N элементов,
 * элементами которого являются нечетные числа от 1.
 * Заполнение массива нечётными числами организовать при помощи метода.​
 *
 * Пример входных данных:
 * 7
 *
 * Пример выходных данных:
 * 1 3 5 7 9 11 13
 */

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTask03();
        }

        public static void RunTask03()
        {
            int N = int.Parse(Console.ReadLine());
            long[] array = new long[N];
            FillArray(ref array);
            foreach (long elem in array)
                Console.Write(elem + " ");
            Console.Write("\n");
        }

        static void FillArray(ref long[] array)
        {
            for (int elem = 0; elem < array.Length; ++elem)
                array[elem] = 2 * elem + 1;
        }
    }
}
