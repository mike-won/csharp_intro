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

    /*

    class SwitchStatements
        // Just a special "if" statement that runs a bunch of conditions
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetDay(0));

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
*/
    /*
        class WhileLoop
        {
            /* static void Main(string[] args)
            {
                int index = 1;
                while (index <= 5)
                // Will loop until "while" condition is no longer true
                {
                    Console.WriteLine(index);
                    index++;
                }
                Console.ReadLine();
            }

            static void Main(string[] args)
            {
                int index = 6;
                do
                // A "do while" loop will execute loop code before checking condition
                {
                    Console.WriteLine(index);
                    index++;
                } while (index <= 5);
                Console.ReadLine();
            }
        }

    */
    /*
        class GuessingGame
            // Issue: seems like rightchar doesn't progress past first matching else if arg
        {
            static void Main(string[] args)
            {
                string secretWord = "sheesh";
                string guess = "";
                int guessCount = 0;
                int guessLimit = 4;
                bool outOfGuesses = false;

                while (guess != secretWord && !outOfGuesses)
                {
                    int guessRemaining = guessLimit - guessCount;
                    int rightchar = 0;
                    if (guessCount < guessLimit)
                    {

                        Console.Write("You have " + Convert.ToString(guessRemaining) + " guesses remaining. Enter guess: ");
                        guess = Console.ReadLine();
                        guessCount++;
                    }
                    else
                    {
                        outOfGuesses = true;
                    }
                    if (guess == secretWord)
                    {
                        Console.Write("You win!");
                    }
                    else if (guess[0] == secretWord[0])
                    {
                        rightchar++;
                    }
                    else if (guess[1] == secretWord[1])
                    {
                        rightchar++;
                    }
                    else if (guess[2] == secretWord[2])
                    {
                        rightchar++;
                    }
                    else if (guess[3] == secretWord[3])
                    {
                        rightchar++;
                    }
                    else if (guess[4] == secretWord[4])
                    {
                        rightchar++;
                    }
                    else if (guess[5] == secretWord[5])
                    {
                        rightchar++;
                    }
                    else if (guess[6] == secretWord[6])
                    {
                        rightchar++;
                    }
                    Console.WriteLine("Likeness = " + Convert.ToString(rightchar));
                    if (outOfGuesses)
                    {
                        Console.Write("Out of guesses...you lose!");
                    }
                }
                Console.ReadLine();
            }

            }

*/
    /*
        class ForLoops
        {
            static void Main(string[] args)
            // Keeps track of iterating variable during a loop
            {

                // For loop consists of "initialization," "condition," and
                // the code executed each loop iteration
                // More compact technique
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine(i);
                }
                Console.ReadLine();
            }
        }

        class ForLoopExample
        {
            static void Main(string[] args)
            {
                int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
                for (int i = 0; i <= luckyNumbers.Length; i++)
                {
                    Console.WriteLine(luckyNumbers[i]);
                }
                Console.ReadLine();
            }
        }

    */

    /*
    class ExponentFunction
    // Pass in base and power number, yields results
    // Will only work for positive number powers...
    {
        static void Main(string[] args)
        {
            Console.WriteLine(getPow(3, 2));

            Console.ReadLine();
        }

        static int getPow(int baseNum, int powNum)
        {
            int result = 1;

            for (int i = 0; i < powNum;i++)
            {
                result = result * baseNum;
            }

            return result;
        }
    }
    */

    /*
    class arrays
    {
        static void Main(string[] args)
        {
            //The comma inside the square brackets indicates a 2D array
            //2D array means array inception
            int[,] numberGrid = {
                {1, 2}, // Array position [0]
                {3, 4}, // Array position [1]
                {5, 6}
            };

            //the "2,3" says there are two elements with three sub-elements
            //^^ AKA number of rows and columns
            int[,] myArray = new int[2, 3];

            Console.WriteLine(numberGrid[0, 0]);
            Console.ReadLine();
        }
    }
    */

    /*
    class ExceptionHandling
    {
        // In this situation, num2 = 0 would result in an exception
        // Exception Handling effectively "catches" exceptions, preventing it from terminating
        // This tool makes programs more durable
        static void Main(string[] args)
        {
        // Sus code goes in "try" block
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            //If any exception, will execute code in "catch"
            // "e" below is the variable the Exception is stored as
            // Can also specify types of exceptions

            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException f)
            {
                Console.WriteLine(f.Message);
            }

            // Code under "finally" block will get executed no matter what
            finally
            {

            }

            Console.ReadLine();
        }
    }
    */

    /*
    class classes
    {
        // Use classes to model real-world entities
        // Linked to "Book.cs"
        static void Main(string[] args)
        {
            // Object is an instance of a class (i.e. a physical book from the "Book" class
            //book1 is a Book "object"
            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "J. K. Rowling";
            book1.pages = 400;

            Book book2 = new Book();
            book1.title = "Lord of the Rings";
            book1.author = "JRR Tolkien";
            book1.pages = 700;

            Console.WriteLine(book1.title);
            Console.ReadLine();

        }
    }

    */

    /*
    class Constructor
    {
        // Method called whenever a class object is created
        // Linked to created class "Book" in "Book.cs"
        static void Main(string[] args)
        {
            // The arg "new Book()" calls the Book constructor
            Book book1 = new Book("Harry Potter","JK Rowling", 400);
            Book book2 = new Book("LOTR","JRR Tolkien",700);

            Console.WriteLine(book2.title);
            Console.ReadLine();

        }
    }
    */

    /*
    class ObjectMethods
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Jim", "Business", 2.8);
            Student student2 = new Student("Pam", "Art", 3.6);

            Console.WriteLine(student1.honorRoll());
            Console.WriteLine(student2.honorRoll());
            Console.ReadLine();

        }
    }

    */


    /*
    class GettersAndSetters
    {
        //Use Getters and Setters to restrict attribute values
        static void Main(string[] args)
        {
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");

            avengers.Rating = "dog";

            Console.WriteLine(avengers.Rating);
            Console.ReadLine();

        }
    }
    */

    /*
    class StaticClassAttributes
    {
        // Static classes are shared in all objects and instances of a given class
        // Static attribute isn't unique to each object/instances in a class
        // Seems like using static attributes are used to call/modify
        // overall class or shared data
        static void Main(string[] args)
        {
            Song holiday = new Song("Holiday", "Green Day", 200);

            Console.WriteLine(Song.songCount);

            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);

            // #gettermethod
            Console.WriteLine(kashmir.GetSongCount());

            Console.ReadLine();

        }
    }

    */

    /*
    class StaticMethods
    {
        // Usually static methods don't necessitate object creation to use the method
        static void Main(string[] args)
        {
            // Example of static method below
            UsefulTools.SayHi("Mike");

            Console.ReadLine();

        }
    }
    */

    class Inheritance
    {
        // Where a subclass inherits all the functionality from a parent class (superclass)
        static void Main(string[] args)
        {
            chef chef = new chef();
            chef.MakeChicken();

            // Don't lose your mind, the call in the second arg must reference an object
            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeChicken();

            Console.ReadLine();

        }
    }

}