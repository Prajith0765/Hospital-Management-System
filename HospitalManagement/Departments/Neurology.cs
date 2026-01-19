using HospitalManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Departments
{
    internal class Neurology
    {
        List<Doctor> doctors;
        public Neurology()
        {
            doctors = new List<Doctor>
            {
                new Doctor("Dr. William Anderson", "Neurologist", 13),
                new Doctor("Dr. Patricia Taylor", "Neurologist", 9),
                new Doctor("Dr. Christopher Thomas", "Neurologist", 11)
            };
        }
    }
}
