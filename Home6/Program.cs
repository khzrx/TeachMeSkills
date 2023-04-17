using System;

namespace Home6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clinic clinic = new Clinic();
            Patient patient = clinic.GetAnamnesis();
            Doctor doctor = new Doctor();
            clinic.PrescribeTreatment(patient);
            doctor.Treat(patient);
        }
    }
}