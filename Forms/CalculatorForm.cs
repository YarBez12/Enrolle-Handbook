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
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;
using System.Xml;
using EnrolleeHandbook.Controller;

namespace EnrolleeHandbook.Forms
{
    internal partial class CalculatorForm : Form
    {
        internal CalculatorForm()
        {
            InitializeComponent();
            universityBindingSource.DataSource = InitialData.initUniversitiesCollection.Items;
            courseBindingSource.DataSource = ((University)universityComboBox.SelectedItem).Courses;
            fourthsubjectComboBox.SelectedIndex = 0;
        }

        private void universityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (universityComboBox.SelectedItem != null)
            {
                courseBindingSource.DataSource = ((University)universityComboBox.SelectedItem).Courses;
            }
        }


        private void CalculatorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.mainForm.Close();
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            FormController.CountPoint(this);
        }

        private void CalculatorForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) 
            {
                returnButton_Click(sender, e);
            }
            if (e.KeyCode == Keys.Enter)
            {
                countButton_Click(sender, e);
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.mainForm.Show();
        }
    }
}
