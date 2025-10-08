namespace EnrolleeHandbook.Forms
{
    partial class CoursesCollectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sortGroupBox = new System.Windows.Forms.GroupBox();
            this.areaRadioButton = new System.Windows.Forms.RadioButton();
            this.feeRadioButton = new System.Windows.Forms.RadioButton();
            this.pointRadioButton = new System.Windows.Forms.RadioButton();
            this.studentsCountRadioButton = new System.Windows.Forms.RadioButton();
            this.alphabetRadioButton = new System.Windows.Forms.RadioButton();
            this.minPointLabel = new System.Windows.Forms.Label();
            this.studyingFormTextBox = new System.Windows.Forms.TextBox();
            this.studyingFormLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.goButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.allCoursesDataGridView = new System.Windows.Forms.DataGridView();
            this.Point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saved = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Added = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coefficients = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minPointNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.loadButton = new System.Windows.Forms.Button();
            this.addCourseButton = new System.Windows.Forms.Button();
            this.courseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudyingForm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.universityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sortGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allCoursesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minPointNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sortGroupBox
            // 
            this.sortGroupBox.Controls.Add(this.areaRadioButton);
            this.sortGroupBox.Controls.Add(this.feeRadioButton);
            this.sortGroupBox.Controls.Add(this.pointRadioButton);
            this.sortGroupBox.Controls.Add(this.studentsCountRadioButton);
            this.sortGroupBox.Controls.Add(this.alphabetRadioButton);
            this.sortGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortGroupBox.Location = new System.Drawing.Point(11, 226);
            this.sortGroupBox.Name = "sortGroupBox";
            this.sortGroupBox.Size = new System.Drawing.Size(285, 174);
            this.sortGroupBox.TabIndex = 11;
            this.sortGroupBox.TabStop = false;
            this.sortGroupBox.Text = "Sorting";
            // 
            // areaRadioButton
            // 
            this.areaRadioButton.AutoSize = true;
            this.areaRadioButton.Location = new System.Drawing.Point(5, 131);
            this.areaRadioButton.Name = "areaRadioButton";
            this.areaRadioButton.Size = new System.Drawing.Size(160, 24);
            this.areaRadioButton.TabIndex = 4;
            this.areaRadioButton.Text = "By area";
            this.areaRadioButton.UseVisualStyleBackColor = true;
            this.areaRadioButton.CheckedChanged += new System.EventHandler(this.areaRadioButton_CheckedChanged);
            // 
            // feeRadioButton
            // 
            this.feeRadioButton.AutoSize = true;
            this.feeRadioButton.Location = new System.Drawing.Point(5, 103);
            this.feeRadioButton.Name = "feeRadioButton";
            this.feeRadioButton.Size = new System.Drawing.Size(109, 24);
            this.feeRadioButton.TabIndex = 3;
            this.feeRadioButton.Text = "By fee";
            this.feeRadioButton.UseVisualStyleBackColor = true;
            this.feeRadioButton.CheckedChanged += new System.EventHandler(this.feeRadioButton_CheckedChanged);
            // 
            // pointRadioButton
            // 
            this.pointRadioButton.AutoSize = true;
            this.pointRadioButton.Location = new System.Drawing.Point(5, 75);
            this.pointRadioButton.Name = "pointRadioButton";
            this.pointRadioButton.Size = new System.Drawing.Size(190, 24);
            this.pointRadioButton.TabIndex = 2;
            this.pointRadioButton.Text = "By passing score";
            this.pointRadioButton.UseVisualStyleBackColor = true;
            this.pointRadioButton.CheckedChanged += new System.EventHandler(this.pointRadioButton_CheckedChanged);
            // 
            // studentsCountRadioButton
            // 
            this.studentsCountRadioButton.AutoSize = true;
            this.studentsCountRadioButton.Location = new System.Drawing.Point(5, 48);
            this.studentsCountRadioButton.Name = "studentsCountRadioButton";
            this.studentsCountRadioButton.Size = new System.Drawing.Size(199, 24);
            this.studentsCountRadioButton.TabIndex = 1;
            this.studentsCountRadioButton.Text = "By applicants count";
            this.studentsCountRadioButton.UseVisualStyleBackColor = true;
            this.studentsCountRadioButton.CheckedChanged += new System.EventHandler(this.studentsCountRadioButton_CheckedChanged);
            // 
            // alphabetRadioButton
            // 
            this.alphabetRadioButton.AutoSize = true;
            this.alphabetRadioButton.Checked = true;
            this.alphabetRadioButton.Location = new System.Drawing.Point(5, 20);
            this.alphabetRadioButton.Name = "alphabetRadioButton";
            this.alphabetRadioButton.Size = new System.Drawing.Size(135, 24);
            this.alphabetRadioButton.TabIndex = 0;
            this.alphabetRadioButton.TabStop = true;
            this.alphabetRadioButton.Text = "Alphabetically";
            this.alphabetRadioButton.UseVisualStyleBackColor = true;
            this.alphabetRadioButton.CheckedChanged += new System.EventHandler(this.alphabetRadioButton_CheckedChanged);
            // 
            // minPointLabel
            // 
            this.minPointLabel.AutoSize = true;
            this.minPointLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minPointLabel.Location = new System.Drawing.Point(0, 82);
            this.minPointLabel.Name = "minPointLabel";
            this.minPointLabel.Size = new System.Drawing.Size(135, 20);
            this.minPointLabel.TabIndex = 4;
            this.minPointLabel.Text = "Minimum score";
            // 
            // studyingFormTextBox
            // 
            this.studyingFormTextBox.Location = new System.Drawing.Point(144, 56);
            this.studyingFormTextBox.Name = "studyingFormTextBox";
            this.studyingFormTextBox.Size = new System.Drawing.Size(153, 20);
            this.studyingFormTextBox.TabIndex = 3;
            // 
            // studyingFormLabel
            // 
            this.studyingFormLabel.AutoSize = true;
            this.studyingFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studyingFormLabel.Location = new System.Drawing.Point(0, 56);
            this.studyingFormLabel.Name = "studyingFormLabel";
            this.studyingFormLabel.Size = new System.Drawing.Size(138, 20);
            this.studyingFormLabel.TabIndex = 2;
            this.studyingFormLabel.Text = "Study form";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(144, 30);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(153, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(19, 30);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(116, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Course";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(144, 110);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(153, 20);
            this.numberTextBox.TabIndex = 7;
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberLabel.Location = new System.Drawing.Point(72, 110);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(59, 20);
            this.numberLabel.TabIndex = 6;
            this.numberLabel.Text = "Number";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.Location = new System.Drawing.Point(193, 133);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(103, 34);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetButton.Location = new System.Drawing.Point(193, 173);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(103, 34);
            this.resetButton.TabIndex = 10;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // goButton
            // 
            this.goButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goButton.Location = new System.Drawing.Point(737, 524);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(152, 34);
            this.goButton.TabIndex = 14;
            this.goButton.Text = "View";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returnButton.Location = new System.Drawing.Point(579, 524);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(152, 34);
            this.returnButton.TabIndex = 15;
            this.returnButton.Text = "Back";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // allCoursesDataGridView
            // 
            this.allCoursesDataGridView.AllowUserToAddRows = false;
            this.allCoursesDataGridView.AllowUserToDeleteRows = false;
            this.allCoursesDataGridView.AllowUserToResizeColumns = false;
            this.allCoursesDataGridView.AllowUserToResizeRows = false;
            this.allCoursesDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allCoursesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.allCoursesDataGridView.ColumnHeadersHeight = 50;
            this.allCoursesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseName,
            this.Point,
            this.StudyingForm,
            this.Saved,
            this.Added,
            this.Number,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Coefficients});
            this.allCoursesDataGridView.DataSource = this.courseBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allCoursesDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.allCoursesDataGridView.Location = new System.Drawing.Point(315, 30);
            this.allCoursesDataGridView.MultiSelect = false;
            this.allCoursesDataGridView.Name = "allCoursesDataGridView";
            this.allCoursesDataGridView.ReadOnly = true;
            this.allCoursesDataGridView.RowHeadersVisible = false;
            this.allCoursesDataGridView.RowHeadersWidth = 40;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allCoursesDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.allCoursesDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allCoursesDataGridView.RowTemplate.Height = 70;
            this.allCoursesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allCoursesDataGridView.Size = new System.Drawing.Size(574, 479);
            this.allCoursesDataGridView.TabIndex = 9;
            this.allCoursesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allCoursesDataGridView_CellContentClick_2);
            this.allCoursesDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.allCoursesDataGridView_KeyDown);
            this.allCoursesDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.allCoursesDataGridView_MouseDoubleClick);
            // 
            // Point
            // 
            this.Point.DataPropertyName = "Point";
            this.courseName.HeaderText = "Name";
            this.Point.Name = "Point";
            this.Point.ReadOnly = true;
            this.Point.Width = 90;
            // 
            // Saved
            // 
            this.Saved.DataPropertyName = "Saved";
            this.Saved.HeaderText = "Saved";
            this.Saved.Name = "Saved";
            this.Saved.ReadOnly = true;
            // 
            // Added
            // 
            this.Added.DataPropertyName = "Added";
            this.Added.HeaderText = "Added";
            this.Added.Name = "Added";
            this.Added.ReadOnly = true;
            this.Added.Width = 70;
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Visible = false;
            this.Number.Width = 70;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Area";
            this.dataGridViewTextBoxColumn1.HeaderText = "Area";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NumberOfApplicants";
            this.dataGridViewTextBoxColumn2.HeaderText = "NumberOfApplicants";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "StudyingForm";
            this.dataGridViewTextBoxColumn3.HeaderText = "StudyingForm";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Fee";
            this.dataGridViewTextBoxColumn4.HeaderText = "Fee";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // Coefficients
            // 
            this.Coefficients.DataPropertyName = "Coefficients";
            this.Coefficients.HeaderText = "Coefficients";
            this.Coefficients.Name = "Coefficients";
            this.Coefficients.ReadOnly = true;
            this.Coefficients.Visible = false;
            // 
            // minPointNumericUpDown
            // 
            this.minPointNumericUpDown.DecimalPlaces = 2;
            this.minPointNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.minPointNumericUpDown.Location = new System.Drawing.Point(144, 82);
            this.minPointNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.minPointNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.minPointNumericUpDown.Name = "minPointNumericUpDown";
            this.minPointNumericUpDown.Size = new System.Drawing.Size(153, 20);
            this.minPointNumericUpDown.TabIndex = 5;
            this.minPointNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // loadButton
            // 
            this.loadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadButton.Location = new System.Drawing.Point(178, 464);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(119, 94);
            this.loadButton.TabIndex = 13;
            this.loadButton.Text = "Export information";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // addCourseButton
            // 
            this.addCourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCourseButton.Location = new System.Drawing.Point(11, 464);
            this.addCourseButton.Name = "addCourseButton";
            this.addCourseButton.Size = new System.Drawing.Size(124, 94);
            this.addCourseButton.TabIndex = 12;
            this.addCourseButton.Text = "Add course";
            this.addCourseButton.UseVisualStyleBackColor = true;
            this.addCourseButton.Click += new System.EventHandler(this.addCourseButton_Click);
            // 
            // courseName
            // 
            this.courseName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.courseName.DataPropertyName = "Name";
            this.courseName.HeaderText = "Name";
            this.courseName.Name = "courseName";
            this.courseName.ReadOnly = true;
            // 
            // StudyingForm
            // 
            this.StudyingForm.DataPropertyName = "StudyingForm";
            this.StudyingForm.HeaderText = "Study form";
            this.StudyingForm.Name = "StudyingForm";
            this.StudyingForm.ReadOnly = true;
            this.StudyingForm.Width = 80;
            // 
            // courseBindingSource1
            // 
            this.courseBindingSource1.DataSource = typeof(EnrolleeHandbook.Models.Course);
            // 
            // universityBindingSource
            // 
            this.universityBindingSource.DataSource = typeof(EnrolleeHandbook.Models.University);
            // 
            // CoursesCollectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 570);
            this.Controls.Add(this.addCourseButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.minPointNumericUpDown);
            this.Controls.Add(this.allCoursesDataGridView);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.sortGroupBox);
            this.Controls.Add(this.minPointLabel);
            this.Controls.Add(this.studyingFormTextBox);
            this.Controls.Add(this.studyingFormLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(200, 200);
            this.MaximumSize = new System.Drawing.Size(917, 609);
            this.MinimumSize = new System.Drawing.Size(917, 609);
            this.Name = "CoursesCollectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "List of courses";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CoursesCollectionForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CoursesCollectionForm_KeyDown);
            this.sortGroupBox.ResumeLayout(false);
            this.sortGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allCoursesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minPointNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox sortGroupBox;
        private System.Windows.Forms.RadioButton areaRadioButton;
        private System.Windows.Forms.RadioButton feeRadioButton;
        private System.Windows.Forms.RadioButton pointRadioButton;
        private System.Windows.Forms.RadioButton studentsCountRadioButton;
        private System.Windows.Forms.RadioButton alphabetRadioButton;
        private System.Windows.Forms.Label minPointLabel;
        private System.Windows.Forms.Label studyingFormLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Button returnButton;
        internal System.Windows.Forms.BindingSource courseBindingSource1;
        private System.Windows.Forms.BindingSource universityBindingSource;
        internal System.Windows.Forms.DataGridView allCoursesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        internal System.Windows.Forms.TextBox studyingFormTextBox;
        internal System.Windows.Forms.TextBox nameTextBox;
        internal System.Windows.Forms.TextBox numberTextBox;
        internal System.Windows.Forms.NumericUpDown minPointNumericUpDown;
        internal System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Point;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudyingForm;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Saved;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Added;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coefficients;
        private System.Windows.Forms.Button addCourseButton;
    }
}