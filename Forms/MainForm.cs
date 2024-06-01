using EnrolleeHandbook.Controller;
using EnrolleeHandbook.Forms;
using EnrolleeHandbook.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrolleeHandbook
{
    internal partial class MainForm : Form
    {
        internal MainForm()
        {
            InitializeComponent();
        }

        private void savedUniversitiesButton_Click(object sender, EventArgs e)
        {
            FormController.GoNextFromMain("saved universities");
            this.Hide();

        }

        private void savedCoursesButton_Click(object sender, EventArgs e)
        {
            FormController.GoNextFromMain("saved courses");
            this.Hide();
        }

        private void allUniversitiesButton_Click(object sender, EventArgs e)
        {
            FormController.GoNextFromMain("all universities");
            this.Hide();
        }

        private void allCoursesButton_Click(object sender, EventArgs e)
        {
            FormController.GoNextFromMain("all courses");
            this.Hide();
        }

        private void calculatorButton_Click(object sender, EventArgs e)
        {
            FormController.GoNextFromMain("calculator");
            this.Hide();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            JsonController.SaveToJson(InitialData.initUniversitiesCollection, InitialData.filePath);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
