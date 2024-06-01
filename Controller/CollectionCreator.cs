using EnrolleeHandbook.Forms;
using EnrolleeHandbook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrolleeHandbook.Controller
{
    internal class CollectionCreator
    {
        internal static UniversitiesCollection CreateSavedUniversitiesCollection(UniversitiesCollection universitiesCollection)
        {
            UniversitiesCollection rezult = new UniversitiesCollection();
            foreach (University university in universitiesCollection.Items)
            {
                if (university.Saved)
                {
                    rezult.Items.Add(university);
                }
            }
            return rezult;
        }


        internal static CoursesCollection CreateSavedCoursesCollection(UniversitiesCollection universitiesCollection)
        {
            CoursesCollection rezult = new CoursesCollection();
            foreach (University university in universitiesCollection.Items)
            {
                foreach (Course course in university.Courses)
                {
                    if (course.Saved)
                    {
                        rezult.Items.Add(course);
                    }
                }
            }
            return rezult;
        }
    }
}
