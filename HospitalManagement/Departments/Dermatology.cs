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
        List<Doctor> doctors;
        public Dermatology()
        {
            doctors = new List<Doctor>
            {
                new Doctor("Dr. Emily Johnson", "Dermatologist", 10),
                new Doctor("Dr. Michael Brown", "Dermatologist", 8),
                new Doctor("Dr. Jessica Miller", "Dermatologist", 12)
            };
        }
    }
}
