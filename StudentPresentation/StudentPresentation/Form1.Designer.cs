namespace StudentPresentation
{
    partial class Form1
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
            this.listBox_Students = new System.Windows.Forms.ListBox();
            this.button_InsertStudent = new System.Windows.Forms.Button();
            this.label_StudentName = new System.Windows.Forms.Label();
            this.label_IndexNumber = new System.Windows.Forms.Label();
            this.label_PointsESPB = new System.Windows.Forms.Label();
            this.label_StudyYear = new System.Windows.Forms.Label();
            this.label_AverageMark = new System.Windows.Forms.Label();
            this.label_IsBudget = new System.Windows.Forms.Label();
            this.textBox_StudentName = new System.Windows.Forms.TextBox();
            this.textBox_IndexNumber = new System.Windows.Forms.TextBox();
            this.textBox_ESPBPoints = new System.Windows.Forms.TextBox();
            this.textBox_StudyYear = new System.Windows.Forms.TextBox();
            this.textBox_AverageMark = new System.Windows.Forms.TextBox();
            this.checkBox_IsBudget = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // listBox_Students
            // 
            this.listBox_Students.FormattingEnabled = true;
            this.listBox_Students.Location = new System.Drawing.Point(36, 21);
            this.listBox_Students.Name = "listBox_Students";
            this.listBox_Students.Size = new System.Drawing.Size(706, 212);
            this.listBox_Students.TabIndex = 0;
            // 
            // button_InsertStudent
            // 
            this.button_InsertStudent.Location = new System.Drawing.Point(425, 284);
            this.button_InsertStudent.Name = "button_InsertStudent";
            this.button_InsertStudent.Size = new System.Drawing.Size(120, 46);
            this.button_InsertStudent.TabIndex = 1;
            this.button_InsertStudent.Text = "Insert";
            this.button_InsertStudent.UseVisualStyleBackColor = true;
            this.button_InsertStudent.Click += new System.EventHandler(this.button_InsertStudent_Click);
            // 
            // label_StudentName
            // 
            this.label_StudentName.AutoSize = true;
            this.label_StudentName.Location = new System.Drawing.Point(45, 239);
            this.label_StudentName.Name = "label_StudentName";
            this.label_StudentName.Size = new System.Drawing.Size(75, 13);
            this.label_StudentName.TabIndex = 2;
            this.label_StudentName.Text = "Student Name";
            // 
            // label_IndexNumber
            // 
            this.label_IndexNumber.AutoSize = true;
            this.label_IndexNumber.Location = new System.Drawing.Point(45, 265);
            this.label_IndexNumber.Name = "label_IndexNumber";
            this.label_IndexNumber.Size = new System.Drawing.Size(73, 13);
            this.label_IndexNumber.TabIndex = 3;
            this.label_IndexNumber.Text = "Index Number";
            // 
            // label_PointsESPB
            // 
            this.label_PointsESPB.AutoSize = true;
            this.label_PointsESPB.Location = new System.Drawing.Point(45, 291);
            this.label_PointsESPB.Name = "label_PointsESPB";
            this.label_PointsESPB.Size = new System.Drawing.Size(67, 13);
            this.label_PointsESPB.TabIndex = 4;
            this.label_PointsESPB.Text = "ESPB Points";
            // 
            // label_StudyYear
            // 
            this.label_StudyYear.AutoSize = true;
            this.label_StudyYear.Location = new System.Drawing.Point(45, 317);
            this.label_StudyYear.Name = "label_StudyYear";
            this.label_StudyYear.Size = new System.Drawing.Size(59, 13);
            this.label_StudyYear.TabIndex = 5;
            this.label_StudyYear.Text = "Study Year";
            // 
            // label_AverageMark
            // 
            this.label_AverageMark.AutoSize = true;
            this.label_AverageMark.Location = new System.Drawing.Point(47, 345);
            this.label_AverageMark.Name = "label_AverageMark";
            this.label_AverageMark.Size = new System.Drawing.Size(73, 13);
            this.label_AverageMark.TabIndex = 6;
            this.label_AverageMark.Text = "Average mark";
            // 
            // label_IsBudget
            // 
            this.label_IsBudget.AutoSize = true;
            this.label_IsBudget.Location = new System.Drawing.Point(47, 381);
            this.label_IsBudget.Name = "label_IsBudget";
            this.label_IsBudget.Size = new System.Drawing.Size(41, 13);
            this.label_IsBudget.TabIndex = 7;
            this.label_IsBudget.Text = "Budget";
            // 
            // textBox_StudentName
            // 
            this.textBox_StudentName.Location = new System.Drawing.Point(141, 239);
            this.textBox_StudentName.Name = "textBox_StudentName";
            this.textBox_StudentName.Size = new System.Drawing.Size(151, 20);
            this.textBox_StudentName.TabIndex = 8;
            // 
            // textBox_IndexNumber
            // 
            this.textBox_IndexNumber.Location = new System.Drawing.Point(141, 265);
            this.textBox_IndexNumber.Name = "textBox_IndexNumber";
            this.textBox_IndexNumber.Size = new System.Drawing.Size(151, 20);
            this.textBox_IndexNumber.TabIndex = 9;
            // 
            // textBox_ESPBPoints
            // 
            this.textBox_ESPBPoints.Location = new System.Drawing.Point(141, 291);
            this.textBox_ESPBPoints.Name = "textBox_ESPBPoints";
            this.textBox_ESPBPoints.Size = new System.Drawing.Size(151, 20);
            this.textBox_ESPBPoints.TabIndex = 10;
            // 
            // textBox_StudyYear
            // 
            this.textBox_StudyYear.Location = new System.Drawing.Point(141, 317);
            this.textBox_StudyYear.Name = "textBox_StudyYear";
            this.textBox_StudyYear.Size = new System.Drawing.Size(151, 20);
            this.textBox_StudyYear.TabIndex = 11;
            // 
            // textBox_AverageMark
            // 
            this.textBox_AverageMark.Location = new System.Drawing.Point(141, 345);
            this.textBox_AverageMark.Name = "textBox_AverageMark";
            this.textBox_AverageMark.Size = new System.Drawing.Size(151, 20);
            this.textBox_AverageMark.TabIndex = 12;
            // 
            // checkBox_IsBudget
            // 
            this.checkBox_IsBudget.AutoSize = true;
            this.checkBox_IsBudget.Location = new System.Drawing.Point(141, 380);
            this.checkBox_IsBudget.Name = "checkBox_IsBudget";
            this.checkBox_IsBudget.Size = new System.Drawing.Size(91, 17);
            this.checkBox_IsBudget.TabIndex = 13;
            this.checkBox_IsBudget.Text = "Is on budget?";
            this.checkBox_IsBudget.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox_IsBudget);
            this.Controls.Add(this.textBox_AverageMark);
            this.Controls.Add(this.textBox_StudyYear);
            this.Controls.Add(this.textBox_ESPBPoints);
            this.Controls.Add(this.textBox_IndexNumber);
            this.Controls.Add(this.textBox_StudentName);
            this.Controls.Add(this.label_IsBudget);
            this.Controls.Add(this.label_AverageMark);
            this.Controls.Add(this.label_StudyYear);
            this.Controls.Add(this.label_PointsESPB);
            this.Controls.Add(this.label_IndexNumber);
            this.Controls.Add(this.label_StudentName);
            this.Controls.Add(this.button_InsertStudent);
            this.Controls.Add(this.listBox_Students);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Students;
        private System.Windows.Forms.Button button_InsertStudent;
        private System.Windows.Forms.Label label_StudentName;
        private System.Windows.Forms.Label label_IndexNumber;
        private System.Windows.Forms.Label label_PointsESPB;
        private System.Windows.Forms.Label label_StudyYear;
        private System.Windows.Forms.Label label_AverageMark;
        private System.Windows.Forms.Label label_IsBudget;
        private System.Windows.Forms.TextBox textBox_StudentName;
        private System.Windows.Forms.TextBox textBox_IndexNumber;
        private System.Windows.Forms.TextBox textBox_ESPBPoints;
        private System.Windows.Forms.TextBox textBox_StudyYear;
        private System.Windows.Forms.TextBox textBox_AverageMark;
        private System.Windows.Forms.CheckBox checkBox_IsBudget;
    }
}

