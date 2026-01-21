
using HospitalManagement;
using HospitalManagement.Actions;
using HospitalManagement.Entity;

GetterSetter getterSetter = new GetterSetter();
PatientOperations patientOperations = new PatientOperations();

ErrorHandler:
try
{
Starting:
    Console.WriteLine("Welcome to Hospital Management System");
    Console.WriteLine("Select Your Choice:\n1.Display Doctors by Department\n2.Register Patient\n"+
                   "3.Book Appointment\n4.View Total Patients\n5.View Doctor List\n6.Exit");
    byte opt;
    byte.TryParse(Console.ReadLine(), out opt);

    switch (opt)
    {
        case 1:
            DisplayDoctors.DisplayDoctorsByDepartment();
            break;
        case 2:
            patientOperations.RegisterPatient();
            break;
        case 3:
            Patient patient = patientOperations.getPatient(getterSetter.getPatientId());
            //DateTime date = getSet.getDate();
            Doctor doctor = DisplayDoctors.getDoctor(getterSetter.getDoctorId());
            patientOperations.bookAppointment(patient, doctor);
            break;
        case 4:
            patientOperations.displayPatients();
            break;
        case 5:
            string doctorId = getterSetter.getDoctorId();
            
            DisplayDoctors.displayPatientsOfDoctor(DisplayDoctors.getDoctor(doctorId));
            break;
        case 6:
            patientOperations.updateAppointment();
            break;
        case 7:
            return;
    }
    goto Starting;
}
catch (Exception e)
{
    Console.WriteLine(e);
    goto ErrorHandler;
}


    
