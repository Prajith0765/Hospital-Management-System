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
    internal static class DisplayDoctors
    {

        public static void DisplayDoctorsByDepartment()
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

        public static Doctor getDoctor(string id)
        {
            foreach (Dept dept in Enum.GetValues(typeof(Dept)))
            {
                List<Doctor> doctors = dept switch
                {
                    Dept.Cardiology => new Cardiology().GetDoctors(),
                    Dept.GeneralMedicine => new GeneralMedicine().GetDoctors(),
                    Dept.Orthopedics => new Orthopedics().GetDoctors(),
                    Dept.Neurology => new Neurology().GetDoctors(),
                    Dept.Dermatology => new Dermatology().GetDoctors(),
                    _ => new List<Doctor>()
                };
                foreach (Doctor doctor in doctors)
                {
                    if (doctor.doctorId.Equals(id, StringComparison.OrdinalIgnoreCase))
                    {
                        return doctor;
                    }
                }
            }
            return null;
        }


        public static void displayTotalPatients(List<Patient> totalPatients)
        {
            foreach (Patient patient in totalPatients)
            {
                Console.WriteLine($"Patient Name: {patient.name}, ID: {patient.patientId}, Age: {patient.age}, Gender: {patient.gender}");
            }
        }

        public static void displayPatientsOfDoctor(Doctor doctor)
        {
            Console.WriteLine($"\nPatients of Dr. {doctor.doctorName} ({doctor.doctorId}):");
            if (doctor.patientsList.Count == 0)
            {
                Console.WriteLine("No patients assigned.");
            }
            else
            {
                foreach (Patient patient in doctor.patientsList)
                {
                    Console.WriteLine($"- {patient.name} (ID: {patient.patientId}, Age: {patient.age}, Gender: {patient.age})");
                }
            }
        }
    }
}