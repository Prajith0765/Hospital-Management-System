using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Entity
{
    internal class Patient
    {

        public string name;
        public string patientId;
        public char gender;
        public byte age;
        

        public Patient(string name, byte age, char gender, string id)
        {
            this.name = name;
            this.patientId = id;
            this.age = age;
            this.gender = gender;

        }
    }
}
