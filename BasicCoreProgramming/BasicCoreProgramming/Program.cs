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
            Console.WriteLine("***** Welcome to  Basic of C# Core Programming *****");
            Console.WriteLine("\n");
            // Creating Oject of FlipCoin Class
            FlipCoin objflipcoin = new FlipCoin();

            // Calling The Method or Funtion
            objflipcoin.CheckFlipCoin();

            //To Hold The Output Terminal 
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
