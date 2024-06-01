using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnrolleeHandbook.Controller;
using EnrolleeHandbook.Models;

namespace EnrolleeHandbook.Forms
{
    internal partial class UniversitiesCollectionForm : Form
    {
        internal UniversitiesCollection universitiesCollection;
        internal UniversitiesCollection tempUniversitiesCollection = new UniversitiesCollection();
        internal UniversitiesCollectionForm(UniversitiesCollection universitiesCollection)
        {
            InitializeComponent();
            FormController.MakeCorrectView(this, universitiesCollection);
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            allUniversitiesDataGridView_MouseDoubleClick(sender, (MouseEventArgs)e);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            FormController.ResetSearch(universitiesCollection, tempUniversitiesCollection, universityBindingSource);
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
            FormController.RadioButtonCheckedChanged("alphabet", universitiesCollection, tempUniversitiesCollection, universityBindingSource);

        }

        private void courcesCountRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            FormController.RadioButtonCheckedChanged("count of courses", universitiesCollection, tempUniversitiesCollection, universityBindingSource);

        }

        private void rateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            FormController.RadioButtonCheckedChanged("rating", universitiesCollection, tempUniversitiesCollection, universityBindingSource);
        }

        private void averagePointRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            FormController.RadioButtonCheckedChanged("average point", universitiesCollection, tempUniversitiesCollection, universityBindingSource);
        }

        private void averageFeeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            FormController.RadioButtonCheckedChanged("average fee", universitiesCollection, tempUniversitiesCollection, universityBindingSource);
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            Program.mainForm.Show();
            this.Hide();
        }

        private void allUniversitiesDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                FormController.ChangeSelectedUniversityByBox(allUniversitiesDataGridView);
            }
        }

        private void allUniversitiesDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            UniversityForm form = FormController.GoToUniversity(allUniversitiesDataGridView);
            if (form != null)
            {
                form.Show();
                this.Hide();
            }
        }

        private void UniversitiesCollectionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.mainForm.Close();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            FormController.SaveUniversityCollectionInformation();
        }

        private void addUniversityButton_Click(object sender, EventArgs e)
        {
            var addForm = new AddUniversityForm();
            addForm.Show();
            this.Hide();
        }

        private void allUniversitiesDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                resetButton.Focus();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                FormController.GoToUniversity(allUniversitiesDataGridView);
                this.Hide();
            }
        }

        private void UniversitiesCollectionForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                returnButton_Click(sender, e);
            }
        }
    }
}
