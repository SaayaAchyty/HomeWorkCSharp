using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Therapeutist: Doctor
    {
        public const int price = 2000;
        public const int benefit = 500;

        public override int Price(Patient patient, int ageBenefit)
        {
            if (patient.Age<ageBenefit)
            {
                return price;
            }
            else
            {
                return price - benefit;
            }
        }
    }
}
