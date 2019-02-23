using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xml_and_Json_homework
{
    public struct ResidentialAddress
    {
        public string City { get; set; }
        public string StreetName { get; set; }
        public int HouseNumber { get; set; }
        public int ApartmentNumber { get; set; }

        public ResidentialAddress(string city, string streetName, int houseNumber, int apartmentNumber)
        {
            City = city;
            StreetName = streetName;
            HouseNumber = houseNumber;
            ApartmentNumber = apartmentNumber;
        }
    }
    class UserData
    {
        public string Name { get; set; }
        public string SurName { get; set; }

        private ResidentialAddress _residentialAddress;

        public string[] telephone;

        public UserData(string name, string surname, ResidentialAddress residentialAddress, string homeNumber, string workNumber)
        {
            Name = name;
            SurName = surname;
            _residentialAddress = residentialAddress;

            telephone = new string[] { homeNumber, workNumber };
        }

        public void ShowUserData()
        {
            Console.WriteLine("Имя: " + Name + "\n" +
                "Фамилия: " + SurName + "\n" +
                "Адрес проживания:\n" +
                "   город: " + _residentialAddress.City + "\n" +
                "   улица: " + _residentialAddress.StreetName + "\n" +
                "   дом: " + _residentialAddress.HouseNumber + "\n" +
                "   квартира: " + _residentialAddress.ApartmentNumber +
                "\n телефоны: " + telephone[0] + ", " + telephone[1]);
        }
    }
}

