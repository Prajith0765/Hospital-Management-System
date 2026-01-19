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
        public int num = 1;
        public int patientId;
        public byte age;
        

        public Patient(string name, byte age)
        {
            this.name = name;
            this.patientId = num++;
            this.age = age;

        }
    }
}
