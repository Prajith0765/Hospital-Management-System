using HospitalManagement.Departments;
using HospitalManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HospitalManagement.DeptEnum;

namespace HospitalManagement
{
    internal class DisplayDoctors
    {

        public void DisplayDoctorsByDepartment()
        {
            foreach (Dept dept in Enum.GetValues(typeof(Dept)))
            {
                Console.WriteLine($"\nDepartment: {dept}");

                List<Doctor> doctors = dept switch
                {
                    Dept.Cardiology => new Cardiology().GetDoctors(),
                    Dept.GeneralMedicine => new GeneralMedicine().GetDoctors(),
                    Dept.Orthopedics => new Orthopedics().GetDoctors(),
                    Dept.Neurology => new Neurology().GetDoctors(),
                    Dept.Dermatology => new Dermatology().GetDoctors(),
                    _ => new List<Doctor>()
                };

                if (doctors.Count == 0)
                {
                    Console.WriteLine("No doctors available.");
                }

                foreach (Doctor doctor in doctors)
                {
                    Console.WriteLine($"- {doctor.doctorName} ({doctor.doctorId}, {doctor.doctorType}, {doctor.experience} yrs)");
                }
            }
        }
    }
}
