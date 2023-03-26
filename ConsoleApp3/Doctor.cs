using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public abstract class Doctor
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Experience { get; set; }
        public void DisplayInfo()
        {
            Console.WriteLine($"\nВаш доктор \nИмя: {Name}, Возраст: {Age}, Опыт работы: {Experience}");
        }
        public void Cure(Patient patient)
        {
            patient.Cured = "Здоров";
        }
        public abstract int Price(Patient patient, int ageBenefit);
    }
}
