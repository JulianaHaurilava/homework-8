using System;
using System.Xml.Linq;

namespace task_8._4
{
    class Program
    {
        /// <summary>
        /// Получает информацию о новом контакте
        /// </summary>
        static void SetContactInfo()
        {
            Console.WriteLine("Введите информацию о новом контакте\n");

            Console.WriteLine("Введите Ф.И.О.");
            string fullName = Console.ReadLine();
            Console.WriteLine("Введите название улицы");
            string streetName = Console.ReadLine();
            Console.WriteLine("Введите номер дома");
            int houseNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер квартиры");
            int flatNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите мобильный телефон");
            long mobilePhone = long.Parse(Console.ReadLine());
            Console.WriteLine("Введите домашний телефон");
            int flatPhone = int.Parse(Console.ReadLine());

            AddNewContactToXML(fullName, streetName, houseNumber, flatNumber, mobilePhone, flatPhone);
        }

        /// <summary>
        /// Записывает информацию о контакте в XML файл
        /// </summary>
        /// <param name="fullName"></param>
        /// <param name="streetName"></param>
        /// <param name="houseNumber"></param>
        /// <param name="flatNumber"></param>
        /// <param name="mobilePhone"></param>
        /// <param name="flatPhone"></param>
        static void AddNewContactToXML(string fullName, string streetName, int houseNumber,
                                       int flatNumber, long mobilePhone, int flatPhone)
        {
            XElement myPERSON = new XElement("Person", new XAttribute("name", fullName));

            XElement myADDRESS = new XElement("Address",
                                              new XElement("Street", streetName),
                                              new XElement("HouseNumber", houseNumber),
                                              new XElement("FlatNumber", flatNumber));

            XElement myPHONE = new XElement("Phones",
                                           new XElement("MobilePhone", mobilePhone),
                                           new XElement("FlatPhone", flatPhone));

            myPERSON.Add(myADDRESS, myPHONE);

            myPERSON.Save("_myPerson.xml");
        }
        static void Main(string[] args)
        {
            SetContactInfo();
        }
    }
}
