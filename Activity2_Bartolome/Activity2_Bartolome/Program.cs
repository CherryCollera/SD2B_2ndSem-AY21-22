/*20-01913
Byen Bartolome
SD2B
April 6, 2022
This program will compute the sum*/

using System;

namespace ComputeTheSum
{
    class ComputetheSum
    {
        static void Main()
        {
            int num1, num2;

            Console.WriteLine("Please enter the numbers you want to be summed.");
            Console.Write("Enter the first number:  ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number:  ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sum = {0} ", num1 + num2);
            Console.ReadLine();
        }
    }
}
Byen
Byen Angeles Bartolome
/*20-01913
Byen Bartolome
SD2B
April 6, 2022
This program will do basic operations*/

using System;

namespace BasicOperations
{
    class Basicoperations
    {
        static void Main()
        {
            int num1, num2;

            Console.WriteLine("Please Enter 2 numbers. ");
            Console.Write("Enter first number:  ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number:  ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nThe Sum is = {0} ", num1 + num2);
            Console.Write("\nThe Difference is = {0} ", num1 - num2);
            Console.Write("\nThe Product is = {0} ", num1 * num2);
            Console.Write("\nThe Quotient is = {0} ", num1 / num2);
            Console.Write("\nThe Remainder is = {0} ", num1 % num2);
            System.Console.ReadKey();

        }
    }
}
Byen
Byen Angeles Bartolome
/*20-01913
Byen Bartolome
SD2B
April 6, 2022
This program will compute average*/

using System;

namespace ComputeAverage
{
    class Average
    {
        static void Main()
        {
            double num1, num2, num3, num4, num5;
            double num6 = 5;
            Console.WriteLine("Enter your grades(5): ");
            Console.Write("");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("");
            num3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("");
            num4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("");
            num5 = Convert.ToDouble(Console.ReadLine());

            double avg = num1 + num2 + num3 + num4 + num5;
            double avg2 = avg / num6;
            Console.Write("Your Average is = {0}", avg2);
            Console.ReadLine();

        }

    }
}
Byen
Byen Angeles Bartolome
/*20-01913
Byen Bartolome
SD2B
April 6, 2022
This program will declare constants*/

using System;

namespace DeclaringConstants
{
    class Declaringconstants
    {
        static void Main()
        {
            double num1, AreaCircle;
            Console.Write("Please input the radius: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            const double pi = 3.14159;
            AreaCircle = pi * num1 * num1;
            Console.Write("Radius: {0}", num1);
            Console.Write("\nArea: {0}", AreaCircle);
            Console.ReadLine();
        }
    }
}
Byen
Byen Angeles BArtolome
using System;

namespace IfElse
{
    class Ifelse
    {
        static void Main()
        {
            int num1, num2;
            Console.Write("Enter the 1st number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 2nd Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine(num1 + " is greater than {0}.", num2);
            }

            else if (num1 < num2)
            {
                Console.WriteLine(num2 + " is greater than {0}.", num1);
            }

            else if (num1 == num2)
                Console.WriteLine(num1 + " is equal to {0}.", num2);

            Console.ReadKey();
        }
    }
}
Byen
Byen Angeles Bartolome
/*20-01913
Byen Bartolome
SD2B
April 6, 2022
This program will execute IfElse2*/

using System;

namespace IfElse2
{
    class IfElse2
    {
        static void Main()
        {
            int num1, num2, num3;
            Console.Write("Enter 1st number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter 2nd number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter 3rd number: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine(num1 + " is greater than " + num2 + " and " + num3);
                Console.ReadLine();
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine(num2 + " is greater than " + num1 + " and " + num3);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(num3 + " is greater than " + num1 + " and " + num2);
                Console.ReadLine();
            }
        }
    }
}