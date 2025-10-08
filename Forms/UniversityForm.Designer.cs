namespace EnrolleeHandbook.Forms
{
    partial class UniversityForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nameLabel = new System.Windows.Forms.Label();
            this.adressLabel = new System.Windows.Forms.Label();
            this.rateLabel = new System.Windows.Forms.Label();
            this.coursesCountLabel = new System.Windows.Forms.Label();
            this.averagePointLabel = new System.Windows.Forms.Label();
            this.minPointLabel = new System.Windows.Forms.Label();
            this.foundYearLabel = new System.Windows.Forms.Label();
            this.hostelLabel = new System.Windows.Forms.Label();
            this.webSiteLabel = new System.Windows.Forms.Label();
            this.coursesDataGridView = new System.Windows.Forms.DataGridView();
            this.Point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saved = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Added = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfApplicants = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coefficients = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.StudyingForm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadButton = new System.Windows.Forms.Button();
            this.addCourseButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.universityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(91, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(752, 98);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "University name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adressLabel
            // 
            this.adressLabel.AutoSize = true;
            this.adressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adressLabel.Location = new System.Drawing.Point(12, 137);
            this.adressLabel.Name = "adressLabel";
            this.adressLabel.Size = new System.Drawing.Size(66, 20);
            this.adressLabel.TabIndex = 1;
            this.adressLabel.Text = "Address";
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rateLabel.Location = new System.Drawing.Point(12, 166);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(71, 20);
            this.rateLabel.TabIndex = 2;
            this.rateLabel.Text = "Rating";
            // 
            // coursesCountLabel
            // 
            this.coursesCountLabel.AutoSize = true;
            this.coursesCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coursesCountLabel.Location = new System.Drawing.Point(11, 195);
            this.coursesCountLabel.Name = "coursesCountLabel";
            this.coursesCountLabel.Size = new System.Drawing.Size(201, 20);
            this.coursesCountLabel.TabIndex = 3;
            this.coursesCountLabel.Text = "Number of courses";
            // 
            // averagePointLabel
            // 
            this.averagePointLabel.AutoSize = true;
            this.averagePointLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.averagePointLabel.Location = new System.Drawing.Point(11, 226);
            this.averagePointLabel.Name = "averagePointLabel";
            this.averagePointLabel.Size = new System.Drawing.Size(200, 20);
            this.averagePointLabel.TabIndex = 4;
            this.averagePointLabel.Text = "Average passing score";
            // 
            // minPointLabel
            // 
            this.minPointLabel.AutoSize = true;
            this.minPointLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minPointLabel.Location = new System.Drawing.Point(11, 260);
            this.minPointLabel.Name = "minPointLabel";
            this.minPointLabel.Size = new System.Drawing.Size(224, 20);
            this.minPointLabel.TabIndex = 5;
            this.minPointLabel.Text = "Minimum passing score";
            // 
            // foundYearLabel
            // 
            this.foundYearLabel.AutoSize = true;
            this.foundYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.foundYearLabel.Location = new System.Drawing.Point(12, 293);
            this.foundYearLabel.Name = "foundYearLabel";
            this.foundYearLabel.Size = new System.Drawing.Size(120, 20);
            this.foundYearLabel.TabIndex = 6;
            this.foundYearLabel.Text = "Year of foundation";
            // 
            // hostelLabel
            // 
            this.hostelLabel.AutoSize = true;
            this.hostelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hostelLabel.Location = new System.Drawing.Point(11, 327);
            this.hostelLabel.Name = "hostelLabel";
            this.hostelLabel.Size = new System.Drawing.Size(175, 20);
            this.hostelLabel.TabIndex = 7;
            this.hostelLabel.Text = "Dormitory available";
            // 
            // webSiteLabel
            // 
            this.webSiteLabel.AutoSize = true;
            this.webSiteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.webSiteLabel.Location = new System.Drawing.Point(12, 354);
            this.webSiteLabel.Name = "webSiteLabel";
            this.webSiteLabel.Size = new System.Drawing.Size(78, 20);
            this.webSiteLabel.TabIndex = 8;
            this.webSiteLabel.Text = "Website";
            // 
            // coursesDataGridView
            // 
            this.coursesDataGridView.AllowUserToDeleteRows = false;
            this.coursesDataGridView.AllowUserToResizeColumns = false;
            this.coursesDataGridView.AllowUserToResizeRows = false;
            this.coursesDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.coursesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.coursesDataGridView.ColumnHeadersHeight = 50;
            this.coursesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.universityName,
            this.Point,
            this.dataGridViewTextBoxColumn2,
            this.Saved,
            this.Added,
            this.Area,
            this.NumberOfApplicants,
            this.Fee,
            this.Number,
            this.Coefficients,
            this.Note,
            this.dataGridViewTextBoxColumn3});
            this.coursesDataGridView.DataSource = this.courseBindingSource;
            this.coursesDataGridView.Location = new System.Drawing.Point(336, 137);
            this.coursesDataGridView.MultiSelect = false;
            this.coursesDataGridView.Name = "coursesDataGridView";
            this.coursesDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.coursesDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.coursesDataGridView.RowTemplate.Height = 70;
            this.coursesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.coursesDataGridView.Size = new System.Drawing.Size(553, 358);
            this.coursesDataGridView.TabIndex = 9;
            this.coursesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.coursesDataGridView_CellContentClick);
            this.coursesDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.coursesDataGridView_KeyDown);
            this.coursesDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.coursesDataGridView_MouseDoubleClick);
            // 
            // Point
            // 
            this.Point.DataPropertyName = "Point";
            this.Point.HeaderText = "Passing score";
            this.Point.Name = "Point";
            this.Point.ReadOnly = true;
            this.Point.Width = 90;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "studyingForm";
            this.dataGridViewTextBoxColumn2.HeaderText = "Study form";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 85;
            // 
            // Saved
            // 
            this.Saved.DataPropertyName = "saved";
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
            // Area
            // 
            this.Area.DataPropertyName = "Area";
            this.Area.HeaderText = "Area";
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            this.Area.Visible = false;
            // 
            // NumberOfApplicants
            // 
            this.NumberOfApplicants.DataPropertyName = "NumberOfApplicants";
            this.NumberOfApplicants.HeaderText = "NumberOfApplicants";
            this.NumberOfApplicants.Name = "NumberOfApplicants";
            this.NumberOfApplicants.ReadOnly = true;
            this.NumberOfApplicants.Visible = false;
            // 
            // Fee
            // 
            this.Fee.DataPropertyName = "Fee";
            this.Fee.HeaderText = "Fee";
            this.Fee.Name = "Fee";
            this.Fee.ReadOnly = true;
            this.Fee.Visible = false;
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Visible = false;
            // 
            // Coefficients
            // 
            this.Coefficients.DataPropertyName = "Coefficients";
            this.Coefficients.HeaderText = "Coefficients";
            this.Coefficients.Name = "Coefficients";
            this.Coefficients.ReadOnly = true;
            this.Coefficients.Visible = false;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            this.Note.Visible = false;
            // 
            // goButton
            // 
            this.goButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goButton.Location = new System.Drawing.Point(394, 524);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(172, 34);
            this.goButton.TabIndex = 14;
            this.goButton.Text = "View";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeButton.Location = new System.Drawing.Point(572, 524);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(205, 34);
            this.changeButton.TabIndex = 15;
            this.changeButton.Text = "Add to favorites";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returnButton.Location = new System.Drawing.Point(783, 524);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(106, 34);
            this.returnButton.TabIndex = 16;
            this.returnButton.Text = "Back";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // StudyingForm
            // 
            this.StudyingForm.DataPropertyName = "studyingForm";
            this.StudyingForm.HeaderText = "Study form";
            this.StudyingForm.Name = "StudyingForm";
            this.StudyingForm.ReadOnly = true;
            this.StudyingForm.Width = 70;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // loadButton
            // 
            this.loadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadButton.Location = new System.Drawing.Point(168, 464);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(136, 94);
            this.loadButton.TabIndex = 13;
            this.loadButton.Text = "Export information";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // addCourseButton
            // 
            this.addCourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCourseButton.Location = new System.Drawing.Point(16, 464);
            this.addCourseButton.Name = "addCourseButton";
            this.addCourseButton.Size = new System.Drawing.Size(126, 94);
            this.addCourseButton.TabIndex = 12;
            this.addCourseButton.Text = "Add course";
            this.addCourseButton.UseVisualStyleBackColor = true;
            this.addCourseButton.Click += new System.EventHandler(this.addCourseButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(15, 424);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(127, 34);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editButton.Location = new System.Drawing.Point(168, 424);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(136, 34);
            this.editButton.TabIndex = 11;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // universityName
            // 
            this.universityName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.universityName.DataPropertyName = "Name";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.universityName.DefaultCellStyle = dataGridViewCellStyle2;
            this.universityName.HeaderText = "Name";
            this.universityName.Name = "universityName";
            this.universityName.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "University";
            this.dataGridViewTextBoxColumn3.HeaderText = "University";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(EnrolleeHandbook.Models.Course);
            // 
            // UniversityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 570);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addCourseButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.coursesDataGridView);
            this.Controls.Add(this.webSiteLabel);
            this.Controls.Add(this.hostelLabel);
            this.Controls.Add(this.foundYearLabel);
            this.Controls.Add(this.minPointLabel);
            this.Controls.Add(this.averagePointLabel);
            this.Controls.Add(this.coursesCountLabel);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.adressLabel);
            this.Controls.Add(this.nameLabel);
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(200, 200);
            this.MaximumSize = new System.Drawing.Size(917, 609);
            this.MinimumSize = new System.Drawing.Size(917, 609);
            this.Name = "UniversityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "University";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UniversityForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UniversityForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.Button goButton;
        public System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button returnButton;
        internal System.Windows.Forms.Label adressLabel;
        internal System.Windows.Forms.Label rateLabel;
        internal System.Windows.Forms.Label coursesCountLabel;
        internal System.Windows.Forms.Label averagePointLabel;
        internal System.Windows.Forms.Label minPointLabel;
        internal System.Windows.Forms.Label foundYearLabel;
        internal System.Windows.Forms.Label hostelLabel;
        internal System.Windows.Forms.Label webSiteLabel;
        internal System.Windows.Forms.DataGridView coursesDataGridView;
        internal System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudyingForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        internal System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn universityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Point;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Saved;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Added;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfApplicants;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coefficients;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button addCourseButton;
        internal System.Windows.Forms.Button deleteButton;
        internal System.Windows.Forms.Button editButton;
    }
}