using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to  Basic of C# Core Programming ");
            Console.WriteLine("***** Welcome to  Basic of C# Core Programming *****");
            Console.WriteLine("\n");
            Console.WriteLine("Enter The Choice of Question");
            Console.WriteLine("Q1. FlipCoin & to print Percentege of Heads & Tails");
            Console.WriteLine("Q2. To print Leap Year or Not a Leap Year");
            Console.WriteLine("Q3. power of 2 upto power 31");
            Console.WriteLine("Q4.To Print The Harmonic Number of Nth Value");
            Console.WriteLine("Q5. To Print The Prime Factorization of Number N");
            Console.WriteLine("Q6 To Compute Quotient and Remainder");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    // Creating Oject of FlipCoin Class
                    FlipCoin objflipcoin = new FlipCoin();


                    // Calling The Method or Funtion
                    objflipcoin.CheckFlipCoin();
                    break;
                case 2:
                    LeapYear objleapyear = new LeapYear();
                    objleapyear.CheckLeapYear();
                    break;
                case 3:
                    PowerOf2 objpowerof2 = new PowerOf2();
                    objpowerof2.TableOfPower2();
                    break;
                case 4:
                    HarmonicNum objharmonic = new HarmonicNum();
                    objharmonic.harmonicVal();
                    break;
                case 5:
                    Factors objfactors = new Factors();
                    objfactors.PrimeFactorization();
                    break;
                case 6:
                    QuotientRemainder objqutnRemdr = new QuotientRemainder();
                    objqutnRemdr.ComputQutnRemdr();
                    break;
            }

            //To Hold The Output Terminal 
            Console.ReadKey();
        }
    }
}
