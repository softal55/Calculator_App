using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_App
{
    internal class CalculationType
    {
        public static void Types()
        {
            try
            {
                Console.WriteLine("which type of calculation you want to do? \n");
                Console.WriteLine("1.Addition \n");
                Console.WriteLine("2.Subtraction \n");
                Console.WriteLine("3.Miltiplication \n");
                Console.WriteLine("4.Division \n");
                Console.WriteLine("5.Exit the application \n");
                Console.WriteLine("Enter a number according to the order of types:");
                int theEnteredNum = int.Parse(Console.ReadLine());
                Console.WriteLine("------------------------------------------------------\n");

                if (theEnteredNum != 0 || theEnteredNum < 5)
                {
                    if (theEnteredNum == 1)
                    {
                        AdditionMethod.Addition();
                    }
                    if (theEnteredNum == 2)
                    {
                        SubtractionMethod.Subtraction();
                    }
                    if (theEnteredNum == 3)
                    {
                        MiltiplicationMethod miltiplicationMethod = new MiltiplicationMethod();
                        miltiplicationMethod.Miltiplication();
                    }
                    if (theEnteredNum == 4)
                    {
                        DivisionMethod.Division();
                    }
                    if (theEnteredNum == 5)
                    {
                        Console.WriteLine("Close the application with any key!");
                        Console.ReadKey();
                    }
                }
                while (theEnteredNum == 0 || theEnteredNum > 5)
                {
                    Console.WriteLine("------------------------------------------------------\n");
                    Console.WriteLine("Please try again. Enter a number between 1 and 5 :");
                    theEnteredNum = int.Parse(Console.ReadLine());

                    if (theEnteredNum == 1)
                    {
                        AdditionMethod.Addition();
                    }
                    if (theEnteredNum == 2)
                    {
                        SubtractionMethod.Subtraction();
                    }
                    if (theEnteredNum == 3)
                    {
                        MiltiplicationMethod miltiplicationMethod = new MiltiplicationMethod();
                        miltiplicationMethod.Miltiplication();
                    }
                    if (theEnteredNum == 4)
                    {
                        DivisionMethod.Division();
                    }
                    if (theEnteredNum == 5)
                    {
                        Console.WriteLine("Close the application with any key!");
                        Console.ReadKey();
                    }
                }

            }
            catch(FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Please try again. Enter a number between 1 and 5 :");
                Console.WriteLine("------------------------------------------------------\n");
                Console.ResetColor();
                Types();
            }
        }
    }
}
