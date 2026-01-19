using HospitalManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Departments
{
    internal class Dermatology
    {
        
        public List<Doctor> GetDoctors()
        {
            return new List<Doctor>
            {
                new Doctor("Dr. Emily Johnson", "Dermatologist", 10, "DOC004"),
                new Doctor("Dr. Michael Brown", "Dermatologist", 8, "DOC005"),
                new Doctor("Dr. Jessica Miller", "Dermatologist", 12, "DOC006")
            };
        }
    }
}
