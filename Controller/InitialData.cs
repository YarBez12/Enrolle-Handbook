using EnrolleeHandbook.Controller;
using EnrolleeHandbook.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrolleeHandbook.Controller
{
    internal class InitialData
    {
        internal static string filePath = "allUniversities.json";


        internal static UniversitiesCollection initUniversitiesCollection =
        JsonController.LoadData(filePath) ?? new UniversitiesCollection();

        internal static UniversitiesCollection initSavedUniversitiesCollection =
            CollectionCreator.CreateSavedUniversitiesCollection(initUniversitiesCollection);

        internal static CoursesCollection initCoursesCollection =
            new CoursesCollection(initUniversitiesCollection.Items ?? new List<University>());

        internal static CoursesCollection initSavedCoursesCollection =
            CollectionCreator.CreateSavedCoursesCollection(initUniversitiesCollection);


        internal static bool isPreviousSaved = false;
        internal static bool isPreviousCourse = false;
    }
}
