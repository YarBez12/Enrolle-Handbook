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

        public Course(string name = "Інженерія програмного забезпечення",
            int number = 121,
            string area = "Інформаційні технології",
            int numberOfApplicants = 200,
            float point = 161f,
            string studyingForm = "Денна",
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
            Note = "Нотатки";
            Coefficients = coefficients ?? new Dictionary<string, float> {
                {"Математика", 0.4f },
                {"Українська мова", 0.1f },
                {"Історія України", 0.1f },
                {"Іноземна мова", 0.3f },
                {"Фізика", 0.4f },
                {"Хімія", 0.2f },
                {"Біологія", 0.2f },
                {"Географія", 0.2f },
                {"Українська література", 0.2f },
            };
            University = "Харківський національний університет радіоелектроніки";
            DisplayState = $"{name}: {StudyingForm}";
            Added = false;
        }

        public void WriteInformationToFile(StreamWriter writer)
        {
            string stringNumber = (Number / 100 == 0) ? ('0' + Number.ToString()) : Number.ToString();
            writer.WriteLine($"{stringNumber} {Name}");
            writer.WriteLine();
            writer.WriteLine($"Галузь знань: {Area}");
            writer.WriteLine($"Кількість абітурієнтів минулого року: {NumberOfApplicants}");
            writer.WriteLine($"Конкурсний бал: {Point}");
            writer.WriteLine($"Форма навчання: {StudyingForm}");
            writer.WriteLine($"Плата за контракт на рік: {Fee}");
            writer.WriteLine();
            writer.WriteLine("Таблиця коефіцієнтів");
            foreach (KeyValuePair<string, float> coefficient in Coefficients)
            {
                writer.WriteLine($"{coefficient.Key}: {coefficient.Value}");
            }
            writer.WriteLine();
            if (Note != "Нотатки")
            {
                writer.WriteLine("Нотатки");
                writer.WriteLine(Note);
            }
        }
    }
}
