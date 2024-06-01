using EnrolleeHandbook.Controller;
using EnrolleeHandbook.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrolleeHandbook.Forms
{
    internal partial class UniversityForm : Form
    {
        internal University university;
        internal UniversityForm(University university)
        {
            this.university = university;
            InitializeComponent();
            FormController.FillComponentsWithData(this);
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            changeButton.Text = FormController.ChangeUniversitySaved(university);
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            FormController.ShowPreviousFormByUniversity();
            this.Hide();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            coursesDataGridView_MouseDoubleClick(sender, (MouseEventArgs)e);
        }

        private void coursesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                FormController.ChangeSelectedCourseByBox(coursesDataGridView);
            }
        }

        private void coursesDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CourseForm form = FormController.GoToCourse(coursesDataGridView);
            if (form != null)
            {
                form.Show();
                this.Hide();
            }
        }

        private void UniversityForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.mainForm.Close();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            FormController.SaveUniversityInformation(university);
        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            var addForm = new AddCourseForm(university);
            addForm.Show();
            this.Hide();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            FormController.DeleteUniversity(university);
            this.Hide();
            FormController.ShowPreviousFormByUniversity();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var addForm = new AddUniversityForm(university);
            addForm.Show();
            this.Hide();
        }

        private void coursesDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                deleteButton.Focus();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                FormController.GoToCourse(coursesDataGridView);
                this.Hide();
            }
        }

        private void UniversityForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                returnButton_Click(sender, e);
            }
        }
    }
}
