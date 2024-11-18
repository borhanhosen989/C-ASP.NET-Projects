using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Sentura
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Max number of two integer values
            int numberOfMotor = 20; 
            int numberOfMotor2 = 30;
            Console.WriteLine($"Max Number : {Math.Max(numberOfMotor, numberOfMotor2)}");  


            // Min Number of two integer Values 
            Console.WriteLine($"Minimum Number : {Math.Min(numberOfMotor, numberOfMotor2)}"); 

            // Square root of integer number 
            Console.WriteLine($"Square Root Of Number : {Math.Sqrt(numberOfMotor)}");

            // Return Absolute Positive number 
            Console.WriteLine($"Absolute Positive Value : {Math.Abs(-564)}"); 

            // Round Number 
            Console.WriteLine($"Round Number : {Math.Round(9.9958)}");
         






        }


    }
    }

