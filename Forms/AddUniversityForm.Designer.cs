namespace EnrolleeHandbook.Forms
{
    partial class AddUniversityForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.rateLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.foundationYearLabel = new System.Windows.Forms.Label();
            this.siteLabel = new System.Windows.Forms.Label();
            this.siteTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.addToSavedCheckBox = new System.Windows.Forms.CheckBox();
            this.isWithHostelCheckBox = new System.Windows.Forms.CheckBox();
            this.rateNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.postLndexLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.buildingNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.indexNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.foundationYearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rateNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indexNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foundationYearNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(645, 54);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Fill in university details";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rateLabel.Location = new System.Drawing.Point(97, 224);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(71, 20);
            this.rateLabel.TabIndex = 12;
            this.rateLabel.Text = "Rating";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(197, 66);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(412, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(112, 66);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(56, 20);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // foundationYearLabel
            // 
            this.foundationYearLabel.AutoSize = true;
            this.foundationYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.foundationYearLabel.Location = new System.Drawing.Point(48, 257);
            this.foundationYearLabel.Name = "foundationYearLabel";
            this.foundationYearLabel.Size = new System.Drawing.Size(120, 20);
            this.foundationYearLabel.TabIndex = 14;
            this.foundationYearLabel.Text = "Year of foundation";
            // 
            // siteLabel
            // 
            this.siteLabel.AutoSize = true;
            this.siteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.siteLabel.Location = new System.Drawing.Point(90, 296);
            this.siteLabel.Name = "siteLabel";
            this.siteLabel.Size = new System.Drawing.Size(78, 20);
            this.siteLabel.TabIndex = 16;
            this.siteLabel.Text = "Website";
            // 
            // siteTextBox
            // 
            this.siteTextBox.Location = new System.Drawing.Point(197, 296);
            this.siteTextBox.Name = "siteTextBox";
            this.siteTextBox.Size = new System.Drawing.Size(412, 20);
            this.siteTextBox.TabIndex = 17;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(437, 361);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(172, 34);
            this.saveButton.TabIndex = 20;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // addToSavedCheckBox
            // 
            this.addToSavedCheckBox.AutoSize = true;
            this.addToSavedCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addToSavedCheckBox.Location = new System.Drawing.Point(433, 331);
            this.addToSavedCheckBox.Name = "addToSavedCheckBox";
            this.addToSavedCheckBox.Size = new System.Drawing.Size(176, 24);
            this.addToSavedCheckBox.TabIndex = 19;
            this.addToSavedCheckBox.Text = "Add to favorites";
            this.addToSavedCheckBox.UseVisualStyleBackColor = true;
            // 
            // isWithHostelCheckBox
            // 
            this.isWithHostelCheckBox.AutoSize = true;
            this.isWithHostelCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isWithHostelCheckBox.Location = new System.Drawing.Point(197, 331);
            this.isWithHostelCheckBox.Name = "isWithHostelCheckBox";
            this.isWithHostelCheckBox.Size = new System.Drawing.Size(131, 24);
            this.isWithHostelCheckBox.TabIndex = 18;
            this.isWithHostelCheckBox.Text = "Dormitory available";
            this.isWithHostelCheckBox.UseVisualStyleBackColor = true;
            // 
            // rateNumericUpDown
            // 
            this.rateNumericUpDown.Location = new System.Drawing.Point(197, 224);
            this.rateNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.rateNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rateNumericUpDown.Name = "rateNumericUpDown";
            this.rateNumericUpDown.Size = new System.Drawing.Size(412, 20);
            this.rateNumericUpDown.TabIndex = 13;
            this.rateNumericUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(102, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Address";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityLabel.Location = new System.Drawing.Point(193, 97);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(51, 20);
            this.cityLabel.TabIndex = 4;
            this.cityLabel.Text = "City";
            // 
            // postLndexLabel
            // 
            this.postLndexLabel.AutoSize = true;
            this.postLndexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.postLndexLabel.Location = new System.Drawing.Point(193, 188);
            this.postLndexLabel.Name = "postLndexLabel";
            this.postLndexLabel.Size = new System.Drawing.Size(140, 20);
            this.postLndexLabel.TabIndex = 10;
            this.postLndexLabel.Text = "Postal code";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberLabel.Location = new System.Drawing.Point(193, 159);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(115, 20);
            this.numberLabel.TabIndex = 8;
            this.numberLabel.Text = "Building number";
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.streetLabel.Location = new System.Drawing.Point(193, 129);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(64, 20);
            this.streetLabel.TabIndex = 6;
            this.streetLabel.Text = "Street";
            // 
            // cityComboBox
            // 
            this.cityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Items.AddRange(new object[] {
            "Vinnytsia",
            "Dnipro",
            "Donetsk",
            "Zhytomyr",
            "Zaporizhzhia",
            "Ivano-Frankivsk",
            "Kyiv",
            "Kropyvnytskyi",
            "Luhansk",
            "Lviv",
            "Mykolaiv",
            "Odesa",
            "Poltava",
            "Rivne",
            "Sumy",
            "Ternopil",
            "Uzhhorod",
            "Kharkiv",
            "Kherson",
            "Khmelnytskyi",
            "Cherkasy",
            "Chernivtsi",
            "Chernihiv",
            "Simferopol",
            "Sevastopol"});
            this.cityComboBox.Location = new System.Drawing.Point(250, 96);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(359, 21);
            this.cityComboBox.TabIndex = 5;
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(263, 129);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(346, 20);
            this.streetTextBox.TabIndex = 7;
            // 
            // buildingNumericUpDown
            // 
            this.buildingNumericUpDown.Location = new System.Drawing.Point(314, 159);
            this.buildingNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.buildingNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.buildingNumericUpDown.Name = "buildingNumericUpDown";
            this.buildingNumericUpDown.Size = new System.Drawing.Size(295, 20);
            this.buildingNumericUpDown.TabIndex = 9;
            this.buildingNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // indexNumericUpDown
            // 
            this.indexNumericUpDown.Location = new System.Drawing.Point(339, 188);
            this.indexNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.indexNumericUpDown.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.indexNumericUpDown.Name = "indexNumericUpDown";
            this.indexNumericUpDown.Size = new System.Drawing.Size(270, 20);
            this.indexNumericUpDown.TabIndex = 11;
            this.indexNumericUpDown.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // foundationYearNumericUpDown
            // 
            this.foundationYearNumericUpDown.Location = new System.Drawing.Point(197, 260);
            this.foundationYearNumericUpDown.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.foundationYearNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.foundationYearNumericUpDown.Name = "foundationYearNumericUpDown";
            this.foundationYearNumericUpDown.Size = new System.Drawing.Size(412, 20);
            this.foundationYearNumericUpDown.TabIndex = 15;
            this.foundationYearNumericUpDown.Value = new decimal(new int[] {
            1999,
            0,
            0,
            0});
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataSource = typeof(EnrolleeHandbook.Models.Location);
            // 
            // AddUniversityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 411);
            this.Controls.Add(this.foundationYearNumericUpDown);
            this.Controls.Add(this.indexNumericUpDown);
            this.Controls.Add(this.buildingNumericUpDown);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.streetLabel);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.postLndexLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rateNumericUpDown);
            this.Controls.Add(this.isWithHostelCheckBox);
            this.Controls.Add(this.addToSavedCheckBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.siteTextBox);
            this.Controls.Add(this.siteLabel);
            this.Controls.Add(this.foundationYearLabel);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.titleLabel);
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(250, 200);
            this.MaximumSize = new System.Drawing.Size(661, 450);
            this.MinimumSize = new System.Drawing.Size(661, 450);
            this.Name = "AddUniversityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "New university";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddUniversityForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddUniversityForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.rateNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indexNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foundationYearNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label rateLabel;
        internal System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label foundationYearLabel;
        private System.Windows.Forms.Label siteLabel;
        internal System.Windows.Forms.TextBox siteTextBox;
        private System.Windows.Forms.Button saveButton;
        internal System.Windows.Forms.NumericUpDown rateNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label postLndexLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label streetLabel;
        internal System.Windows.Forms.TextBox streetTextBox;
        internal System.Windows.Forms.NumericUpDown buildingNumericUpDown;
        internal System.Windows.Forms.NumericUpDown indexNumericUpDown;
        internal System.Windows.Forms.ComboBox cityComboBox;
        internal System.Windows.Forms.CheckBox addToSavedCheckBox;
        internal System.Windows.Forms.CheckBox isWithHostelCheckBox;
        internal System.Windows.Forms.NumericUpDown foundationYearNumericUpDown;
        private System.Windows.Forms.BindingSource locationBindingSource;
    }
}