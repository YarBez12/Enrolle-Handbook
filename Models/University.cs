using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolleeHandbook.Models
{
    public class University
    {
        public string Name { get; private set; }
        public Location Address { get; private set; }
        public int Rating { get; private set; }
        public int CorsesCount { get; internal set; }
        public float AveragePoint { get; internal set; }
        public string StringAveragePoint { get; internal set; }
        public float MinimumPoint { get; internal set; }
        public int FoundationYear { get; private set; }
        public bool IsWithHostel { get; private set; }
        public string Site { get; private set; }
        public int AverageFee { get; internal set; }
        public List<Course> Courses { get; private set; }
        public bool Saved { get; set; }
        public bool Added { get; set; }

        public University(List<Course> courses,
            string name = "Харківський національний університет радіоелектроніки",
            Location address = null, 
            int rating = 1000,  
            int foundationYear = 2000, 
            bool isWithHostel = false, 
            string site = "https://nure.ua/")
        {
            Name = name;
            Address = address ?? new Location();
            Rating = rating;
            FoundationYear = foundationYear;
            IsWithHostel = isWithHostel;
            Site = site;
            Courses = courses;
            CorsesCount = Courses.Count;
            if (CorsesCount > 0)
            {
                AveragePoint = CountAveragePoint();
                MinimumPoint = CountMinimumPoint();
                AverageFee = CountAverageFee();
            }
            else
            {
                AveragePoint = 0;
                MinimumPoint = 0;
                AverageFee = 0;
            }
            StringAveragePoint = AveragePoint.ToString("0.##");

            Saved = false;
            Added = false;

            SetUniversityNameToCourses();
        }

        private float CountAveragePoint()
        {
            float points = 0;
            foreach (Course course in Courses)
            {
                points += course.Point;
            }
            return points / (float)CorsesCount; 
        }

        private float CountMinimumPoint()
        {
            float minPoint = 0;
            foreach (Course course in Courses)
            {
                if (course.Point < minPoint || minPoint == 0)
                {
                    minPoint = course.Point;
                }
            }
            return minPoint;
        }

        private int CountAverageFee()
        {
            int fees = 0;
            foreach (Course course in Courses)
            {
                fees += course.Fee;
            }
            return fees / CorsesCount;
        }

        private void SetUniversityNameToCourses()
        {
            foreach (Course course in Courses)
            {
                course.University = Name;
            }
        }

        public void WriteInformationToFile(StreamWriter writer)
        {
            writer.WriteLine(Name);
            writer.WriteLine($"Адреса: {Address.ToString()}");
            writer.WriteLine($"Рейтинг: {Rating}");
            writer.WriteLine($"Кількість спеціальностей: {CorsesCount}");
            writer.WriteLine($"Середній конкурсний бал: {StringAveragePoint}");
            writer.WriteLine($"Мінімальний конкурсний бал: {MinimumPoint.ToString("0.##")}");
            writer.WriteLine($"Рік заснування: {FoundationYear}");
            writer.WriteLine(IsWithHostel ? "Наявний гуртожиток" : "Гуртожитку немає");
            writer.WriteLine($"Веб-сайт: {Site}");
            writer.WriteLine();
            writer.WriteLine("Спеціальності:");
            new CoursesCollection(new List<University> {this}).WriteInformationToFile(writer);
        }

        public void AddCourse(Course course)
        {
            Courses.Add(course);
            CorsesCount += 1;
            AveragePoint = CountAveragePoint();
            MinimumPoint = CountMinimumPoint();
            AverageFee = CountAverageFee();
            StringAveragePoint = AveragePoint.ToString("0.##");
        }

        public void DeleteCourse(Course course)
        {
            Courses.Remove(course);
            CorsesCount -= 1;
            AverageFee = CorsesCount == 0 ? 0 : CountAverageFee();
            AveragePoint = CorsesCount == 0 ? 0 : CountAveragePoint();
            MinimumPoint = CorsesCount == 0 ? 0 : CountMinimumPoint();
            StringAveragePoint = AveragePoint.ToString();
        }
    }
}
