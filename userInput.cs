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


            // User Name, Address, Phone Number, E-mail, Location 

            Console.Write("Enter User Name : "); 
            string userName = Console.ReadLine();  

            Console.Write("Enter User Address : ");
            string userAddress = Console.ReadLine();

            Console.Write("Enter User Phone Number : "); 
            string userPhoneNumber = Console.ReadLine();

            Console.Write("Enter User E-mail : "); 
            string userEmail = Console.ReadLine();

            Console.Write("Enter User Current Location : "); 
            string userLocation = Console.ReadLine(); 

            Console.WriteLine($"User Name Is : {userName}");
            Console.WriteLine($"User Address Is : {userAddress}");
            Console.WriteLine($"User Phone Number Is : {userPhoneNumber}");
            Console.WriteLine($"User E-mail Is : {userEmail}");
            Console.WriteLine($"User Cureent Location Is : {userLocation}");





        }


    }
    }

