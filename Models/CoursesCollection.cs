using EnrolleeHandbook.Controller;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrolleeHandbook.Models
{
    public class CoursesCollection
    {
        internal List<Course> Items { get; set; }
        public CoursesCollection(List<University> universities) 
        {
            Items = new List<Course> { };
            foreach (University university in universities)
            {
                Items.AddRange(university.Courses);
            }
        }
        public CoursesCollection()
        {
            Items = new List<Course>(); 
        }

        public void SortItems(string criteria)
        {
            switch (criteria)
            {
                case "alphabet":
                    Items = Items.OrderBy(c => c.Name).ToList();
                    break;
                case "count of applicants":
                    Items = Items.OrderByDescending(c => c.NumberOfApplicants).ToList();
                    break;
                case "point":
                    Items = Items.OrderBy(c => c.Point).ToList();
                    break;
                case "fee":
                    Items = Items.OrderBy(c => c.Fee).ToList();
                    break;
                case "area":
                    Items = Items.OrderBy(c => c.Area).ToList();
                    break;
            }
        }

        public List<Course> FindCourses(string name, string studyingForm, float minPoint, string number)
        {
            var rezult = new List<Course>();
            foreach (Course course in Items)
            {
                if (course.Name.ToLower().Contains(name.ToLower()) &&
                    course.StudyingForm.ToLower().Contains(studyingForm.ToLower()) &&
                    ((course.Number / 100 == 0) ? ("0" + course.Number.ToString()) : course.Number.ToString()).Contains(number) &&
                    course.Point >= minPoint)
                {
                    rezult.Add(course);
                }
            }

            return rezult;
        }

        public void RemoveCourse(Course course)
        {
            Items.Remove(course);
        }

        public void WriteInformationToFile(StreamWriter writer)
        {
            foreach (Course course in Items)
            {
                course.WriteInformationToFile(writer);
                writer.WriteLine("----------------------------");
                writer.WriteLine();
            }
        }

        public void AddCourse(Course course, Course oldCourse = null)
        {
            string coursePattern = @"^[а-яА-ЯҐґЄєІіЇї\s-.,]+$";
            string numberPattern = @"^[0-2][0-9]{2}$";
            string areaPattern = @"^[а-яА-ЯҐґЄєІіЇї\s-,]+$";
            foreach (Course currentCourse in Items)
            {
                if (currentCourse.Name == course.Name &&
                    currentCourse.StudyingForm == course.StudyingForm &&
                    currentCourse.University == course.University &&
                    oldCourse != currentCourse)
                {
                    throw new ArgumentException("Така спеціальність вже існує в даному університеті");
                }
            }
            if (!Regex.IsMatch(course.Name, coursePattern))
            {
                throw new ArgumentException("Ви ввели неправильну спеціальність");
            }
            if (!Regex.IsMatch((course.Number / 100 == 0) ? ('0' + course.Number.ToString()) : course.Number.ToString(), numberPattern))
            {
                throw new ArgumentException("Ви ввели неправильний номер спеціальності");
            }
            if (!Regex.IsMatch(course.Area, areaPattern))
            {
                throw new ArgumentException("Ви ввели неправильну галузь знань");
            }
            Items.Add(course);
            course.Added = true;
        }
    }
}
