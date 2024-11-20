using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

            // Boolean 
            int x = 10;
            int y = 30; 
            Console.WriteLine(x < y); 
            Console.WriteLine(y < x); 
            Console.WriteLine(x <= y);
            if (x == y) {
                Console.WriteLine("This value equals to the others");
            } else if (x > y) {
                Console.WriteLine("This value x is bigger than y");
            } else if (x < y) {
                Console.WriteLine("This value y is bigger than x");
            }



            Console.ReadKey(); 

        }


    }
    }

