using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PrescriptionsRepository
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PharmacyDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public int InsertPrescription(Prescription prescription)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                command.CommandText = string.Format("INSERT INTO Prescriptions VALUES('{0}','{1}','{2}',{3})",
                    prescription.PatientName,prescription.PrescribedMedication, prescription.PrescriptionDate, prescription.PrescriptionPrice);




                connection.Open();
                return command.ExecuteNonQuery();
            }
        }

        public List<Prescription> GetAllPrescriptions()
        {
            List<Prescription> prescriptionList = new List<Prescription>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                command.CommandText = "SELECT * FROM Prescriptions";

                connection.Open();

                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Prescription p = new Prescription();
                    p.Id = dataReader.GetInt32(0); //uzimamo id
                    p.PatientName = dataReader.GetString(1);
                    p.PrescribedMedication = dataReader.GetString(2);
                    p.PrescriptionDate = dataReader.GetDateTime(3);
                    p.PrescriptionPrice = dataReader.GetDecimal(4);

                    prescriptionList.Add(p);
                }
            }
            return prescriptionList;
        }
    }
}
