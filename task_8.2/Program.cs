using System;
using System.Collections.Generic;

namespace task_8._2
{
    class Program
    {
        /// <summary>
        /// Добавляет новые контакты, пока не будет введена пустая строка
        /// </summary>
        /// <param name="phoneBook"></param>
        /// <returns></returns>
        static Dictionary<string, string> AddNewContacts(Dictionary<string, string> phoneBook)
        {
            Console.WriteLine("Ввод будет продолжаться, пока не будет введена пустая строка.");
            while (true)
            {
                Console.WriteLine("\nВведите информацию о новом контакте");

                Console.WriteLine("Введите Ф.И.О: ");
                string fullName = Console.ReadLine();
                if (fullName == "") break;

                Console.WriteLine("Введите номер телефона: ");
                string phoneNumber = Console.ReadLine();
                if (phoneNumber == "") break;

                phoneBook.Add(phoneNumber, fullName);
            }
            return phoneBook;
        }

        /// <summary>
        /// Находит и возвращает ФИО контакта по номеру телефона. 
        /// </summary>
        /// <param name="phoneBook"></param>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        static string FindContact(Dictionary<string, string> phoneBook, string phoneNumber)
        {
            string neededContactName;
            bool contactExists = phoneBook.TryGetValue(phoneNumber, out neededContactName);

            if (contactExists) return neededContactName;
            else return "";
        }

        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            phoneBook = AddNewContacts(phoneBook);

            Console.WriteLine("Поиск по номеру телефона\nВведите номер искомого контакта:");
            string phoneNumber = Console.ReadLine();

            string foundName = FindContact(phoneBook, phoneNumber);
            if (foundName != "") Console.WriteLine(foundName);
            else Console.WriteLine("Контакта с введенным номером не существует.");
        }
    }
}
