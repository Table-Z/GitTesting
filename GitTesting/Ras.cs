using System;
using System.Collections.Generic;
using System.Text;

namespace GitTesting
{
    public class Ras
    {
        public Ras(int age_baby_boiii)
        {
            Age_baby_boiii = age_baby_boiii;
        }

        public int Age_baby_boiii { get => field; set { if (value < 18) throw new Exception("need to be 18"); field = value; } }


        public bool Drive()
        {
            Random random = new Random();
            
            if (random.Next(0, 1) == 1)
            {
                return true;
            }

            return false;
        }

        public void tester()
        {
            Console.WriteLine("you cant see me on god frfr");
        }

    }
}
