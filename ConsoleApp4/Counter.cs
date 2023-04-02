using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Counter
    {
        public delegate void Handler();
        public event Handler? Notify;
        public void counter() 
        {
            for (int i = 0; i < 101; i++)
            {
                Console.WriteLine(i);
                if (i==77)
                {
                    Notify?.Invoke();
                }
            }
        }
    }
}
