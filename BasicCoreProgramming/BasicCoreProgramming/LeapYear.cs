using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class LeapYear
    {
        public void CheckLeapYear()
        {
            //Taking Output From User
            Console.Write("Enter The 4 Digit Number Of Year : ");
            //Store  The Value Enter By User in Year Variable
            int Year = Convert.ToInt32(Console.ReadLine());

            if (Year > 999 && Year < 9999)
            {
                if (Year % 400 == 0 && Year % 100 == 0 || Year % 4 == 0)
                {
                    Console.WriteLine("The Number Of Year You Enter is a Leap Year");
                }
                else
                {
                    Console.WriteLine("The Number of Year You Enter is Not a Leap Year");
                }
            }
            else
            {
                Console.WriteLine("Please Enter Valid Input");
            }

        }
    }
}
