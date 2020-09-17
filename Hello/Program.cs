using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Anthony Garrard
 * Hello World Program
 * 2.3
 * 09/16/2020
 */

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type in your name : "); //user input prompt
            string name = Console.ReadLine(); //reading user input and assigning it to 'name' varible
            
            string myFirstVarible; //Declaration statement
            myFirstVarible = "Welcome"; //Assignment statement

            //string var2 = "something else"; //declaration and assignment statement    

            Console.WriteLine(myFirstVarible + " " + name);  //print statement

            Console.WriteLine("Enter your Birthday : "); //BDay prompt
            string bDay = Console.ReadLine(); //Collecting BDay

            Console.WriteLine("Enter your phone number : "); //Phone Prompt
            string phone = Console.ReadLine(); //Collecting phone

            Console.WriteLine("Enter your address : "); //Address Prompt
            string address = Console.ReadLine(); //Collecting Address

            Console.WriteLine("Enter your SSN : "); //SSN Prompt
            string SSN = Console.ReadLine(); //SSN Grab

            Console.WriteLine("Birthday : " + bDay); //Reading back information
            Console.WriteLine("Phone Number : " + phone);
            Console.WriteLine("Address : " + address);
            Console.WriteLine("SSN : " + SSN);

            Console.WriteLine("Is this correct?   "); //Confirmation prompt
            string confirm = Console.ReadLine(); // confrimation collection

            Console.WriteLine("Confirmation : " + confirm); //confirm readback


            Console.WriteLine("Press any key to exit.");  //print statement
            Console.ReadKey();  //reading for key press
        }
    }
}
