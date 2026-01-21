using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HospitalManagement.Actions
{
    internal class GetterSetter
    {

        
        public string getName()
        {
            Console.WriteLine("Enter the Name: ");
            return Console.ReadLine();
        }

        public byte getAge()
        {
            Console.WriteLine("Enter the Age: ");
            byte age;
            byte.TryParse(Console.ReadLine(), out age);
            return age;
        }

        public char getGender()
        {
            Console.WriteLine("Select the Gender (M / F) : ");
            char gender;
            char.TryParse(Console.ReadLine(), out gender);
            return gender;
        }

        public string getPatientId()
        {
            Console.WriteLine("Enter the Patient ID: ");
            return Console.ReadLine();
        }

        public string getDoctorId()
        {
            Console.WriteLine("Enter the Doctor ID: ");
            return Console.ReadLine();
        }

        public DateTime getDate()
        {
            Console.WriteLine("Enter the Date (yyyy-MM-dd): ");
            DateTime date;
            DateTime.TryParse(Console.ReadLine(), out date);
            return date;
        }
    }
}
