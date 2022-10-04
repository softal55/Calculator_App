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

                    Console.WriteLine("---------------------------------- \n");
                    Console.WriteLine($"The result is: {rslt}");
                    break;
                }
                if(theEnteredNum == 2)
                {
                    Console.WriteLine("Enter the first number :");
                    firstNum = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the second number:");
                     secondNum = int.Parse(Console.ReadLine());

                     result = firstNum * secondNum;

                    Console.WriteLine("---------------------------------- \n");
                    Console.WriteLine($"The output is: {result}");

                  
                }
                if(theEnteredNum == 3)
                {
                    int  EnteredNum = CalculationType.Types();

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
    }
}
