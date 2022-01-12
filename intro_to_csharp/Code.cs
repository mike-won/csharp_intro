using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro_to_csharp
{
    /* class BasicCalc
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to the calc! Please enter a number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an operator: ");
            string op = Console.ReadLine();

            Console.Write("Please enter a second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }

            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }

            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }

            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }

            else
            {
                Console.WriteLine("Invalid Response, please enter one of the following: '+' '-' '*' '/' - ");
            }    

            Console.ReadLine();
        }
    } */

    class SwitchStatements
        // Just a special "if" statement that runs a bunch of conditions
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetDay(8));

            Console.ReadLine();
        }

        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
                //Switch statement needs a condition value
            {
                case 0:
                    dayName = "Sunday";
                    break; //"break" will stop checking conditions
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                case 7:
                    dayName = "Sunday";
                    break;

                //Use "default" as an "else"
                default:
                    dayName = "Invalid Day Number";
                    break;
            }

            return dayName;
        }
    }
}
