using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class PrescriptionBusiness
    {
        private PrescriptionsRepository presciptionRepository = new PrescriptionsRepository();

        public bool InsertPrescription(Prescription p)
        {
            return this.presciptionRepository.InsertPrescription(p) > 0;
        }

        public List<Prescription> GetAllPrescription()
        {
            return this.presciptionRepository.GetAllPrescriptions().Where(s => s.PrescriptionDate > DateTime.Now).ToList();
        }

    }
}
