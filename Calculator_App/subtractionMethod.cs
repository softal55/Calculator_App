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
                    Console.WriteLine("The output is: {0}", sub);
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
                    Console.WriteLine("The Output is:{0}", output);
                    break;
                }
                if (num == 3)
                {
                    int EnteredNum = CalculationType.Types();

                    Console.WriteLine("----------------------------------");

                    if (EnteredNum == 1)
                    {
                        AdditionMethod.Addition();
                    }
                    if (EnteredNum == 2)
                    {
                        SubtractionMethod.Subtraction();
                    }
                    if (EnteredNum == 3)
                    {
                        MiltiplicationMethod miltiplicationMethod = new MiltiplicationMethod();
                        miltiplicationMethod.Miltiplication();
                    }
                    if (EnteredNum == 4)
                    {
                        DivisionMethod.Division();
                    }
                    break;
                }

            }
            Console.WriteLine("Close the application with any key!");
            Console.ReadKey();
        }
    }
}
