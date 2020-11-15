using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTask05();
        }

        public static void RunTask05()
        {
            int N = int.Parse(Console.ReadLine());
            long[] array = new long[N];
            Result(ref array);
            for (int count = N - 1; count >= 0; --count)
                Console.Write(array[count] + " ");
            Console.Write("\n");
        }

        public static void Result(ref long[] array)
        {
            array[0] = 1;
            array[1] = 1;
            for (int elem = 2; elem < array.Length; ++elem)
                array[elem] = array[elem - 1] + array[elem - 2];
        }
    }
}
