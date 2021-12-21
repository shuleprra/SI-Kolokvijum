using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        private PrescriptionBusiness prescriptionBusiness = new PrescriptionBusiness();
        public Form1()
        {
            InitializeComponent();
        }

        private void button_InsertPrescription_Click(object sender, EventArgs e)
        {
            
            Prescription p = new Prescription();
            p.PatientName = textBox_PatientName.Text;
            p.PrescribedMedication = textBox_PrescribedMedication.Text;
            p.PrescriptionDate = Convert.ToDateTime(textBox_PrescriptionDate.Text);
            p.PrescriptionPrice = Convert.ToDecimal(textBox_PrescriptionPrice.Text);



            this.prescriptionBusiness.InsertPrescription(p);


            RefreshData();
            textBox_PatientName.Text = "";
            textBox_PrescribedMedication.Text = "";
            textBox_PrescriptionDate.Text = "";
            textBox_PrescriptionPrice.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            listBox_Prescriptions.Items.Clear();
            List<Prescription> prescriptions = this.prescriptionBusiness.GetAllPrescription();

            foreach (Prescription p in prescriptions)
                listBox_Prescriptions.Items.Add(p.Id + ". " + p.PatientName + " - " + p.PrescribedMedication + " - " + p.PrescriptionPrice);
        
        }
    }
}
