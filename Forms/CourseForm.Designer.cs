namespace EnrolleeHandbook.Forms
{
    partial class CourseForm
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
            this.nameTabelLabel = new System.Windows.Forms.Label();
            this.feeLabel = new System.Windows.Forms.Label();
            this.studyingFormLabel = new System.Windows.Forms.Label();
            this.pointLabel = new System.Windows.Forms.Label();
            this.applicantsCountLabel = new System.Windows.Forms.Label();
            this.areaLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.coefDataGridView = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkrainianLanguage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.noteLabel = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.universityNameLabel = new System.Windows.Forms.Label();
            this.loadButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.coefDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTabelLabel
            // 
            this.nameTabelLabel.AutoSize = true;
            this.nameTabelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTabelLabel.Location = new System.Drawing.Point(12, 314);
            this.nameTabelLabel.Name = "nameTabelLabel";
            this.nameTabelLabel.Size = new System.Drawing.Size(172, 20);
            this.nameTabelLabel.TabIndex = 8;
            this.nameTabelLabel.Text = "Coefficients table";
            // 
            // feeLabel
            // 
            this.feeLabel.AutoSize = true;
            this.feeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.feeLabel.Location = new System.Drawing.Point(12, 283);
            this.feeLabel.Name = "feeLabel";
            this.feeLabel.Size = new System.Drawing.Size(199, 20);
            this.feeLabel.TabIndex = 7;
            this.feeLabel.Text = "Tuition fee per year";
            // 
            // studyingFormLabel
            // 
            this.studyingFormLabel.AutoSize = true;
            this.studyingFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studyingFormLabel.Location = new System.Drawing.Point(12, 254);
            this.studyingFormLabel.Name = "studyingFormLabel";
            this.studyingFormLabel.Size = new System.Drawing.Size(138, 20);
            this.studyingFormLabel.TabIndex = 6;
            this.studyingFormLabel.Text = "Form of study";
            // 
            // pointLabel
            // 
            this.pointLabel.AutoSize = true;
            this.pointLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointLabel.Location = new System.Drawing.Point(12, 225);
            this.pointLabel.Name = "pointLabel";
            this.pointLabel.Size = new System.Drawing.Size(128, 20);
            this.pointLabel.TabIndex = 5;
            this.pointLabel.Text = "Competitive score";
            // 
            // applicantsCountLabel
            // 
            this.applicantsCountLabel.AutoSize = true;
            this.applicantsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.applicantsCountLabel.Location = new System.Drawing.Point(12, 196);
            this.applicantsCountLabel.Name = "applicantsCountLabel";
            this.applicantsCountLabel.Size = new System.Drawing.Size(282, 20);
            this.applicantsCountLabel.TabIndex = 4;
            this.applicantsCountLabel.Text = "Number of applicants last year";
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.areaLabel.Location = new System.Drawing.Point(12, 165);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(109, 20);
            this.areaLabel.TabIndex = 3;
            this.areaLabel.Text = "Field of study";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberLabel.Location = new System.Drawing.Point(12, 136);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(59, 20);
            this.numberLabel.TabIndex = 2;
            this.numberLabel.Text = "Number";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(15, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(874, 83);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Course name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // coefDataGridView
            // 
            this.coefDataGridView.AllowUserToAddRows = false;
            this.coefDataGridView.AllowUserToDeleteRows = false;
            this.coefDataGridView.AllowUserToResizeColumns = false;
            this.coefDataGridView.AllowUserToResizeRows = false;
            this.coefDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coefDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.UkrainianLanguage,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.coefDataGridView.Location = new System.Drawing.Point(15, 337);
            this.coefDataGridView.Name = "coefDataGridView";
            this.coefDataGridView.ReadOnly = true;
            this.coefDataGridView.RowHeadersVisible = false;
            this.coefDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.coefDataGridView.Size = new System.Drawing.Size(720, 58);
            this.coefDataGridView.TabIndex = 9;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "maths";
            this.Column2.HeaderText = "Mathematics";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // UkrainianLanguage
            // 
            this.UkrainianLanguage.DataPropertyName = "ukrLanguage";
            this.UkrainianLanguage.HeaderText = "Ukrainian language";
            this.UkrainianLanguage.Name = "UkrainianLanguage";
            this.UkrainianLanguage.ReadOnly = true;
            this.UkrainianLanguage.Width = 80;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "history";
            this.Column3.HeaderText = "History of Ukraine";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "forLanguage";
            this.Column4.HeaderText = "Foreign language";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "physics";
            this.Column5.HeaderText = "Physics";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "chemistry";
            this.Column6.HeaderText = "Chemistry";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 80;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "biology";
            this.Column7.HeaderText = "Biology";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 80;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "geography";
            this.Column8.HeaderText = "Geography";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 80;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "literature";
            this.Column9.HeaderText = "Ukrainian literature";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 80;
            // 
            // notesTextBox
            // 
            this.notesTextBox.Location = new System.Drawing.Point(15, 427);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(466, 131);
            this.notesTextBox.TabIndex = 11;
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noteLabel.Location = new System.Drawing.Point(15, 404);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(74, 20);
            this.noteLabel.TabIndex = 10;
            this.noteLabel.Text = "Notes";
            // 
            // returnButton
            // 
            this.returnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returnButton.Location = new System.Drawing.Point(727, 518);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(162, 34);
            this.returnButton.TabIndex = 16;
            this.returnButton.Text = "Back";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeButton.Location = new System.Drawing.Point(727, 478);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(162, 34);
            this.changeButton.TabIndex = 15;
            this.changeButton.Text = "Add to favorites";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // universityNameLabel
            // 
            this.universityNameLabel.AutoSize = true;
            this.universityNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.universityNameLabel.Location = new System.Drawing.Point(12, 92);
            this.universityNameLabel.Name = "universityNameLabel";
            this.universityNameLabel.Size = new System.Drawing.Size(102, 20);
            this.universityNameLabel.TabIndex = 1;
            this.universityNameLabel.Text = "University";
            // 
            // loadButton
            // 
            this.loadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadButton.Location = new System.Drawing.Point(497, 478);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(224, 74);
            this.loadButton.TabIndex = 13;
            this.loadButton.Text = "Export information";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editButton.Location = new System.Drawing.Point(497, 438);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(224, 34);
            this.editButton.TabIndex = 12;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(727, 438);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(162, 34);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(EnrolleeHandbook.Models.Course);
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 570);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.universityNameLabel);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.coefDataGridView);
            this.Controls.Add(this.nameTabelLabel);
            this.Controls.Add(this.feeLabel);
            this.Controls.Add(this.studyingFormLabel);
            this.Controls.Add(this.pointLabel);
            this.Controls.Add(this.applicantsCountLabel);
            this.Controls.Add(this.areaLabel);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.nameLabel);
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(200, 200);
            this.MaximumSize = new System.Drawing.Size(917, 609);
            this.MinimumSize = new System.Drawing.Size(917, 609);
            this.Name = "CourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Course";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CourseForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CourseForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.coefDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameTabelLabel;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkrainianLanguage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.Button returnButton;
        internal System.Windows.Forms.Label feeLabel;
        internal System.Windows.Forms.Label studyingFormLabel;
        internal System.Windows.Forms.Label pointLabel;
        internal System.Windows.Forms.Label applicantsCountLabel;
        internal System.Windows.Forms.Label areaLabel;
        internal System.Windows.Forms.Label numberLabel;
        internal System.Windows.Forms.DataGridView coefDataGridView;
        internal System.Windows.Forms.TextBox notesTextBox;
        internal System.Windows.Forms.Label nameLabel;
        internal System.Windows.Forms.Button changeButton;
        internal System.Windows.Forms.Label universityNameLabel;
        internal System.Windows.Forms.Button loadButton;
        internal System.Windows.Forms.Button editButton;
        internal System.Windows.Forms.Button deleteButton;
    }
}