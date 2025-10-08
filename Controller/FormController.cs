using EnrolleeHandbook.Forms;
using EnrolleeHandbook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using System.IO;

namespace EnrolleeHandbook.Controller
{
    internal class FormController
    {
        internal static void RadioButtonCheckedChanged(string criteria, CoursesCollection collection, CoursesCollection tempCollection, BindingSource bindingSource)
        {
            collection.SortItems(criteria);
            if (tempCollection.Items.Count > 0)
            {
                tempCollection.SortItems(criteria);
                bindingSource.DataSource = tempCollection.Items;
            }
            else
            {
                bindingSource.DataSource = collection.Items;

            }
        }

        internal static void RadioButtonCheckedChanged(string criteria, UniversitiesCollection collection, UniversitiesCollection tempCollection, BindingSource bindingSource)
        {
            collection.SortItems(criteria);
            if (tempCollection.Items.Count > 0)
            {
                tempCollection.SortItems(criteria);
                bindingSource.DataSource = tempCollection.Items;
            }
            else
            {
                bindingSource.DataSource = collection.Items;

            }
        }

        internal static void ChangeSelectedCourseByBox(DataGridView dataGridView)
        {
            Course selectedRow = dataGridView.CurrentRow.DataBoundItem as Course;
            if (!selectedRow.Saved)
            {
                selectedRow.Saved = true;
                InitialData.initSavedCoursesCollection.Items.Add(selectedRow);

            }
            else
            {
                selectedRow.Saved = false;
                InitialData.initSavedCoursesCollection.Items.Remove(selectedRow);

            }
        }

        internal static void ChangeSelectedUniversityByBox (DataGridView dataGridView)
        {
            University selectedRow = dataGridView.CurrentRow.DataBoundItem as University;
            if (!selectedRow.Saved)
            {
                selectedRow.Saved = true;
                InitialData.initSavedUniversitiesCollection.Items.Add(selectedRow);
            }
            else
            {
                selectedRow.Saved = false;
                InitialData.initSavedUniversitiesCollection.Items.Remove(selectedRow);

            }
 
        }

        internal static string ChangeCourseSaved(Course course)
        {
            if (course.Saved)
            {
                InitialData.initSavedCoursesCollection.Items.Remove(course);
                course.Saved = false;
                return "Add to favorites";
            }
            else
            {
                InitialData.initSavedCoursesCollection.Items.Add(course);
                course.Saved = true;
                return "Remove from favorites";
            }
        }

        internal static string ChangeUniversitySaved(University university)
        {
            if (university.Saved)
            {
                InitialData.initSavedUniversitiesCollection.Items.Remove(university);
                university.Saved = false;
                return "Add to favorites";
            }
            else
            {
                InitialData.initSavedUniversitiesCollection.Items.Add(university);
                university.Saved = true;
                return "Remove from favorites";
            }
        }

        internal static void ShowPreviousFormByCourse(Course course)
        {
            if (InitialData.isPreviousCourse)
            {
                ShowPreviousCollectionByCourse();
            }
            else
            {
                ShowPreviousUniversityByCourse(course);
            }
        }

        internal static void ShowPreviousCollectionByCourse()
        {
            if (InitialData.isPreviousSaved)
            {
                var form = new CoursesCollectionForm(InitialData.initSavedCoursesCollection);
                form.Show();
            }
            else
            {
                var form = new CoursesCollectionForm(InitialData.initCoursesCollection);
                form.Show();
            }
        }

        internal static void ShowPreviousUniversityByCourse(Course course)
        {
            University appropriateUniversity;
            foreach (University university in InitialData.initUniversitiesCollection.Items)
            {
                if (university.Name == course.University)
                {
                    appropriateUniversity = university;
                    var form = new UniversityForm(appropriateUniversity);
                    form.Show();
                    break;
                }
            }
        }

        internal static void ShowPreviousFormByUniversity()
        {
            UniversitiesCollectionForm form;
            if (InitialData.isPreviousSaved)
            {
                form = new UniversitiesCollectionForm(InitialData.initSavedUniversitiesCollection);
            }
            else
            {
                form = new UniversitiesCollectionForm(InitialData.initUniversitiesCollection);
            }
            form.Show();
        }

        internal static void GoNextFromMain(string criteria)
        {
            Form form = new Form();
            switch (criteria)
            {
                case "all universities":
                    InitialData.isPreviousSaved = false;
                    InitialData.isPreviousCourse = false;
                    form = new UniversitiesCollectionForm(InitialData.initUniversitiesCollection);
                    break;
                case "saved universities":
                    InitialData.isPreviousSaved = true;
                    InitialData.isPreviousCourse = false;
                    form = new UniversitiesCollectionForm(InitialData.initSavedUniversitiesCollection);
                    break;
                case "all courses":
                    InitialData.isPreviousSaved = false;
                    InitialData.isPreviousCourse = true;
                    form = new CoursesCollectionForm(InitialData.initCoursesCollection);
                    break;
                case "saved courses":
                    InitialData.isPreviousSaved = true;
                    InitialData.isPreviousCourse = true;
                    form = new CoursesCollectionForm(InitialData.initSavedCoursesCollection);
                    break;
                case "calculator":
                    form = new CalculatorForm();
                    break;

            }
            form.Show();

        }

        internal static void FillComponentsWithData(CourseForm form)
        {
            form.Text = form.course.Name;
            form.universityNameLabel.Text = form.course.University;
            form.areaLabel.Text = form.areaLabel.Text + ": " + form.course.Area;
            form.nameLabel.Text = form.course.Name;
            form.numberLabel.Text = form.numberLabel.Text + ": " + ((form.course.Number / 100 == 0) ? ("0" + form.course.Number.ToString()) : form.course.Number.ToString());
            form.applicantsCountLabel.Text = form.applicantsCountLabel.Text + ": " + form.course.NumberOfApplicants;
            form.pointLabel.Text = form.pointLabel.Text + ": " + form.course.Point;
            form.studyingFormLabel.Text = form.studyingFormLabel.Text + ": " + form.course.StudyingForm;
            form.feeLabel.Text = form.feeLabel.Text + ": " + form.course.Fee;
            form.notesTextBox.Text = form.course.Note;
            string[] coef = Array.ConvertAll(form.course.Coefficients.Values.ToArray(), i => i.ToString());
            form.coefDataGridView.Rows.Add(coef);
            form.changeButton.Text = "Add to favorites";
            foreach (Course c in InitialData.initSavedCoursesCollection.Items)
            {
                if (c.Name == form.course.Name)
                {
                    form.changeButton.Text = "Remove from favorites";
                    break;
                }
            }
            if (!form.course.Added)
            {
                form.editButton.Visible = false;
                form.deleteButton.Visible = false;
            }
        }

        internal static void FillComponentsWithData(UniversityForm form)
        {
            form.Text = form.university.Name;
            form.nameLabel.Text = form.university.Name;
            form.adressLabel.Text = form.university.Address.ToString();
            form.rateLabel.Text = form.rateLabel.Text + ":" + form.university.Rating.ToString();
            form.coursesCountLabel.Text = form.coursesCountLabel.Text + ":" + form.university.CorsesCount.ToString();
            form.averagePointLabel.Text = form.averagePointLabel.Text + ":" + form.university.StringAveragePoint.ToString();
            form.minPointLabel.Text = form.minPointLabel.Text + ":" + form.university.MinimumPoint.ToString();
            form.foundYearLabel.Text = form.foundYearLabel.Text + ":" + form.university.FoundationYear.ToString();
            form.hostelLabel.Text = form.university.IsWithHostel ? "Dormitory available" : "No dormitory";
            form.webSiteLabel.Text = form.university.Site;
            form.courseBindingSource.DataSource = form.university.Courses;
            form.changeButton.Text = "Add to favorites";
            foreach (University un in InitialData.initSavedUniversitiesCollection.Items)
            {
                if (un.Name == form.university.Name)
                {
                    form.changeButton.Text = "Remove from favorites";
                    break;
                }
            }
            if (!form.university.Added)
            {
                form.deleteButton.Visible = false;
                form.editButton.Visible = false;
            }
        }

        internal static void FillComponentsWithData(AddCourseForm form, University university, Course course)
        {
            form.course = course;
            form.university = university;
            form.studyingFormComboBox.SelectedIndex = 0;
            if (course != null)
            {
                form.Text = form.course.Name;
                form.universityBindingSource.DataSource = InitialData.initUniversitiesCollection.Items;
                form.titleLabel.Text = form.course.Name;
                form.nameTextBox.Text = form.course.Name;
                form.universityComboBox.Text = form.course.University;
                form.numberTextBox.Text = form.course.Number / 100 == 0 ? "0" + form.course.Number : form.course.Number.ToString();
                form.areaTextBox.Text = form.course.Area;
                form.numberOfApplicantsNumericUpDown.Value = form.course.NumberOfApplicants;
                form.pointNumericUpDown.Value = (decimal)form.course.Point;
                form.studyingFormComboBox.Text = form.course.StudyingForm;
                form.feeNumericUpDown.Value = form.course.Fee;
                form.mathsNumericUpDown.Value = (decimal)form.course.Coefficients["Mathematics"];
                form.ukrLanguageNumericUpDown.Value = (decimal)form.course.Coefficients["Ukrainian language"];
                form.historyNumericUpDown.Value = (decimal)form.course.Coefficients["History of Ukraine"];
                form.forLanguageNumericUpDown.Value = (decimal)form.course.Coefficients["Foreign language"];
                form.physicsNumericUpDown.Value = (decimal)form.course.Coefficients["Physics"];
                form.chemistryNumericUpDown.Value = (decimal)form.course.Coefficients["Chemistry"];
                form.biologyNumericUpDown.Value = (decimal)form.course.Coefficients["Biology"];
                form.geographyNumericUpDown.Value = (decimal)form.course.Coefficients["Geography"];
                form.ukrLanguageNumericUpDown.Value = (decimal)form.course.Coefficients["Ukrainian literature"];
                form.addToSavedCheckBox.Checked = form.course.Saved;
            }
            form.universityBindingSource.DataSource = InitialData.initUniversitiesCollection.Items;
            if (!InitialData.isPreviousCourse && course == null)
            {
                form.universityComboBox.Text = university.Name;
                form.universityComboBox.Enabled = false;
            }
        }

        internal static void FillComponentsWithData(AddUniversityForm form, University university)
        {
            form.university = university;
            if (university != null)
            {
                form.Text = form.university.Name;
                form.titleLabel.Text = form.university.Name;
                form.nameTextBox.Text = form.university.Name;
                form.cityComboBox.Text = form.university.Address.City;
                form.streetTextBox.Text = form.university.Address.Street;
                form.buildingNumericUpDown.Text = form.university.Address.Number.ToString();
                form.indexNumericUpDown.Text = form.university.Address.Code.ToString();
                form.rateNumericUpDown.Text = form.university.Rating.ToString();
                form.foundationYearNumericUpDown.Value = form.university.FoundationYear;
                form.siteTextBox.Text = form.university.Site;
                form.addToSavedCheckBox.Checked = form.university.Saved;
                form.isWithHostelCheckBox.Checked = form.university.IsWithHostel;
            }
        }

        internal static string ShowSearchedUniversities(CoursesCollectionForm form)
        {
            string coursePattern = @"^[A-Za-z\s""\-,]+$";
            string studyingFormPattern = @"^[A-Za-z\s]+$";
            string numberPattern = @"^[0-9]+$";
            if (!Regex.IsMatch(form.nameTextBox.Text, coursePattern) && form.nameTextBox.Text != "")
            {
                return "You entered an invalid course";
            }
            if (!Regex.IsMatch(form.studyingFormTextBox.Text, studyingFormPattern) && form.studyingFormTextBox.Text != "")
            {
                return "You entered an invalid form of study";
            }
            if (!Regex.IsMatch(form.numberTextBox.Text, numberPattern) && form.numberTextBox.Text != "")
            {
                return "You entered an invalid course number";
            }
            form.tempCoursesCollection.Items = form.coursesCollection.FindCourses(form.nameTextBox.Text, form.studyingFormTextBox.Text, (float)form.minPointNumericUpDown.Value, form.numberTextBox.Text);
            form.courseBindingSource1.DataSource = form.tempCoursesCollection.Items;
            return string.Empty;
        }

        internal static string ShowSearchedUniversities(UniversitiesCollectionForm form)
        {
            string universityPattern = @"^[A-Za-z\s""\-.,]+$";
            string courseFormPattern = @"^[A-Za-z\s""\-,]+$";
            string cityPattern = @"^[A-Za-z\s]+$";
            if (!Regex.IsMatch(form.universityNameTextBox.Text, universityPattern) && form.universityNameTextBox.Text != "")
            {
                return "You entered an invalid university";
            }
            if (!Regex.IsMatch(form.courseNameTextBox.Text, courseFormPattern) && form.courseNameTextBox.Text != "")
            {
                return "You entered an invalid course";
            }
            if (!Regex.IsMatch(form.cityTextBox.Text, cityPattern) && form.cityTextBox.Text != "")
            {
                return "You entered an invalid city";
            }
            form.tempUniversitiesCollection.Items = form.universitiesCollection.FindUniversities(form.universityNameTextBox.Text, form.courseNameTextBox.Text, form.cityTextBox.Text);
            form.universityBindingSource.DataSource = form.tempUniversitiesCollection.Items;
            return string.Empty;
        }

        internal static void ResetSearch(CoursesCollection collection, CoursesCollection tempCollection, BindingSource bindingSource)
        {
            bindingSource.DataSource = collection.Items;
            tempCollection.Items.Clear();
        }
        internal static void ResetSearch(UniversitiesCollection collection, UniversitiesCollection tempCollection, BindingSource bindingSource)
        {
            bindingSource.DataSource = collection.Items;
            tempCollection.Items.Clear();
        }

        internal static void MakeCorrectView(CoursesCollectionForm form, CoursesCollection coursesCollection)
        {
            if (InitialData.isPreviousSaved)
            {
                form.Text = "List of saved courses";
            }
            else
            {
                form.Text = "List of courses";
            }
            form.coursesCollection = coursesCollection;
            form.coursesCollection.SortItems("alphabet");
            if (InitialData.isPreviousSaved)
            {
                form.allCoursesDataGridView.Columns[3].Visible = false;
            }
            form.courseBindingSource1.DataSource = form.coursesCollection.Items;
        }
        internal static void MakeCorrectView(UniversitiesCollectionForm form, UniversitiesCollection universitiesCollection)
        {
            if (InitialData.isPreviousSaved)
            {
                form.Text = "List of saved universities";
            }
            else
            {
                form.Text = "List of universities";
            }
            form.universitiesCollection = universitiesCollection;
            form.universitiesCollection.SortItems("alphabet");
            if (InitialData.isPreviousSaved)
            {
                form.allUniversitiesDataGridView.Columns[3].Visible = false;
            }

            form.universityBindingSource.DataSource = form.universitiesCollection.Items;
        }

        internal static CourseForm GoToCourse(DataGridView dataGridView)
        {
            Course selectedRow = dataGridView?.CurrentRow?.DataBoundItem as Course;
            if (selectedRow != null)
            {
                var form = new CourseForm(selectedRow);
                return form;
            }
            return null;
        }

        internal static UniversityForm GoToUniversity(DataGridView dataGridView)
        {
            University selectedRow = dataGridView?.CurrentRow?.DataBoundItem as University;
            if (selectedRow != null)
            {
                var form = new UniversityForm(selectedRow);
                return form;
            }
            return null;
        }

        internal static void SaveCourseInformation(Course course)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.Title = "Save course data";
                saveFileDialog.FileName = $"{course.Number} {course.Name}.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        course.WriteInformationToFile(writer);
                    }
                }
            }
        }

        internal static void SaveCoursesCollectionInformation()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                saveFileDialog.DefaultExt = "txt";
                if (InitialData.isPreviousSaved)
                {
                    saveFileDialog.Title = "Save list of saved courses";
                    saveFileDialog.FileName = $"Saved courses.txt";
                }
                else
                {
                    saveFileDialog.Title = "Save list of courses";
                    saveFileDialog.FileName = $"All courses.txt";
                }
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    CoursesCollection appropriateCoursesCollection = InitialData.isPreviousSaved ? InitialData.initSavedCoursesCollection : InitialData.initCoursesCollection;
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        appropriateCoursesCollection.WriteInformationToFile(writer);
                    }
                }
            }
        }

        internal static void SaveUniversityInformation(University university)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.Title = "Save university data";
                saveFileDialog.FileName = $"{university.Name}.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        university.WriteInformationToFile(writer);
                    }
                }
            }
        }

        internal static void SaveUniversityCollectionInformation()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                saveFileDialog.DefaultExt = "txt";
                if (InitialData.isPreviousSaved)
                {
                    saveFileDialog.Title = "Save list of saved universities";
                    saveFileDialog.FileName = $"Saved universities.txt";
                }
                else
                {
                    saveFileDialog.Title = "Save list of all universities";
                    saveFileDialog.FileName = $"All universities.txt";
                }
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    UniversitiesCollection appropriateUniversitiesCollection = InitialData.isPreviousSaved ? InitialData.initSavedUniversitiesCollection : InitialData.initUniversitiesCollection;
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        appropriateUniversitiesCollection.WriteInformationToFile(writer);
                    }
                }
            }
        }

        internal static University AddNewUniversity(AddUniversityForm form)
        {
            var university = new University(
                new List<Course>(), form.nameTextBox.Text,
                new Location(form.cityComboBox.Text, form.streetTextBox.Text, (int)form.buildingNumericUpDown.Value, (int)form.indexNumericUpDown.Value),
                (int)form.rateNumericUpDown.Value, (int)form.foundationYearNumericUpDown.Value,
                form.isWithHostelCheckBox.Checked, form.siteTextBox.Text);
            university.Saved = form.addToSavedCheckBox.Checked;
            try
            {
                InitialData.initUniversitiesCollection.AddUniversity(university, form.university);
                if (university.Saved)
                {
                    InitialData.initSavedUniversitiesCollection.AddUniversity(university, form.university);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            return university;
        }

        internal static void ReturnToUniversitiesCollection()
        {
            UniversitiesCollectionForm previousForm;
            if (InitialData.isPreviousSaved)
            {
                previousForm = new UniversitiesCollectionForm(InitialData.initSavedUniversitiesCollection);
                previousForm.Show();
            }
            else
            {
                previousForm = new UniversitiesCollectionForm(InitialData.initUniversitiesCollection);
                previousForm.Show();
            }
        }

        internal static Course AddNewCourse(AddCourseForm form)
        {
            bool isNumberParse = int.TryParse(form.numberTextBox.Text, out int r);
            var course = new Course(form.nameTextBox.Text, isNumberParse ? int.Parse(form.numberTextBox.Text) : 0,
                form.areaTextBox.Text, (int)form.numberOfApplicantsNumericUpDown.Value,
                (float)form.pointNumericUpDown.Value,
                form.studyingFormComboBox.Text, (int)form.feeNumericUpDown.Value,
                new Dictionary<string, float>
                {
                    {"Mathematics", (float)form.mathsNumericUpDown.Value },
                    {"Ukrainian language", (float)form.ukrLanguageNumericUpDown.Value },
                    {"History of Ukraine", (float)form.historyNumericUpDown.Value },
                    {"Foreign language", (float)form.forLanguageNumericUpDown.Value },
                    {"Physics", (float)form.physicsNumericUpDown.Value },
                    {"Chemistry", (float)form.chemistryNumericUpDown.Value },
                    {"Biology", (float)form.biologyNumericUpDown.Value },
                    {"Geography", (float)form.geographyNumericUpDown.Value },
                    {"Ukrainian literature", (float)form.ukrLiteratureNumericUpDown.Value },
                }
            );
            course.University = form.universityComboBox.Text;
            course.Saved = form.addToSavedCheckBox.Checked;
            try
            {
                InitialData.initCoursesCollection.AddCourse(course, form.course); 
                if (course.Saved)
                {
                    InitialData.initSavedCoursesCollection.AddCourse(course, form.course);
                }
                foreach (University university in InitialData.initUniversitiesCollection.Items)
                {
                    if (university.Name == course.University)
                    {
                        university.AddCourse(course);
                        break;
                    }
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            
            return course;
        }

        internal static void DeleteCourse (Course course)
        {
            foreach (University university in InitialData.initUniversitiesCollection.Items)
            {
                if (university.Name == course.University)
                {
                    university.DeleteCourse(course);
                    break;
                }
            }
            InitialData.initSavedCoursesCollection.RemoveCourse(course);
            InitialData.initCoursesCollection.RemoveCourse(course);
        }

        internal static void DeleteUniversity(University university)
        {
            InitialData.initUniversitiesCollection.RemoveUniversity(university);
            InitialData.initSavedUniversitiesCollection.RemoveUniversity(university);
            foreach (Course course in university.Courses)
            {
                InitialData.initSavedCoursesCollection.RemoveCourse(course);
                InitialData.initCoursesCollection.RemoveCourse(course);
            }
        }

        internal static void ReturnFromSavedCourse(AddCourseForm form)
        {
            if (form.course != null)
            {
                DeleteCourse(form.course);
                form.Close();
                MessageBox.Show("Course successfully updated");
            }
            else
            {
                form.Close();
                MessageBox.Show("Course successfully added");
            }
        }

        internal static void ReturnFromCourseAdding(University university, Course course, Course newCourse)
        {
            if (course != null)
            {
                var form = new CourseForm(newCourse == null ? course : newCourse);
                form.Show();
            }
            else
            {
                if (newCourse != null)
                {
                    ShowPreviousFormByCourse(newCourse);
                }
                else
                {
                    if (InitialData.isPreviousCourse)
                    {
                        ShowPreviousCollectionByCourse();
                    }
                    else
                    {
                        var form = new UniversityForm(university);
                        form.Show();
                    }
                }
            }
        }

        internal static void ReturnFromSavedUniversity(AddUniversityForm form)
        {
            if (form.university != null)
            {
                FormController.DeleteUniversity(form.university);
                form.Close();
                MessageBox.Show("University successfully updated");
            }
            else
            {
                form.Close();
                MessageBox.Show("University successfully added");
            }
        }

        internal static void ReturnFromUniversityAdding(University university, University newUniversity)
        {
            if (university != null)
            {
                var form = new UniversityForm(newUniversity == null ? university : newUniversity);
                form.Show();
            }
            else
            {
                ReturnToUniversitiesCollection();
            }
        }

        internal static void CountPoint(CalculatorForm form)
        {
            Course courseToCount = (Course)form.courseComboBox.SelectedItem;
            float rezult = ((float)form.mathNumericUpDown.Value * courseToCount.Coefficients["Mathematics"] +
                (float)form.ukrLanguageNumericUpDown.Value * courseToCount.Coefficients["Ukrainian language"] +
                (float)form.historyNumericUpDown.Value * courseToCount.Coefficients["History of Ukraine"] +
                (float)form.fourthSubjectNumericUpDown.Value * courseToCount.Coefficients[(string)form.fourthsubjectComboBox.SelectedItem]) /
                (courseToCount.Coefficients["Mathematics"] + courseToCount.Coefficients["Ukrainian language"] +
                courseToCount.Coefficients["History of Ukraine"] + courseToCount.Coefficients[(string)form.fourthsubjectComboBox.SelectedItem]) +
                (float)form.additionalPointsNumericUpDown.Value;
            if (rezult > 200)
            {
                rezult = 200;
            }
            form.rezultLabel.Text = "Competitive score: " + rezult.ToString("0.##");
            if (rezult < courseToCount.Point)
            {
                form.conclusionLabel.Text = "Your score is too low for this course";
            }
            else
            {
                form.conclusionLabel.Text = "Your score is sufficient for this course";
            }
        }
    }
}
