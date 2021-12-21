using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class StudentRepository
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        

        public int InsertStudent(Student s)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = String.Format("INSERT INTO Students VALUES('{0}','{1}',{2},{3},{4},{5})",
                    s.StudentName, s.IndexNumber, s.PointsESPB, s.StudyYear, s.AverageMark, s.IsBudget);


                connection.Open();
                return cmd.ExecuteNonQuery();
            }
        }
        
        public List<Student> GetAllStudents()
        {
            List<Student> studentList = new List<Student>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM Students";

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    Student s = new Student();
                    s.Id = reader.GetInt32(0);
                    s.StudentName = reader.GetString(1);
                    s.IndexNumber = reader.GetString(2);
                    s.PointsESPB = reader.GetInt32(3);
                    s.StudyYear = reader.GetInt32(4);
                    s.AverageMark = reader.GetDecimal(5);
                    s.IsBudget = reader.GetBoolean(6);

                    studentList.Add(s);
                }
                return studentList;
            }
        }
    
    }
}
