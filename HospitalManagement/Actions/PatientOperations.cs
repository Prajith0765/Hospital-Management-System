using HospitalManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Actions
{
    internal class PatientOperations
    {

        public List<Patient> totalPatients;
        GetterSetter getSet;
        Patient patient;
        PatientOperations()
        {
            totalPatients = new List<Patient>();
           
            getSet = new GetterSetter();
        }

        public string generateId(string prefix)
        {
            string lastId = totalPatients.Last().patientId;

            int number = int.Parse(lastId.Substring(3));
            return prefix + (number + 1).ToString("D3");

        }
        public void RegisterPatient()
        {
            string id = generateId("PTO");
            patient = new Patient(getSet.getName(), getSet.getAge(), getSet.getGender(), id); 
            totalPatients.Add(patient);

        }

        public void bookAppointment()
        {
            Patient patient = getPatient(getSet.getId());
            
            
        }



        public Patient getPatient(string id)
        {
            Patient patient = totalPatients.Find(x => x.patientId == id);
            if (patient == null)
            {
                Console.WriteLine("Patient not Found");
               
            }
            return patient;
        }
    }
}
