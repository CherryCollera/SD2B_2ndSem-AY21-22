/*20-0332
Regee D. Casaña
SD2B
March 22, 2022
This Program will display the name that I inputted*/


using System;

namespace Sample3_InputMyName
{
    class Regeecasaña
    {
        static void Main(string[] args)
        {
            String firstname, lastname;
            Console.Write("Enter your Name:" +
                "(Firstname Lastname) ");
            firstname = Console.ReadLine();
            lastname = Console.ReadLine();

            //Display your name
            Console.WriteLine("\nHello " + firstname
                + " " + lastname + "!!!"
                + "\nWelcome to OOP Environment.");
            Console.ReadKey();
        }
    }
}