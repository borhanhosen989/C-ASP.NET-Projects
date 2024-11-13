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

            // int     4 bytes Stores whole numbers from - 2,147,483,648 to 2,147,483,647 
            int myCgpa = 4;
            int myId = 22482602;
            Console.WriteLine($"My student id : {myId} and cgpa : {myCgpa}");



            // long    8 bytes Stores whole numbers from - 9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 
            long serialNumber = 8583468348647483746; 
            Console.WriteLine($"Varsity serial number : {serialNumber}");


            // float   4 bytes Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits 
            float siKneeVoltage = 0.734F; 
            Console.WriteLine($"Silicon diode knee voltage : {siKneeVoltage}");


            // double  8 bytes     Stores fractional numbers.Sufficient for storing 15 decimal digits 
            double afterHomeWork = 56.48674834D; 
            Console.WriteLine($"In mid night i watch movie after home work : {afterHomeWork}");


            // bool    1 bit   Stores true or false values 
            bool isSick = true; 
            Console.WriteLine($"Are you sick {isSick}");


            // char    2 bytes     Stores a single character / letter, surrounded by single quotes 
            char gradeOfMath = 'B';
            char gradeOfMath2 = 'C';
            Console.WriteLine($"What is your math grade {gradeOfMath} or {gradeOfMath2}");

            // string  2 bytes per character   Stores a sequence of characters, surrounded by double quotes 
            string universityName = "American Internation University-Bangladesh"; 
            Console.WriteLine($"Bangladesh most beautiful university : {universityName}");


        }
    }
}
