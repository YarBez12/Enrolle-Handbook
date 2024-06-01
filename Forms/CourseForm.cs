using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnrolleeHandbook.Controller;
using EnrolleeHandbook.Models;

namespace EnrolleeHandbook.Forms
{
    internal partial class CourseForm : Form
    {
        internal Course course;

        internal CourseForm(Course course)
        {
            this.course = course;
            InitializeComponent();
            FormController.FillComponentsWithData(this);
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            changeButton.Text = FormController.ChangeCourseSaved(course);
        }
         
        private void returnButton_Click(object sender, EventArgs e)
        {
            course.Note = notesTextBox.Text;
            this.Hide();
            FormController.ShowPreviousFormByCourse(course);
        }

        private void CourseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.mainForm.Close();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            FormController.SaveCourseInformation(course);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            FormController.DeleteCourse(course);
            this.Hide();
            FormController.ShowPreviousFormByCourse(course);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var addForm = new AddCourseForm(null, course);
            addForm.Show();
            this.Hide();
        }

        private void CourseForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                returnButton_Click(sender, e);
            }
        }
    }
}
