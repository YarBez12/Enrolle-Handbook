namespace EnrolleeHandbook.Forms
{
    partial class UniversitiesCollectionForm
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
            this.universityNameLabel = new System.Windows.Forms.Label();
            this.universityNameTextBox = new System.Windows.Forms.TextBox();
            this.courseNameTextBox = new System.Windows.Forms.TextBox();
            this.courseNameLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.sortGroupBox = new System.Windows.Forms.GroupBox();
            this.rateRadioButton = new System.Windows.Forms.RadioButton();
            this.averageFeeRadioButton = new System.Windows.Forms.RadioButton();
            this.averagePointRadioButton = new System.Windows.Forms.RadioButton();
            this.courcesCountRadioButton = new System.Windows.Forms.RadioButton();
            this.alphabetRadioButton = new System.Windows.Forms.RadioButton();
            this.searchButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.goButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnButton = new System.Windows.Forms.Button();
            this.allUniversitiesDataGridView = new System.Windows.Forms.DataGridView();
            this.averagePoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saved = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Added = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addUniversityButton = new System.Windows.Forms.Button();
            this.nameUniversity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.universityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sortGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allUniversitiesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // universityNameLabel
            // 
            this.universityNameLabel.AutoSize = true;
            this.universityNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.universityNameLabel.Location = new System.Drawing.Point(18, 37);
            this.universityNameLabel.Name = "universityNameLabel";
            this.universityNameLabel.Size = new System.Drawing.Size(102, 20);
            this.universityNameLabel.TabIndex = 0;
            this.universityNameLabel.Text = "Університет";
            // 
            // universityNameTextBox
            // 
            this.universityNameTextBox.Location = new System.Drawing.Point(132, 37);
            this.universityNameTextBox.Name = "universityNameTextBox";
            this.universityNameTextBox.Size = new System.Drawing.Size(153, 20);
            this.universityNameTextBox.TabIndex = 1;
            // 
            // courseNameTextBox
            // 
            this.courseNameTextBox.Location = new System.Drawing.Point(132, 72);
            this.courseNameTextBox.Name = "courseNameTextBox";
            this.courseNameTextBox.Size = new System.Drawing.Size(153, 20);
            this.courseNameTextBox.TabIndex = 3;
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.AutoSize = true;
            this.courseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.courseNameLabel.Location = new System.Drawing.Point(3, 72);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(116, 20);
            this.courseNameLabel.TabIndex = 2;
            this.courseNameLabel.Text = "Спеціальність";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(132, 111);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(153, 20);
            this.cityTextBox.TabIndex = 5;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityLabel.Location = new System.Drawing.Point(65, 111);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(51, 20);
            this.cityLabel.TabIndex = 4;
            this.cityLabel.Text = "Місто";
            // 
            // sortGroupBox
            // 
            this.sortGroupBox.Controls.Add(this.rateRadioButton);
            this.sortGroupBox.Controls.Add(this.averageFeeRadioButton);
            this.sortGroupBox.Controls.Add(this.averagePointRadioButton);
            this.sortGroupBox.Controls.Add(this.courcesCountRadioButton);
            this.sortGroupBox.Controls.Add(this.alphabetRadioButton);
            this.sortGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortGroupBox.Location = new System.Drawing.Point(12, 239);
            this.sortGroupBox.Name = "sortGroupBox";
            this.sortGroupBox.Size = new System.Drawing.Size(273, 159);
            this.sortGroupBox.TabIndex = 9;
            this.sortGroupBox.TabStop = false;
            this.sortGroupBox.Text = "Сортування";
            // 
            // rateRadioButton
            // 
            this.rateRadioButton.AutoSize = true;
            this.rateRadioButton.Location = new System.Drawing.Point(5, 131);
            this.rateRadioButton.Name = "rateRadioButton";
            this.rateRadioButton.Size = new System.Drawing.Size(132, 24);
            this.rateRadioButton.TabIndex = 4;
            this.rateRadioButton.Text = "За рейтингом";
            this.rateRadioButton.UseVisualStyleBackColor = true;
            this.rateRadioButton.CheckedChanged += new System.EventHandler(this.rateRadioButton_CheckedChanged);
            // 
            // averageFeeRadioButton
            // 
            this.averageFeeRadioButton.AutoSize = true;
            this.averageFeeRadioButton.Location = new System.Drawing.Point(5, 103);
            this.averageFeeRadioButton.Name = "averageFeeRadioButton";
            this.averageFeeRadioButton.Size = new System.Drawing.Size(198, 24);
            this.averageFeeRadioButton.TabIndex = 3;
            this.averageFeeRadioButton.Text = "За середньою платою";
            this.averageFeeRadioButton.UseVisualStyleBackColor = true;
            this.averageFeeRadioButton.CheckedChanged += new System.EventHandler(this.averageFeeRadioButton_CheckedChanged);
            // 
            // averagePointRadioButton
            // 
            this.averagePointRadioButton.AutoSize = true;
            this.averagePointRadioButton.Location = new System.Drawing.Point(5, 75);
            this.averagePointRadioButton.Name = "averagePointRadioButton";
            this.averagePointRadioButton.Size = new System.Drawing.Size(263, 24);
            this.averagePointRadioButton.TabIndex = 2;
            this.averagePointRadioButton.Text = "За середнім конкурсним балом";
            this.averagePointRadioButton.UseVisualStyleBackColor = true;
            this.averagePointRadioButton.CheckedChanged += new System.EventHandler(this.averagePointRadioButton_CheckedChanged);
            // 
            // courcesCountRadioButton
            // 
            this.courcesCountRadioButton.AutoSize = true;
            this.courcesCountRadioButton.Location = new System.Drawing.Point(5, 48);
            this.courcesCountRadioButton.Name = "courcesCountRadioButton";
            this.courcesCountRadioButton.Size = new System.Drawing.Size(244, 24);
            this.courcesCountRadioButton.TabIndex = 1;
            this.courcesCountRadioButton.Text = "За кількістю спеціальностей";
            this.courcesCountRadioButton.UseVisualStyleBackColor = true;
            this.courcesCountRadioButton.CheckedChanged += new System.EventHandler(this.courcesCountRadioButton_CheckedChanged);
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
            this.alphabetRadioButton.Text = "За алфавітом";
            this.alphabetRadioButton.UseVisualStyleBackColor = true;
            this.alphabetRadioButton.CheckedChanged += new System.EventHandler(this.alphabetRadioButton_CheckedChanged);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.Location = new System.Drawing.Point(165, 137);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(120, 34);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Пошук";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetButton.Location = new System.Drawing.Point(165, 177);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(120, 34);
            this.resetButton.TabIndex = 8;
            this.resetButton.Text = "Скинути";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // goButton
            // 
            this.goButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goButton.Location = new System.Drawing.Point(722, 524);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(167, 34);
            this.goButton.TabIndex = 12;
            this.goButton.Text = "Переглянути";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn1.HeaderText = "Address";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // returnButton
            // 
            this.returnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returnButton.Location = new System.Drawing.Point(549, 524);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(167, 34);
            this.returnButton.TabIndex = 13;
            this.returnButton.Text = "Назад";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // allUniversitiesDataGridView
            // 
            this.allUniversitiesDataGridView.AllowUserToAddRows = false;
            this.allUniversitiesDataGridView.AllowUserToDeleteRows = false;
            this.allUniversitiesDataGridView.AllowUserToResizeColumns = false;
            this.allUniversitiesDataGridView.AllowUserToResizeRows = false;
            this.allUniversitiesDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allUniversitiesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.allUniversitiesDataGridView.ColumnHeadersHeight = 50;
            this.allUniversitiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameUniversity,
            this.averagePoint,
            this.rating,
            this.Saved,
            this.Added,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.allUniversitiesDataGridView.DataSource = this.universityBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allUniversitiesDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.allUniversitiesDataGridView.Location = new System.Drawing.Point(315, 37);
            this.allUniversitiesDataGridView.MultiSelect = false;
            this.allUniversitiesDataGridView.Name = "allUniversitiesDataGridView";
            this.allUniversitiesDataGridView.RowHeadersVisible = false;
            this.allUniversitiesDataGridView.RowHeadersWidth = 80;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allUniversitiesDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.allUniversitiesDataGridView.RowTemplate.Height = 110;
            this.allUniversitiesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allUniversitiesDataGridView.Size = new System.Drawing.Size(574, 471);
            this.allUniversitiesDataGridView.TabIndex = 7;
            this.allUniversitiesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allUniversitiesDataGridView_CellContentClick_1);
            this.allUniversitiesDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.allUniversitiesDataGridView_KeyDown);
            this.allUniversitiesDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.allUniversitiesDataGridView_MouseDoubleClick);
            // 
            // averagePoint
            // 
            this.averagePoint.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.averagePoint.DataPropertyName = "StringAveragePoint";
            this.averagePoint.FillWeight = 20F;
            this.averagePoint.HeaderText = "Середній бал";
            this.averagePoint.Name = "averagePoint";
            this.averagePoint.ReadOnly = true;
            this.averagePoint.Width = 90;
            // 
            // Saved
            // 
            this.Saved.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Saved.DataPropertyName = "saved";
            this.Saved.FillWeight = 20F;
            this.Saved.HeaderText = "Збережено";
            this.Saved.Name = "Saved";
            // 
            // Added
            // 
            this.Added.DataPropertyName = "Added";
            this.Added.HeaderText = "Додано";
            this.Added.Name = "Added";
            this.Added.ReadOnly = true;
            this.Added.Width = 70;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CorsesCount";
            this.dataGridViewTextBoxColumn6.HeaderText = "CorsesCount";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MinimumPoint";
            this.dataGridViewTextBoxColumn7.HeaderText = "MinimumPoint";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "FoundationYear";
            this.dataGridViewTextBoxColumn8.HeaderText = "FoundationYear";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsWithHostel";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsWithHostel";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Site";
            this.dataGridViewTextBoxColumn9.HeaderText = "Site";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "AverageFee";
            this.dataGridViewTextBoxColumn10.HeaderText = "AverageFee";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn4.HeaderText = "Address";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // loadButton
            // 
            this.loadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadButton.Location = new System.Drawing.Point(166, 464);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(119, 94);
            this.loadButton.TabIndex = 11;
            this.loadButton.Text = "Завантажити інформацію";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn2.HeaderText = "Address";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // addUniversityButton
            // 
            this.addUniversityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addUniversityButton.Location = new System.Drawing.Point(12, 464);
            this.addUniversityButton.Name = "addUniversityButton";
            this.addUniversityButton.Size = new System.Drawing.Size(118, 94);
            this.addUniversityButton.TabIndex = 10;
            this.addUniversityButton.Text = "Додати університет";
            this.addUniversityButton.UseVisualStyleBackColor = true;
            this.addUniversityButton.Click += new System.EventHandler(this.addUniversityButton_Click);
            // 
            // nameUniversity
            // 
            this.nameUniversity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameUniversity.DataPropertyName = "Name";
            this.nameUniversity.HeaderText = "Назва";
            this.nameUniversity.Name = "nameUniversity";
            this.nameUniversity.ReadOnly = true;
            // 
            // rating
            // 
            this.rating.DataPropertyName = "Rating";
            this.rating.HeaderText = "Рейтинг";
            this.rating.Name = "rating";
            this.rating.ReadOnly = true;
            this.rating.Width = 85;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn5.HeaderText = "Address";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // universityBindingSource
            // 
            this.universityBindingSource.DataSource = typeof(EnrolleeHandbook.Models.University);
            // 
            // UniversitiesCollectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 570);
            this.Controls.Add(this.addUniversityButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.allUniversitiesDataGridView);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.sortGroupBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.courseNameTextBox);
            this.Controls.Add(this.courseNameLabel);
            this.Controls.Add(this.universityNameTextBox);
            this.Controls.Add(this.universityNameLabel);
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(200, 200);
            this.MaximumSize = new System.Drawing.Size(917, 609);
            this.MinimumSize = new System.Drawing.Size(917, 609);
            this.Name = "UniversitiesCollectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Перелік університетів";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UniversitiesCollectionForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UniversitiesCollectionForm_KeyDown);
            this.sortGroupBox.ResumeLayout(false);
            this.sortGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allUniversitiesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label universityNameLabel;
        private System.Windows.Forms.Label courseNameLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.GroupBox sortGroupBox;
        private System.Windows.Forms.RadioButton alphabetRadioButton;
        private System.Windows.Forms.RadioButton rateRadioButton;
        private System.Windows.Forms.RadioButton averageFeeRadioButton;
        private System.Windows.Forms.RadioButton averagePointRadioButton;
        private System.Windows.Forms.RadioButton courcesCountRadioButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button returnButton;
        internal System.Windows.Forms.DataGridView allUniversitiesDataGridView;
        internal System.Windows.Forms.TextBox universityNameTextBox;
        internal System.Windows.Forms.TextBox courseNameTextBox;
        internal System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        internal System.Windows.Forms.Button loadButton;
        internal System.Windows.Forms.BindingSource universityBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameUniversity;
        private System.Windows.Forms.DataGridViewTextBoxColumn averagePoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn rating;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Saved;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Added;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Button addUniversityButton;
    }
}