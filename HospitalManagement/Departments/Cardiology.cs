using HospitalManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagement.Actions;

namespace HospitalManagement.Departments
{
    internal class Cardiology
    {
        
        public List<Doctor> GetDoctors()
        {
            return new List<Doctor>
        {
            new Doctor("Dr. Sarah Thompson", "Cardiologist", 14, "DOC001"),
            new Doctor("Dr. James Wilson", "Cardiologist", 11, "DOC002"),
            new Doctor("Dr. Karen Garcia", "Cardiologist", 9, "DOC003"),
        };
        }
    }
}
