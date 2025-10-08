namespace EnrolleeHandbook.Forms
{
    partial class CalculatorForm
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
            this.courseLabel = new System.Windows.Forms.Label();
            this.courseComboBox = new System.Windows.Forms.ComboBox();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fourthSubjectLabel = new System.Windows.Forms.Label();
            this.fourthsubjectComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mathsLabel = new System.Windows.Forms.Label();
            this.mathNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ukrLanguageNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ukrLanguageLabel = new System.Windows.Forms.Label();
            this.historyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.historyLabel = new System.Windows.Forms.Label();
            this.fourthSubjectNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.fourthSubjectMarkLabel = new System.Windows.Forms.Label();
            this.additionalPointsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.additionalPointsLabel = new System.Windows.Forms.Label();
            this.countButton = new System.Windows.Forms.Button();
            this.universityLabel = new System.Windows.Forms.Label();
            this.universityComboBox = new System.Windows.Forms.ComboBox();
            this.universityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.returnButton = new System.Windows.Forms.Button();
            this.rezultLabel = new System.Windows.Forms.Label();
            this.conclusionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ukrLanguageNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourthSubjectNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalPointsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // courseLabel
            // 
            this.courseLabel.AutoSize = true;
            this.courseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.courseLabel.Location = new System.Drawing.Point(66, 109);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(142, 25);
            this.courseLabel.TabIndex = 2;
            this.courseLabel.Text = "Course";
            // 
            // courseComboBox
            // 
            this.courseComboBox.DataSource = this.courseBindingSource;
            this.courseComboBox.DisplayMember = "DisplayState";
            this.courseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.Location = new System.Drawing.Point(259, 109);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(421, 21);
            this.courseComboBox.TabIndex = 3;
            this.courseComboBox.ValueMember = "Name";
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(EnrolleeHandbook.Models.Course);
            // 
            // fourthSubjectLabel
            // 
            this.fourthSubjectLabel.AutoSize = true;
            this.fourthSubjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fourthSubjectLabel.Location = new System.Drawing.Point(4, 146);
            this.fourthSubjectLabel.Name = "fourthSubjectLabel";
            this.fourthSubjectLabel.Size = new System.Drawing.Size(204, 25);
            this.fourthSubjectLabel.TabIndex = 4;
            this.fourthSubjectLabel.Text = "Fourth subject";
            // 
            // fourthsubjectComboBox
            // 
            this.fourthsubjectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fourthsubjectComboBox.FormattingEnabled = true;
            this.fourthsubjectComboBox.Items.AddRange(new object[] {
             "Physics",
             "Foreign language",
             "Biology",
             "Chemistry",
             "Ukrainian literature",
             "Geography"});
            this.fourthsubjectComboBox.Location = new System.Drawing.Point(259, 150);
            this.fourthsubjectComboBox.Name = "fourthsubjectComboBox";
            this.fourthsubjectComboBox.Size = new System.Drawing.Size(421, 21);
            this.fourthsubjectComboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(348, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Points";
            // 
            // mathsLabel
            // 
            this.mathsLabel.AutoSize = true;
            this.mathsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mathsLabel.Location = new System.Drawing.Point(85, 250);
            this.mathsLabel.Name = "mathsLabel";
            this.mathsLabel.Size = new System.Drawing.Size(131, 25);
            this.mathsLabel.TabIndex = 7;
            this.mathsLabel.Text = "Mathematics";
            // 
            // mathNumericUpDown
            // 
            this.mathNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.mathNumericUpDown.Location = new System.Drawing.Point(260, 255);
            this.mathNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.mathNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.mathNumericUpDown.Name = "mathNumericUpDown";
            this.mathNumericUpDown.Size = new System.Drawing.Size(421, 20);
            this.mathNumericUpDown.TabIndex = 8;
            this.mathNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // ukrLanguageNumericUpDown
            // 
            this.ukrLanguageNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.ukrLanguageNumericUpDown.Location = new System.Drawing.Point(260, 289);
            this.ukrLanguageNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.ukrLanguageNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ukrLanguageNumericUpDown.Name = "ukrLanguageNumericUpDown";
            this.ukrLanguageNumericUpDown.Size = new System.Drawing.Size(421, 20);
            this.ukrLanguageNumericUpDown.TabIndex = 10;
            this.ukrLanguageNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // ukrLanguageLabel
            // 
            this.ukrLanguageLabel.AutoSize = true;
            this.ukrLanguageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ukrLanguageLabel.Location = new System.Drawing.Point(51, 284);
            this.ukrLanguageLabel.Name = "ukrLanguageLabel";
            this.ukrLanguageLabel.Size = new System.Drawing.Size(165, 25);
            this.ukrLanguageLabel.TabIndex = 9;
            this.ukrLanguageLabel.Text = "Ukrainian language";
            // 
            // historyNumericUpDown
            // 
            this.historyNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.historyNumericUpDown.Location = new System.Drawing.Point(260, 325);
            this.historyNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.historyNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.historyNumericUpDown.Name = "historyNumericUpDown";
            this.historyNumericUpDown.Size = new System.Drawing.Size(421, 20);
            this.historyNumericUpDown.TabIndex = 12;
            this.historyNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // historyLabel
            // 
            this.historyLabel.AutoSize = true;
            this.historyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historyLabel.Location = new System.Drawing.Point(64, 320);
            this.historyLabel.Name = "historyLabel";
            this.historyLabel.Size = new System.Drawing.Size(152, 25);
            this.historyLabel.TabIndex = 11;
            this.historyLabel.Text = "History of Ukraine";
            // 
            // fourthSubjectNumericUpDown
            // 
            this.fourthSubjectNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.fourthSubjectNumericUpDown.Location = new System.Drawing.Point(260, 360);
            this.fourthSubjectNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.fourthSubjectNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.fourthSubjectNumericUpDown.Name = "fourthSubjectNumericUpDown";
            this.fourthSubjectNumericUpDown.Size = new System.Drawing.Size(421, 20);
            this.fourthSubjectNumericUpDown.TabIndex = 14;
            this.fourthSubjectNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // fourthSubjectMarkLabel
            // 
            this.fourthSubjectMarkLabel.AutoSize = true;
            this.fourthSubjectMarkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fourthSubjectMarkLabel.Location = new System.Drawing.Point(12, 355);
            this.fourthSubjectMarkLabel.Name = "fourthSubjectMarkLabel";
            this.fourthSubjectMarkLabel.Size = new System.Drawing.Size(204, 25);
            this.fourthSubjectMarkLabel.TabIndex = 13;
            this.fourthSubjectMarkLabel.Text = "Fourth subject";
            // 
            // additionalPointsNumericUpDown
            // 
            this.additionalPointsNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.additionalPointsNumericUpDown.Location = new System.Drawing.Point(260, 395);
            this.additionalPointsNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.additionalPointsNumericUpDown.Name = "additionalPointsNumericUpDown";
            this.additionalPointsNumericUpDown.Size = new System.Drawing.Size(421, 20);
            this.additionalPointsNumericUpDown.TabIndex = 16;
            // 
            // additionalPointsLabel
            // 
            this.additionalPointsLabel.AutoSize = true;
            this.additionalPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.additionalPointsLabel.Location = new System.Drawing.Point(58, 390);
            this.additionalPointsLabel.Name = "additionalPointsLabel";
            this.additionalPointsLabel.Size = new System.Drawing.Size(158, 25);
            this.additionalPointsLabel.TabIndex = 15;
            this.additionalPointsLabel.Text = "Additional points";
            // 
            // countButton
            // 
            this.countButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countButton.Location = new System.Drawing.Point(705, 512);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(164, 33);
            this.countButton.TabIndex = 18;
            this.countButton.Text = "Calculate";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // universityLabel
            // 
            this.universityLabel.AutoSize = true;
            this.universityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.universityLabel.Location = new System.Drawing.Point(81, 68);
            this.universityLabel.Name = "universityLabel";
            this.universityLabel.Size = new System.Drawing.Size(127, 25);
            this.universityLabel.TabIndex = 0;
            this.universityLabel.Text = "University";
            // 
            // universityComboBox
            // 
            this.universityComboBox.DataSource = this.universityBindingSource;
            this.universityComboBox.DisplayMember = "Name";
            this.universityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.universityComboBox.FormattingEnabled = true;
            this.universityComboBox.Location = new System.Drawing.Point(259, 74);
            this.universityComboBox.Name = "universityComboBox";
            this.universityComboBox.Size = new System.Drawing.Size(421, 21);
            this.universityComboBox.TabIndex = 1;
            this.universityComboBox.SelectedIndexChanged += new System.EventHandler(this.universityComboBox_SelectedIndexChanged);
            // 
            // universityBindingSource
            // 
            this.universityBindingSource.DataSource = typeof(EnrolleeHandbook.Models.University);
            // 
            // returnButton
            // 
            this.returnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returnButton.Location = new System.Drawing.Point(17, 512);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(164, 33);
            this.returnButton.TabIndex = 19;
            this.returnButton.Text = "Back";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // rezultLabel
            // 
            this.rezultLabel.AutoSize = true;
            this.rezultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rezultLabel.Location = new System.Drawing.Point(59, 438);
            this.rezultLabel.Name = "rezultLabel";
            this.rezultLabel.Size = new System.Drawing.Size(157, 25);
            this.rezultLabel.TabIndex = 17;
            this.rezultLabel.Text = "Competitive score";
            // 
            // conclusionLabel
            // 
            this.conclusionLabel.AutoSize = true;
            this.conclusionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.conclusionLabel.Location = new System.Drawing.Point(59, 474);
            this.conclusionLabel.Name = "conclusionLabel";
            this.conclusionLabel.Size = new System.Drawing.Size(0, 25);
            this.conclusionLabel.TabIndex = 20;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 570);
            this.Controls.Add(this.conclusionLabel);
            this.Controls.Add(this.rezultLabel);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.universityComboBox);
            this.Controls.Add(this.universityLabel);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.additionalPointsNumericUpDown);
            this.Controls.Add(this.additionalPointsLabel);
            this.Controls.Add(this.fourthSubjectNumericUpDown);
            this.Controls.Add(this.fourthSubjectMarkLabel);
            this.Controls.Add(this.historyNumericUpDown);
            this.Controls.Add(this.historyLabel);
            this.Controls.Add(this.ukrLanguageNumericUpDown);
            this.Controls.Add(this.ukrLanguageLabel);
            this.Controls.Add(this.mathNumericUpDown);
            this.Controls.Add(this.mathsLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fourthsubjectComboBox);
            this.Controls.Add(this.fourthSubjectLabel);
            this.Controls.Add(this.courseComboBox);
            this.Controls.Add(this.courseLabel);
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(200, 200);
            this.MaximumSize = new System.Drawing.Size(917, 609);
            this.MinimumSize = new System.Drawing.Size(917, 609);
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Competitive score calculator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CalculatorForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CalculatorForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ukrLanguageNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourthSubjectNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalPointsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label courseLabel;
        private System.Windows.Forms.Label fourthSubjectLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label mathsLabel;
        private System.Windows.Forms.Label ukrLanguageLabel;
        private System.Windows.Forms.Label historyLabel;
        private System.Windows.Forms.Label fourthSubjectMarkLabel;
        private System.Windows.Forms.Label additionalPointsLabel;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.Label universityLabel;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.BindingSource universityBindingSource;
        internal System.Windows.Forms.ComboBox courseComboBox;
        internal System.Windows.Forms.ComboBox fourthsubjectComboBox;
        internal System.Windows.Forms.NumericUpDown mathNumericUpDown;
        internal System.Windows.Forms.NumericUpDown ukrLanguageNumericUpDown;
        internal System.Windows.Forms.NumericUpDown historyNumericUpDown;
        internal System.Windows.Forms.NumericUpDown fourthSubjectNumericUpDown;
        internal System.Windows.Forms.NumericUpDown additionalPointsNumericUpDown;
        internal System.Windows.Forms.ComboBox universityComboBox;
        internal System.Windows.Forms.Label rezultLabel;
        internal System.Windows.Forms.Label conclusionLabel;
    }
}