using HospitalManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Departments
{
    internal class GeneralMedicine 
    {
        public List<Doctor> GetDoctors()
        {
            return new List<Doctor>
            {
                new Doctor("Dr. John Smith", "General Physician", 10, "DOC007"),
                new Doctor("Dr. Emily Johnson", "General Physician", 8, "DOC008"),
                new Doctor("Dr. Michael Brown", "General Physician", 12, "DOC009")
            };
        }
    }
}
