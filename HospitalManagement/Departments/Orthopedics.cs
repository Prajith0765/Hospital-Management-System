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
        public List<Doctor> GetDoctors()
        {
            return new List<Doctor>
            {
                new Doctor("Dr. Alice Williams", "Orthopedic Surgeon", 15, "DOC013"),
                new Doctor("Dr. Robert Davis", "Orthopedic Surgeon", 10, "DOC014"),
                new Doctor("Dr. Linda Martinez", "Orthopedic Surgeon", 12, "DOC015")
            };
        }
    }
}
