using EnrolleeHandbook.Controller;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrolleeHandbook.Models
{
    public class UniversitiesCollection
    {
        public List<University> Items { get; set; }

        public UniversitiesCollection(List<University> universities)
        {
            Items = universities;
        }

        public UniversitiesCollection()
        {
            Items = new List<University>();
        }

        public void SortItems(string criteria)
        {
            switch (criteria)
            {
                case "alphabet":
                    Items = Items.OrderBy(u => u.Name).ToList();
                    break;
                case "count of courses":
                    Items = Items.OrderByDescending(u => u.CorsesCount).ToList();
                    break;
                case "average point":
                    Items = Items.OrderBy(u => u.AveragePoint).ToList();
                    break;
                case "average fee":
                    Items = Items.OrderBy(u => u.AverageFee).ToList();
                    break;
                case "rating":
                    Items = Items.OrderBy(u => u.Rating).ToList();
                    break;
            }
        }

        public List<University> FindUniversities(string name, string course, string city)
        {
            var rezult = new List<University>();
            foreach (University univercity in Items)
            {
                if (univercity.Name.ToLower().Contains(name.ToLower()) &&
                    univercity.Address.City.ToLower().Contains(city.ToLower()))
                {
                    foreach (Course current_course in univercity.Courses)
                    {
                        if (current_course.Name.ToLower().Contains(course.ToLower()))
                        {
                            rezult.Add(univercity);
                            break;
                        }
                    }
                }
            }

            return rezult;
        }

        public void AddUniversity(University university, University oldUniversity = null)
        {
            string universityPattern = @"^[а-яА-ЯҐґЄєІіЇї\s""-.,]+$";
            string streetPattern = @"^[а-яА-ЯҐґЄєІіЇї\s""-.,]+$";
            string sitePattern = @"^(https?://)?([a-zA-Z0-9-]+\.)+[a-zA-Z]{2,6}(\/[a-zA-Z0-9#-_.]*)?$";
            foreach (University currentUniversity in Items)
            {
                if (currentUniversity.Name == university.Name &&
                    currentUniversity != oldUniversity)
                {
                    throw new ArgumentException("Такий університет вже існує");
                }
            }
            if (!Regex.IsMatch(university.Name, universityPattern))
            {
                throw new ArgumentException("Ви ввели неправильний університет");
            }
            if (university.Address.City == "")
            {
                throw new ArgumentException("Не обрано жодне місто");
            }
            if (!Regex.IsMatch(university.Address.Street, streetPattern))
            {
                throw new ArgumentException("Ви ввели неправильну вулицю");
            }
            if (!Regex.IsMatch(university.Site, sitePattern))
            {
                throw new ArgumentException("Ви ввели неправильний сайт");
            }
            Items.Add(university);
            university.Added = true;

        }


        public void RemoveUniversity(University university)
        {
            Items.Remove(university);
        }

        public void WriteInformationToFile(StreamWriter writer)
        {
            foreach (University university in Items)
            {
                university.WriteInformationToFile(writer);
                writer.WriteLine();
                writer.WriteLine();
                writer.WriteLine("****************************");
                writer.WriteLine();
                writer.WriteLine();
            }
        }
    }
}
