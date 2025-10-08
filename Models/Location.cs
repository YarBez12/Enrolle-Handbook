using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolleeHandbook.Models
{
    public class Location
    {
        internal static List<string> allCities = new List<string>
        {
            "Kyiv", "Sevastopol", "Vinnytsia", "Lutsk", "Dnipro", "Donetsk",
            "Zhytomyr", "Uzhhorod", "Zaporizhzhia", "Ivano-Frankivsk", "Kropyvnytskyi",
            "Luhansk", "Lviv", "Mykolaiv", "Odesa", "Poltava", "Rivne", "Sumy",
            "Ternopil", "Kharkiv", "Kherson", "Khmelnytskyi", "Cherkasy", "Chernivtsi", "Chernihiv"
        };
    private string city;
        private string street;
        private int number;
        private int code;

        public Location(string city = "Kharkiv",
            string street = "Nauky Avenue",
            int number = 14,
            int code = 61166)
        {
            this.city = city; 
            this.street = street;
            this.number = number;
            this.code = code;
        }

        public string City
        {
            get => city;
            set
            {
                foreach (string current_city in allCities)
                {
                    if (value == current_city)
                    {
                        city = current_city;
                    }
                }
            }
        }

        public string Street
        {
            get => street;
            set
            {
                if (value.Length > 5)
                {
                    street = value;
                }
            }
        }

        public int Number
        {
            get => number;
            set
            {
                if (value > 0)
                {
                    number = value;
                }
            }
        }

        public int Code
        {
            get => code;
            set
            {
                if (value > 9999 && value < 100000)
                {
                    code = value;
                }
            }
        }

        public override string ToString()
        {
            return $"{city}, {street}, {number}, {code}";
        }
    }
}
