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

            // String character access by index number 
            string hello = "Hello World";
            Console.WriteLine(hello[2]);

            // Identify index number 
            Console.WriteLine(hello.IndexOf('e'));

            // Substring 
            string firstname = "Amir Ahmed";
            string lastname = "Khasru";

            int openSpace = firstname.IndexOf('h');  

            string name = firstname.Substring(openSpace); 
            Console.WriteLine(name);

            // Special Character 
            Console.WriteLine("My name is \"Amir Ahmed\"");

            // Tabe in string 
            Console.WriteLine("My address is\tHasnabad Dhaka"); 

            // New line on string 
            Console.WriteLine("Hello \nWorld");



            Console.ReadKey(); 

        }


    }
    }

