using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Sentura
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Variable and datatype -> int -stores integers(whole numbers), without decimals, such as 123 or - 123 
            int whiteBall = 20;
            int blackBall = 15; 
            int totalBall = whiteBall + blackBall; 
            Console.WriteLine($"Total Ball = {totalBall}");


            // double -stores floating point numbers, with decimals, such as 19.99 or - 19.99 
            double salaryOfEmployee = 23503.345;
            double expenseOfEmployee = 15030.475; 
            double balanceOfSavings = salaryOfEmployee - expenseOfEmployee;
            Console.WriteLine($"Savings of Balance = {balanceOfSavings}");


            //char -stores single characters, such as 'a' or 'B'.Char values are surrounded by single quotes 
            char bloodGroup = 'A'; 
            Console.WriteLine($"My cousin's blood group is : {bloodGroup}");


            // string -stores text, such as "Hello World".String values are surrounded by double quotes 
            string officeLocation = "Bashundara Commercial Area";
            Console.WriteLine($"Our office location  : {officeLocation}"); 


        }
    }
}
