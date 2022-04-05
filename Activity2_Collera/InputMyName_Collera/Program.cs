using System;

namespace InputMyName_Collera
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname, lastname;

            Console.Write("Enter your name:" + //string concatenator
                "(firstname lastname)  ");
            firstname = Console.ReadLine();
            lastname = Console.ReadLine();
            Console.WriteLine("\nHello! " + firstname
                + " " + lastname + "!!!"
                + "\nWelcome to OOP Environment.");
            Console.ReadKey();
        }
    }
}
