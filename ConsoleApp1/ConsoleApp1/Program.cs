using System;

namespace DZ_4
{
    class Program
    {

        static void Main(string[] args)
        {
            double result = 0; /// int result = 0; для целочисленных чисел
            Random r = new Random();
            Console.Write("Размер массива N = ");
            string number = Console.ReadLine();
            int n = int.Parse(number);
            /*  int[] array = new int[n];*////// целочисленный массив
            double[] array = new double[n];
            int min = 0;


            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(-10, 10);//*//рандом от -10 до 10 целочисленный
                                           //     array[i] = (Math.Round((r.NextDouble() - 0.5) * 100)) / 10;
                Console.Write(array[i] + "  ");
                if (array[min] > array[i])
                    min = i;

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Минимальный элемент = {0}", array[min]);

            int first = -1, last = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    first = i;
                    break;
                }

            }
            Console.WriteLine("Минимальный элемент {0}  с индексом {1}", array[min], min);
        }
    }
}