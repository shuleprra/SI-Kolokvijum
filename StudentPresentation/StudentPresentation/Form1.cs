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

namespace StudentPresentation
{
    public partial class Form1 : Form
    {
        private readonly StudentBusiness studentBusiness = new StudentBusiness();
        public Form1()
        {
            InitializeComponent();
        }


        private void RefreshData()
        {
            listBox_Students.Items.Clear();


            List<Student> studentsList = new List<Student>();
            studentsList = this.studentBusiness.GetAllStudents();

            foreach (Student s in studentsList)
            {
                if(s!=null)
                    listBox_Students.Items.Add(s.Id + ". " + s.StudentName +
                        " - " + s.IndexNumber + " - " + s.PointsESPB +
                        " - " + s.StudyYear + " - Budget: " + s.IsBudget);
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void button_InsertStudent_Click(object sender, EventArgs e)
        {
            Student s = new Student();

            s.StudentName = textBox_StudentName.Text;
            s.IndexNumber = textBox_IndexNumber.Text;
            s.PointsESPB = Convert.ToInt32(textBox_ESPBPoints.Text);
            s.StudyYear = Convert.ToInt32(textBox_StudyYear.Text);
            s.AverageMark = Convert.ToDecimal(textBox_AverageMark.Text);
            s.IsBudget = checkBox_IsBudget.Checked;

            this.studentBusiness.InsertStudent(s);

            RefreshData();
        }
    }
}
