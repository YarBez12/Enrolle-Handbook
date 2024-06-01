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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrolleeHandbook.Forms
{
    internal partial class AddUniversityForm : Form
    {
        internal University university;
        internal University newUniversity;
        internal AddUniversityForm(University university = null)
        {
            InitializeComponent();
            FormController.FillComponentsWithData(this, university );
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            newUniversity = FormController.AddNewUniversity(this);
            if (newUniversity != null) 
            {
                FormController.ReturnFromSavedUniversity(this);
            }
        }

        private void AddUniversityForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormController.ReturnFromUniversityAdding(university, newUniversity);
        }

        private void AddUniversityForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
