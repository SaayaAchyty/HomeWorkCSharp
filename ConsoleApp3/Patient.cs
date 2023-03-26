using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Patient
    {
        public string Name { get; set; }
        public int Age { get; set; } 
        public string Adress { get; set; }
        public string Cured { get; set; } = "Болеет";
        public int Payment { get; set; } = 0;
        public void DisplayInfo()
        {
            if (Age != 0)
            {
               Console.WriteLine($"\nВы ввели данные \nИмя: {Name}, Возраст: {Age}, Адрес: {Adress}, Ваш статус: {Cured}");
            }
            else
            {
                Console.WriteLine($"\nВы ввели данные \nИмя: {Name}, Возраст: неизвестно, Адрес: {Adress}, Ваш статус: {Cured}");
            }
        }
        public void DisplayAfterCure (int ageBenefit)
        {
            if (Age < ageBenefit)
            {
                Console.WriteLine($"\nСпасибо за посещение нашей больницы\nВаш статус изменился на: {Cured}\nС вас оплата {Payment} руб.");
            }
            else
            {
                Console.WriteLine($"\nСпасибо за посещение нашей больницы\nВаш статус изменился на: {Cured}\nВы попали в категорию льготников!\nС вас оплата {Payment} руб.");
            }
        }

    }
}
