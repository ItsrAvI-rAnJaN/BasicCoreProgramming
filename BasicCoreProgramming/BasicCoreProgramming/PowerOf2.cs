using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class PowerOf2
    {
        public void TableOfPower2()
        {   // Taking Input of N Power From User
            Console.WriteLine("Enter the limit N(should be greater than 0 & less than 31 ) ");
            int N = Convert.ToInt32(Console.ReadLine()); // Store The Value input From User
            int power = 1;
            Console.WriteLine("Table of Two");
            // Defining Logic
            for (int i = 0; i <= N; i++)
            {
                if (i == 0)
                {
                    power = 1;

                }
                else
                {
                    power = power * 2;

                }
                //Printin Output
                Console.WriteLine("2^{0} = {1}", i, power);
            }

        }
    }
}
