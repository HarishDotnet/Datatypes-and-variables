using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Datatypes_and_variables_and_Access_Specifier
{
    public class practice1
    {
        static void Main(string[] arr){
            byte age;
            short ACE_number;
            int pincode;
            long phn_number;
            float Offcheck_in_time;
            double Offcheck_out_time;
            char initial;
            string name;

            Console.WriteLine("Enter your age:");
            byte.TryParse(Console.ReadLine(),out age);
            Console.WriteLine("Enter your ACE_number:");
            short.TryParse(Console.ReadLine(),out ACE_number);
            Console.WriteLine("Enter your picode:");
            Int32.TryParse(Console.ReadLine(),out pincode);
            Console.WriteLine("Enter your phn_number:");
            Int64.TryParse(Console.ReadLine(),out phn_number);
            Console.WriteLine("Enter your Offcheck_in_time:");
            float.TryParse(Console.ReadLine(),out Offcheck_in_time);
            Console.WriteLine("Enter your Offcheck_out_time:");
            double.TryParse(Console.ReadLine(),out Offcheck_out_time);
            Console.WriteLine("Enter your initial:");
            char.TryParse(Console.ReadLine(),out initial);
            Console.WriteLine("Enter your name:");
            name=Console.ReadLine();

            Console.Write($"Iam name is {initial} {name} and {age} years old, my area pincode is {pincode} and my contact number is {phn_number} .");
            Console.Write($"I am working in Aspire System and my ACE_number is {ACE_number} i will come to office by {Offcheck_in_time}Am and will get back by {Offcheck_out_time}Pm");

            

        }
    }
}