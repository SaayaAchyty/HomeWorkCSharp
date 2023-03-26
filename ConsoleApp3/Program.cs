using ConsoleApp3;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    public const int ageBenefit = 60;
    public static void Main(string[] args)
    {
        Therapeutist therapeutist = new Therapeutist { Name = "Гертруда", Age = 45, Experience = 20 };
        Dentist dentist = new Dentist { Name = "Иннокентий", Age = 50, Experience = 25 };
        Surgeon surgeon = new Surgeon { Name = "Евтуханий", Age = 35, Experience = 10 };
        Patient patient = new Patient();
        TreatmentProcess treatmentProcess = new TreatmentProcess();
        Console.Write("Введите ваше имя: ");
        var name = Console.ReadLine();
        if (string.IsNullOrEmpty(name))
        {
            patient.Name = "Неизвестно";
        }
        else
        {
            patient.Name = name;
        }
        try
        {
            Console.Write("Введите ваш возраст: ");
            patient.Age = ReadInt();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.Write("Введите ваш адрес: ");
        var adress = Console.ReadLine();
        if (string.IsNullOrEmpty(adress))
        {
            patient.Adress = "Неизвестно";
        }
        else
        {
            patient.Adress = adress;
        }
        patient.DisplayInfo();
        try
        {
            Console.WriteLine("\nК какому врачу Вы хотели бы записаться?\n1 - терапевт, 2 - хирург, 3 - стоматолог");
            var chooseDoctor = ReadInt();
            switch (chooseDoctor)
            {
                case 1:
                    treatmentProcess.treatmentProcess(therapeutist, patient, ageBenefit); 
                    break;
                case 2:
                    treatmentProcess.treatmentProcess(surgeon, patient, ageBenefit);
                    break;
                case 3:
                    treatmentProcess.treatmentProcess(dentist, patient, ageBenefit);
                    break;
                default:
                    Console.WriteLine("Такого врача нет.");
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
       
    }

    public static int ReadInt()
    {
        if (Int32.TryParse(Console.ReadLine(), out int value))
        {
            return value;
        }
        else
        {
            throw new Exception(message: "Вы ввели не число.");
        }
    }
}