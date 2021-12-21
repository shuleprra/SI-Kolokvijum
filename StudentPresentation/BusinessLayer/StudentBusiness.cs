using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class StudentBusiness
    {
        private readonly StudentRepository studentRepository = new StudentRepository();

        public bool InsertStudent(Student s)
        {
            if (this.studentRepository.InsertStudent(s) > 0)
                return true;
            return false;
        }

        public List<Student> GetAllStudents()
        {
            //proveravam da li je na budzetu?

            //trenutna godina * 37 za samofinansirajuce
            //trenutna godina * 48 za budzet


            return this.studentRepository.GetAllStudents().Where(s => s.PointsESPB >= s.StudyYear * 37).ToList();
        }


    }
}
