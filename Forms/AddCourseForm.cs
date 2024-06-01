using EnrolleeHandbook.Controller;
using EnrolleeHandbook.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrolleeHandbook.Forms
{
    internal partial class AddCourseForm : Form
    {
        internal University university;
        internal Course course;
        internal Course newCourse = null;
        internal AddCourseForm(University university = null, Course course = null)
        {
            InitializeComponent();
            FormController.FillComponentsWithData(this, university, course);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            newCourse = FormController.AddNewCourse(this);
            if (newCourse != null)
            {
                FormController.ReturnFromSavedCourse(this);
            }
        }

        private void AddCourseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormController.ReturnFromCourseAdding(university, course, newCourse);
        }

        private void AddCourseForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
