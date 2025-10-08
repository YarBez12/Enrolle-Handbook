namespace EnrolleeHandbook
{
    partial class MainForm
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
            this.allUniversitiesButton = new System.Windows.Forms.Button();
            this.savedUniversitiesButton = new System.Windows.Forms.Button();
            this.allCoursesButton = new System.Windows.Forms.Button();
            this.savedCoursesButton = new System.Windows.Forms.Button();
            this.calculatorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // allUniversitiesButton
            // 
            this.allUniversitiesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allUniversitiesButton.Location = new System.Drawing.Point(26, 47);
            this.allUniversitiesButton.Name = "allUniversitiesButton";
            this.allUniversitiesButton.Size = new System.Drawing.Size(350, 150);
            this.allUniversitiesButton.TabIndex = 1;
            this.allUniversitiesButton.Text = "All universities";
            this.allUniversitiesButton.UseVisualStyleBackColor = true;
            this.allUniversitiesButton.Click += new System.EventHandler(this.allUniversitiesButton_Click);
            // 
            // savedUniversitiesButton
            // 
            this.savedUniversitiesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.savedUniversitiesButton.Location = new System.Drawing.Point(513, 47);
            this.savedUniversitiesButton.Name = "savedUniversitiesButton";
            this.savedUniversitiesButton.Size = new System.Drawing.Size(350, 150);
            this.savedUniversitiesButton.TabIndex = 2;
            this.savedUniversitiesButton.Text = "Saved universities";
            this.savedUniversitiesButton.UseVisualStyleBackColor = true;
            this.savedUniversitiesButton.Click += new System.EventHandler(this.savedUniversitiesButton_Click);
            // 
            // allCoursesButton
            // 
            this.allCoursesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allCoursesButton.Location = new System.Drawing.Point(26, 216);
            this.allCoursesButton.Name = "allCoursesButton";
            this.allCoursesButton.Size = new System.Drawing.Size(350, 150);
            this.allCoursesButton.TabIndex = 3;
            this.allCoursesButton.Text = "All courses";
            this.allCoursesButton.UseVisualStyleBackColor = true;
            this.allCoursesButton.Click += new System.EventHandler(this.allCoursesButton_Click);
            // 
            // savedCoursesButton
            // 
            this.savedCoursesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.savedCoursesButton.Location = new System.Drawing.Point(513, 216);
            this.savedCoursesButton.Name = "savedCoursesButton";
            this.savedCoursesButton.Size = new System.Drawing.Size(350, 150);
            this.savedCoursesButton.TabIndex = 4;
            this.savedCoursesButton.Text = "Saved courses";
            this.savedCoursesButton.UseVisualStyleBackColor = true;
            this.savedCoursesButton.Click += new System.EventHandler(this.savedCoursesButton_Click);
            // 
            // calculatorButton
            // 
            this.calculatorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculatorButton.Location = new System.Drawing.Point(228, 381);
            this.calculatorButton.Name = "calculatorButton";
            this.calculatorButton.Size = new System.Drawing.Size(424, 177);
            this.calculatorButton.TabIndex = 5;
            this.calculatorButton.Text = "Competitive score calculator";
            this.calculatorButton.UseVisualStyleBackColor = true;
            this.calculatorButton.Click += new System.EventHandler(this.calculatorButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 570);
            this.Controls.Add(this.calculatorButton);
            this.Controls.Add(this.savedCoursesButton);
            this.Controls.Add(this.allCoursesButton);
            this.Controls.Add(this.savedUniversitiesButton);
            this.Controls.Add(this.allUniversitiesButton);
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(200, 200);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(917, 609);
            this.MinimumSize = new System.Drawing.Size(917, 609);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Enrolleer Handbook";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button allUniversitiesButton;
        private System.Windows.Forms.Button savedUniversitiesButton;
        private System.Windows.Forms.Button allCoursesButton;
        private System.Windows.Forms.Button savedCoursesButton;
        private System.Windows.Forms.Button calculatorButton;
    }
}

