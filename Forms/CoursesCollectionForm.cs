using EnrolleeHandbook.Controller;
using EnrolleeHandbook.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrolleeHandbook.Forms
{
    internal partial class CoursesCollectionForm : Form
    {
        internal CoursesCollection coursesCollection;
        internal CoursesCollection tempCoursesCollection = new CoursesCollection();

        internal CoursesCollectionForm(CoursesCollection coursesCollection)
        {
            InitializeComponent();
            FormController.MakeCorrectView(this, coursesCollection);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string checkIncorrect = FormController.ShowSearchedUniversities(this);
            if (checkIncorrect != string.Empty)
            {
                MessageBox.Show(checkIncorrect);
            }
            
        }

        private void alphabetRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            FormController.RadioButtonCheckedChanged("alphabet", coursesCollection, tempCoursesCollection, courseBindingSource1);
        }

        private void studentsCountRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            FormController.RadioButtonCheckedChanged("count of applicants", coursesCollection, tempCoursesCollection, courseBindingSource1);
        }

        private void pointRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            FormController.RadioButtonCheckedChanged("point", coursesCollection, tempCoursesCollection, courseBindingSource1);
        }

        private void feeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            FormController.RadioButtonCheckedChanged("fee", coursesCollection, tempCoursesCollection, courseBindingSource1);
        }

        private void areaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            FormController.RadioButtonCheckedChanged("area", coursesCollection, tempCoursesCollection, courseBindingSource1);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            FormController.ResetSearch(coursesCollection, tempCoursesCollection, courseBindingSource1);
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.mainForm.Show();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            allCoursesDataGridView_MouseDoubleClick(sender, (MouseEventArgs)e);
        }

        private void allCoursesDataGridView_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                FormController.ChangeSelectedCourseByBox(allCoursesDataGridView);
            }
        }

        private void allCoursesDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CourseForm form = FormController.GoToCourse(allCoursesDataGridView);
            if (form != null)
            {
                form.Show();
                this.Hide();
            }
        }

        private void CoursesCollectionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.mainForm.Close();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            FormController.SaveCoursesCollectionInformation();
        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            var addForm = new AddCourseForm();
            addForm.Show();
            this.Hide();
        }

        private void allCoursesDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                resetButton.Focus();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                FormController.GoToCourse(allCoursesDataGridView);
                this.Hide();
            }
        }

        private void CoursesCollectionForm_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                returnButton_Click(sender, e);
            }
        }
    }
}
