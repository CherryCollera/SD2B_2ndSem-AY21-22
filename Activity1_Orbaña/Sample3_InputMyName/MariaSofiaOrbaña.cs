using System;

namespace Sample3_InputMyName
{
    class MariaSofiaOrbaña
    {
        static void Main(string[] args)
        {
            string firstname, lastname;

            Console.Write("Enter your name: " + "(firstname lastname) ");
            firstname = Console.ReadLine();
            lastname = Console.ReadLine();
            Console.WriteLine("\nHello! " + firstname 
                 + lastname + "!!!" 
                + "\nWelcome to OOP Environment.");
            Console.ReadKey();

        }
    }
}

