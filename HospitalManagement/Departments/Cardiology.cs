using HospitalManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Departments
{
    internal class Cardiology
    {
        List<Doctor> doctors;
        public Cardiology()
        {
            doctors = new List<Doctor>
            {
                new Doctor("Dr. Sarah Thompson", "Cardiologist", 14),
                new Doctor("Dr. James Wilson", "Cardiologist", 11),
                new Doctor("Dr. Karen Garcia", "Cardiologist", 9)
            };
        }
    }
}
