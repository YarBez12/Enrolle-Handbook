using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrolleeHandbook.Models
{
    public class Course
    {
        public string Name { get; private set; }
        public string University { get; internal set; }
        public int Number { get; private set; }
        public string Area { get; private set; }
        public int NumberOfApplicants { get; private set; }
        public float Point { get; private set; }
        public string StudyingForm { get; private set; }
        public int Fee { get; private set; }
        public bool Saved { get; set; }
        public Dictionary<string, float> Coefficients { get; private set; }
        public string Note { get; set; }
        public string DisplayState { get; internal set; }
        public bool Added { get; set; }

        public Course(string name = "Software Engineering",
            int number = 121,
            string area = "Information Technologies",
            int numberOfApplicants = 200,
            float point = 161f,
            string studyingForm = "Full-time",
            int fee = 32000,
            Dictionary<string, float> coefficients = null)
        {
            Name = name;
            Number = number;
            Area = area;
            NumberOfApplicants = numberOfApplicants;
            Point = point;
            StudyingForm = studyingForm;
            Fee = fee;
            Saved = false;
            Note = "Notes";
            Coefficients = coefficients ?? new Dictionary<string, float> {
                 {"Mathematics", 0.4f },
                 {"Ukrainian language", 0.1f },
                 {"History of Ukraine", 0.1f },
                 {"Foreign language", 0.3f },
                 {"Physics", 0.4f },
                 {"Chemistry", 0.2f },
                 {"Biology", 0.2f },
                 {"Geography", 0.2f },
                 {"Ukrainian literature", 0.2f },
             };
            University = "Kharkiv National University of Radio Electronics";
            DisplayState = $"{name}: {StudyingForm}";
            Added = false;
        }

        public void WriteInformationToFile(StreamWriter writer)
        {
            string stringNumber = (Number / 100 == 0) ? ('0' + Number.ToString()) : Number.ToString();
            writer.WriteLine($"{stringNumber} {Name}");
            writer.WriteLine();
            writer.WriteLine($"Field of study: {Area}");
            writer.WriteLine($"Number of applicants last year: {NumberOfApplicants}");
            writer.WriteLine($"Competitive score: {Point}");
            writer.WriteLine($"Form of study: {StudyingForm}");
            writer.WriteLine($"Tuition fee per year: {Fee}");
            writer.WriteLine();
            writer.WriteLine("Coefficient table");
            foreach (KeyValuePair<string, float> coefficient in Coefficients)
            {
                writer.WriteLine($"{coefficient.Key}: {coefficient.Value}");
            }
            writer.WriteLine();
            if (Note != "Notes")
            {
                writer.WriteLine("Notes");
                writer.WriteLine(Note);
            }
        }
    }
}
