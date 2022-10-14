using System;

namespace task_number_four
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[100];
            Random rnd = new Random(DateTime.Now.Millisecond);

            int i;
            for (i = 0; i < mas.Length; i++)
            {
                int x = rnd.Next(1001);
                mas[i] = rnd.Next(2) == 0 ? x : -x;
            }

            Console.WriteLine("Чётные числа: ");
            for (i = 0; i < mas.Length; i++)
            {
                if (mas[i] % 2 == 0)
                {
                    Console.Write(mas[i] + ", ");
                }
            }
            Console.WriteLine("\nЧисла кратные 3: ");
            for (i = 0; i < mas.Length; i++)
            {
                if (mas[i] % 3 == 0)
                {
                    Console.Write(mas[i] + ", ");
                }
            }
            Console.WriteLine("\nСумма всех отрицательных чисел: ");

            int count = 0;
            for (i = 0; i < mas.Length; i++)
            {
                if (mas[i] < 0)
                {
                    count += mas[i];
                }
            }
            Console.Write(count);
        }
    }
}
