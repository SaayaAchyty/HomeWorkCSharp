using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class TreatmentProcess
    {
        public void treatmentProcess(Doctor doctor, Patient patient, int ageBenefit)
        {
            doctor.DisplayInfo();
            doctor.Cure(patient);
            patient.Payment = doctor.Price(patient, ageBenefit);
            patient.DisplayAfterCure(ageBenefit);
        }
        
    }
}
