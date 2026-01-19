using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Entity
{
    internal class Doctor
    {

        public int num = 1;
        public string doctorId;
        public string doctorName;
        public string doctorType;
        public byte experience;
        List<Patient> patientsList;

        public Doctor(string name, string doctorType, byte experience, string id)
        {
            this.doctorName = name;
            this.doctorId = id;
            this.doctorType = doctorType;
            this.experience = experience;
            patientsList = new List<Patient>();
        }
    }
}
