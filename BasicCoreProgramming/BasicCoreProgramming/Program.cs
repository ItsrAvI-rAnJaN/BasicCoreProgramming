﻿using System;
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
            Console.WriteLine("Enter The Choice of Question");
            Console.WriteLine("Q1. FlipCoin & to print Percentege of Heads & Tails");
            Console.WriteLine("Q2. To print Leap Year or Not a Leap Year");
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
             }

            //To Hold The Output Terminal 
            Console.ReadKey();


        }
           

            
        
    }
}
