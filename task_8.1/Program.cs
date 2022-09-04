using System;
using System.Collections.Generic;

namespace task_8._1
{
    class Program
    {
        /// <summary>
        /// Выводит в консоль все элементы коллекции
        /// </summary>
        /// <param name="numbers"></param>
        static void PrintAllNumbers(List<int> numbers)
        {
            int i = 1;
            foreach (int number in numbers)
            {
                Console.WriteLine($"{i++}. {number}");
            }
        }

        /// <summary>
        /// Инициализирует все элементы коллекции рандомными числами от 0 до maxRandomValue
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="maxRandomValue"></param>
        /// <returns></returns>
        static List<int> InitializeList(List<int> numbers, int maxRandomValue)
        {
            Random randomizer = new Random();
            int sizeOfList = numbers.Capacity;

            for (int i = 0; i < sizeOfList; i++)
            {
                numbers.Add(randomizer.Next(maxRandomValue + 1));
            }
            return numbers;
        }

        /// <summary>
        /// Удаляет из коллекции все элементы из диапазона от minValue до maxValue
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        static List<int> RemoveNumbersInRange(List<int> numbers, int minValue, int maxValue)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > minValue && numbers[i] < maxValue)
                {
                    numbers.RemoveAt(i--);
                }
            }

            return numbers;
        }

        static void Main(string[] args)
        {
            int maxRandomValue = 100, sizeOfList = 100;
            List<int> numbers = new List<int>(sizeOfList);

            numbers = InitializeList(numbers, maxRandomValue);

            Console.WriteLine("Первоначальная коллекция");
            PrintAllNumbers(numbers);

            int minValue = 25, maxValue = 50;
            numbers = RemoveNumbersInRange(numbers, minValue, maxValue);

            Console.WriteLine("\nИзмененная коллекция");
            PrintAllNumbers(numbers);
        }
    }
}
