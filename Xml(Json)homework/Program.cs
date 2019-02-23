using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xml_and_Json_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();

            Console.WriteLine("Введите фамилию: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Введите адрес проживания: ");

            Console.WriteLine("город: ");
            string city = Console.ReadLine();

            Console.WriteLine("улица: ");
            string street = Console.ReadLine();

            Console.WriteLine("дом: ");
            int houseNum = int.Parse(Console.ReadLine());

            Console.WriteLine("квартира: ");
            int apartamentNum = int.Parse(Console.ReadLine());

            ResidentialAddress residentialAddress = new ResidentialAddress(city, street, houseNum, apartamentNum);

            Console.WriteLine("домашний телефон: ");
            string housePhone = Console.ReadLine();

            Console.WriteLine("рабочий телефон: ");
            string workPhone = Console.ReadLine();

            UserData userData1 = new UserData(name, surname, residentialAddress, housePhone, workPhone);

            userData1.ShowUserData();

            Console.ReadLine();

        }
    }
}
