using System;
using System.Collections.Generic;

namespace task_8._3
{
    class Program
    {
        static HashSet<int> AddNewElements(HashSet<int> numbers)
        {
            Console.WriteLine("Ввод будет продолжаться, пока не будет введена пустая строка.");
            while (true)
            {
                Console.WriteLine("\nВведите новое число");

                string inputNumber = Console.ReadLine();
                if (inputNumber == "") break;

                if (numbers.Add(int.Parse(inputNumber)))
                {
                    Console.WriteLine("Число успешно сохранено");
                }
                else Console.WriteLine("Число уже вводилось ранее");
            }
            return numbers;
        }

        static void Main(string[] args)
        {
            HashSet<int> numbers = new HashSet<int>();
            numbers = AddNewElements(numbers);
        }
    }
}
