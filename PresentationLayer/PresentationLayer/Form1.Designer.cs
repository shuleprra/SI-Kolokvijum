namespace PresentationLayer
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
            this.button_InsertPrescription = new System.Windows.Forms.Button();
            this.label_PatientName = new System.Windows.Forms.Label();
            this.label_PrescribedMedication = new System.Windows.Forms.Label();
            this.label_PrescriptionDate = new System.Windows.Forms.Label();
            this.label_PrescriptionPrice = new System.Windows.Forms.Label();
            this.textBox_PatientName = new System.Windows.Forms.TextBox();
            this.textBox_PrescribedMedication = new System.Windows.Forms.TextBox();
            this.textBox_PrescriptionDate = new System.Windows.Forms.TextBox();
            this.textBox_PrescriptionPrice = new System.Windows.Forms.TextBox();
            this.listBox_Prescriptions = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_InsertPrescription
            // 
            this.button_InsertPrescription.Location = new System.Drawing.Point(439, 60);
            this.button_InsertPrescription.Name = "button_InsertPrescription";
            this.button_InsertPrescription.Size = new System.Drawing.Size(159, 87);
            this.button_InsertPrescription.TabIndex = 0;
            this.button_InsertPrescription.Text = "Insert Prescription";
            this.button_InsertPrescription.UseVisualStyleBackColor = true;
            this.button_InsertPrescription.Click += new System.EventHandler(this.button_InsertPrescription_Click);
            // 
            // label_PatientName
            // 
            this.label_PatientName.AutoSize = true;
            this.label_PatientName.Location = new System.Drawing.Point(32, 38);
            this.label_PatientName.Name = "label_PatientName";
            this.label_PatientName.Size = new System.Drawing.Size(74, 13);
            this.label_PatientName.TabIndex = 1;
            this.label_PatientName.Text = "Patient Name:";
            // 
            // label_PrescribedMedication
            // 
            this.label_PrescribedMedication.AutoSize = true;
            this.label_PrescribedMedication.Location = new System.Drawing.Point(32, 76);
            this.label_PrescribedMedication.Name = "label_PrescribedMedication";
            this.label_PrescribedMedication.Size = new System.Drawing.Size(112, 13);
            this.label_PrescribedMedication.TabIndex = 2;
            this.label_PrescribedMedication.Text = "Prescribed Medication";
            // 
            // label_PrescriptionDate
            // 
            this.label_PrescriptionDate.AutoSize = true;
            this.label_PrescriptionDate.Location = new System.Drawing.Point(32, 113);
            this.label_PrescriptionDate.Name = "label_PrescriptionDate";
            this.label_PrescriptionDate.Size = new System.Drawing.Size(88, 13);
            this.label_PrescriptionDate.TabIndex = 3;
            this.label_PrescriptionDate.Text = "Prescription Date";
            // 
            // label_PrescriptionPrice
            // 
            this.label_PrescriptionPrice.AutoSize = true;
            this.label_PrescriptionPrice.Location = new System.Drawing.Point(32, 150);
            this.label_PrescriptionPrice.Name = "label_PrescriptionPrice";
            this.label_PrescriptionPrice.Size = new System.Drawing.Size(89, 13);
            this.label_PrescriptionPrice.TabIndex = 4;
            this.label_PrescriptionPrice.Text = "Prescription Price";
            // 
            // textBox_PatientName
            // 
            this.textBox_PatientName.Location = new System.Drawing.Point(183, 35);
            this.textBox_PatientName.Name = "textBox_PatientName";
            this.textBox_PatientName.Size = new System.Drawing.Size(152, 20);
            this.textBox_PatientName.TabIndex = 5;
            // 
            // textBox_PrescribedMedication
            // 
            this.textBox_PrescribedMedication.Location = new System.Drawing.Point(183, 73);
            this.textBox_PrescribedMedication.Name = "textBox_PrescribedMedication";
            this.textBox_PrescribedMedication.Size = new System.Drawing.Size(152, 20);
            this.textBox_PrescribedMedication.TabIndex = 6;
            // 
            // textBox_PrescriptionDate
            // 
            this.textBox_PrescriptionDate.Location = new System.Drawing.Point(183, 110);
            this.textBox_PrescriptionDate.Name = "textBox_PrescriptionDate";
            this.textBox_PrescriptionDate.Size = new System.Drawing.Size(152, 20);
            this.textBox_PrescriptionDate.TabIndex = 7;
            // 
            // textBox_PrescriptionPrice
            // 
            this.textBox_PrescriptionPrice.Location = new System.Drawing.Point(183, 147);
            this.textBox_PrescriptionPrice.Name = "textBox_PrescriptionPrice";
            this.textBox_PrescriptionPrice.Size = new System.Drawing.Size(152, 20);
            this.textBox_PrescriptionPrice.TabIndex = 8;
            // 
            // listBox_Prescriptions
            // 
            this.listBox_Prescriptions.FormattingEnabled = true;
            this.listBox_Prescriptions.Location = new System.Drawing.Point(35, 212);
            this.listBox_Prescriptions.Name = "listBox_Prescriptions";
            this.listBox_Prescriptions.Size = new System.Drawing.Size(577, 225);
            this.listBox_Prescriptions.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox_Prescriptions);
            this.Controls.Add(this.textBox_PrescriptionPrice);
            this.Controls.Add(this.textBox_PrescriptionDate);
            this.Controls.Add(this.textBox_PrescribedMedication);
            this.Controls.Add(this.textBox_PatientName);
            this.Controls.Add(this.label_PrescriptionPrice);
            this.Controls.Add(this.label_PrescriptionDate);
            this.Controls.Add(this.label_PrescribedMedication);
            this.Controls.Add(this.label_PatientName);
            this.Controls.Add(this.button_InsertPrescription);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_InsertPrescription;
        private System.Windows.Forms.Label label_PatientName;
        private System.Windows.Forms.Label label_PrescribedMedication;
        private System.Windows.Forms.Label label_PrescriptionDate;
        private System.Windows.Forms.Label label_PrescriptionPrice;
        private System.Windows.Forms.TextBox textBox_PatientName;
        private System.Windows.Forms.TextBox textBox_PrescribedMedication;
        private System.Windows.Forms.TextBox textBox_PrescriptionDate;
        private System.Windows.Forms.TextBox textBox_PrescriptionPrice;
        private System.Windows.Forms.ListBox listBox_Prescriptions;
    }
}

