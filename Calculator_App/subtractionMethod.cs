using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_App
{
    internal class SubtractionMethod
    {
        public static void Subtraction()
        {
            try
            {
                Console.WriteLine("Enter the first number :");
                int firstNum = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number: ");
                int secondNum = int.Parse(Console.ReadLine());

                Console.WriteLine("----------------------------------");
                Console.WriteLine("1.Get the result");
                Console.WriteLine("2.Add another number");
                Console.WriteLine("3.Change the calculation type");
                Console.WriteLine("4.Exit the application");

                int num = int.Parse(Console.ReadLine());
                while (num != 4)
                {
                    if (num == 1)
                    {
                        int sub = firstNum - secondNum;

                        Console.WriteLine("---------------------------------- ");
                        Console.WriteLine("The output is: {0}", sub);
                        Console.WriteLine("---------------------------------- \n");
                        CalculationType.Types();
                        break;
                    }
                    if (num == 2)
                    {
                        Console.WriteLine("How many number you will add in the subtraction? ");
                        int totalOfNum = int.Parse(Console.ReadLine());
                        List<int> numbers = new List<int>();

                        for (int i = 0; i < totalOfNum; i++)
                        {
                            Console.WriteLine($"Enter the number {i + 3}: ");
                            int x = int.Parse(Console.ReadLine());
                            numbers.Add(x);
                        }
                        int sum = numbers.Sum();
                        int output = firstNum - secondNum - sum;

                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("The Output is:{0}", output);
                        Console.WriteLine("---------------------------------- \n");
                        CalculationType.Types();
                        break;
                    }
                    if (num == 3)
                    {
                        CalculationType.Types();
                        break;
                    }
                    while (num == 0 || num > 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("------------------------------------------------------");
                        Console.WriteLine("Please try again. Enter a number between 1 and 4 :");
                        Console.WriteLine("------------------------------------------------------ \n");
                        Console.ResetColor();
                        Console.WriteLine("1.Get the result");
                        Console.WriteLine("2.Add another number");
                        Console.WriteLine("3.Change the calculation type");
                        Console.WriteLine("4.Exit the application");
                        num = int.Parse(Console.ReadLine());
                    }
                }
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Please try again. The app accept only numbers");
                Console.WriteLine("------------------------------------------------------\n");
                Console.ResetColor();
                Subtraction();
            }
        }
    }
}
