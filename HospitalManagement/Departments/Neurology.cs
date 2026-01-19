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
        public List<Doctor> GetDoctors()
        {
            return new List<Doctor>
            {
                new Doctor("Dr. William Anderson", "Neurologist", 13, "DOC010"),
                new Doctor("Dr. Patricia Taylor", "Neurologist", 9, "DOC011"),
                new Doctor("Dr. Christopher Thomas", "Neurologist", 11, "DOC012")
            };
        }
    }
}
