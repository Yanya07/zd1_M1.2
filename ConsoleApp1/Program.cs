using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива N: ");// Ввод размера массива N
            int N = int.Parse(Console.ReadLine());
            double[] array = new double[N];// Создание массива с размером N
            Console.WriteLine("Введите элементы массива:");// Ввод элементов массива
            for (int i = 0; i < N; i++)
            {
                Console.Write($"Элемент {i + 1}: ");
                array[i] = double.Parse(Console.ReadLine());
            }
            double maxElement = Math.Abs(array[0]);// Поиск максимального по модулю элемента
            for (int i = 1; i < N; i++)
            {
                if (Math.Abs(array[i]) > maxElement)
                {
                    maxElement = Math.Abs(array[i]);
                }
            }
            for (int i = 0; i < N; i++)// Нормирование элементов массива
            {
                array[i] /= maxElement;
            }

            Console.WriteLine("Нормированные значения элементов массива:");
            foreach (double element in array)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Нажмите Enter, чтобы закрыть программу.");
            Console.ReadLine();
        }
    }
}
