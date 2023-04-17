using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home6
{
    internal class Clinic
    {
        internal Patient GetAnamnesis()
        {
            Patient patient = new Patient();
            patient.Name = SayYourName();
            patient.Ilnes = SayYourIlnes();
            return patient;
        }

        private string SayYourName()
        {
            Console.WriteLine("Please say your name:");
            string name = Console.ReadLine();
            return name;
        }

        private IlnessType SayYourIlnes()
        {
            Console.WriteLine("Please say your ilnes:");
            string patientIlnes = Console.ReadLine();

            if (patientIlnes == "Eyes" || patientIlnes == "eyes")
            {
                return IlnessType.Eyes;
            }
            else if (patientIlnes == "Teeth" || patientIlnes == "teeth")
            {
                return IlnessType.Teeth;
            }
            else
            {
                return IlnessType.Other;
            }
        }

        internal void PrescribeTreatment(Patient patient)
        {
            if (patient.Ilnes  == IlnessType.Eyes)
            {
                Console.WriteLine($"{patient.Name}, you have been assigned an ophthalmologist.");
            }
            else if (patient.Ilnes == IlnessType.Teeth)
            {
                Console.WriteLine($"{patient.Name}, you have been assigned a dentist.");
            }
            else
            {
                Console.WriteLine($"{patient.Name}, you have been assigned a therapist.");
            }
            Console.WriteLine();
        }
    }
}