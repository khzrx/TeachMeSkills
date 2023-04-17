using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home6
{
    internal class Doctor
    {
        string Name { get; set; }
        string Specialization { get; set; }

        internal Doctor()
        {

        }
        internal Doctor(string name, string specialization)
        {
            Name = name;
            Specialization = specialization;
        }

        internal void Treat(Patient patient)
        {
            Doctor doctor = new Doctor();
            if (patient.Ilnes == IlnessType.Eyes)
            {
                doctor.Name = "Ivanov";
                doctor.Specialization = "ophthalmologist";
            }
            else if (patient.Ilnes == IlnessType.Teeth)
            {
                doctor.Name = "Petrov";
                doctor.Specialization = "dentist";
            }
            else
            {
                doctor.Name = "Sidorov";
                doctor.Specialization = "therapist";
            }

            Console.WriteLine($"You were cured by {doctor.Specialization} Dr.{doctor.Name}.");
        }
    }
}