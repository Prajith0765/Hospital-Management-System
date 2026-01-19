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
        List<Doctor> doctors;

        public GeneralMedicine()
        {
            doctors = new List<Doctor>
            {
                new Doctor("Dr. John Smith", "General Physician", 10),
                new Doctor("Dr. Emily Johnson", "General Physician", 8),
                new Doctor("Dr. Michael Brown", "General Physician", 12)
            };
        }
    }
}
