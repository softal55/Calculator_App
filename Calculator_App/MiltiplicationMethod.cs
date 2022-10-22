using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_App
{
    internal class MiltiplicationMethod
    {
        public void Miltiplication()
        {
            try
            {
                Console.WriteLine("Enter the first number :");
                int firstNum = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the second number:");
                int secondNum = int.Parse(Console.ReadLine());

                int result = firstNum * secondNum;
                Console.WriteLine($"The output is: {result}");

                Console.WriteLine("1.Miltiplication with last result");
                Console.WriteLine("2.New Miltiplication calculation");
                Console.WriteLine("3.Change the calculation type");
                Console.WriteLine("4.Exit the application");

                int theEnteredNum = int.Parse(Console.ReadLine());
                while (theEnteredNum != 4)
                {
                    if (theEnteredNum == 1)
                    {
                        Console.WriteLine($"The last result: {result}");

                        Console.WriteLine("Enter the second number: ");
                        int secondNumber = int.Parse(Console.ReadLine());

                        int rslt = result * secondNumber;

                        Console.WriteLine("----------------------------------");
                        Console.WriteLine($"The result is: {rslt}");
                        Console.WriteLine("---------------------------------- \n");
                        CalculationType.Types();
                    }
                    if (theEnteredNum == 2)
                    {
                        Console.WriteLine("Enter the first number :");
                        firstNum = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the second number:");
                        secondNum = int.Parse(Console.ReadLine());

                        result = firstNum * secondNum;

                        Console.WriteLine("----------------------------------");
                        Console.WriteLine($"The output is: {result}");
                        Console.WriteLine("---------------------------------- \n");
                        CalculationType.Types();

                    }
                    if (theEnteredNum == 3)
                    {
                        CalculationType.Types();
                    }
                    if (theEnteredNum == 0 || theEnteredNum > 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("------------------------------------------------------");
                        Console.WriteLine("Please try again. Enter a number between 1 and 4 :");
                        Console.WriteLine("------------------------------------------------------\n");
                        Console.ResetColor();
                    }
                    Console.WriteLine("---------------------------------- \n");
                    Console.WriteLine("1.Miltiplication with last result");
                    Console.WriteLine("2.New Miltiplication calculation");
                    Console.WriteLine("3.Change the calculation type");
                    Console.WriteLine("4.Exit the application");

                    theEnteredNum = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Close the application with any key!");
                Console.ReadKey();
            }
            catch(FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine("------------------------------------------------------");
               Console.WriteLine("Please try again. The app accept only numbers");
               Console.WriteLine("------------------------------------------------------\n");
               Console.ResetColor();
                Miltiplication();
            }
        }
    }
}
