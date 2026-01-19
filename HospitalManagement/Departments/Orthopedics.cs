using HospitalManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Departments
{
    internal class Orthopedics
    {
        List<Doctor> doctors;
        public Orthopedics()
        {
            doctors = new List<Doctor>
            {
                new Doctor("Dr. Alice Williams", "Orthopedic Surgeon", 15),
                new Doctor("Dr. Robert Davis", "Orthopedic Surgeon", 10),
                new Doctor("Dr. Linda Martinez", "Orthopedic Surgeon", 12)
            };
        }
    }
}
