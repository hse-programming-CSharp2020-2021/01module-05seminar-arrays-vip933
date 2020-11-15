using System;
namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTask04();
        }

        public static void RunTask04()
        {
            int N = int.Parse(Console.ReadLine());
            long a = int.Parse(Console.ReadLine());
            long d = int.Parse(Console.ReadLine());
            long[] array = new long[N];
            for (int count = 0; count < N; ++count)
                array[count] = a + count * d;
            foreach (long elem in array)
                Console.Write(elem + " ");
            Console.Write("\n");
        }
    }
}
