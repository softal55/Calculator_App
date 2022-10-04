using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_App
{
    internal class AdditionMethod
    {
       
        public static void Addition()
        {
            Console.WriteLine("Enter the first number :");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine("1.Get the result");
            Console.WriteLine("2.Add another number");
            Console.WriteLine("3.Exit the application");
            int theEnteredNum = int.Parse(Console.ReadLine());
            while (theEnteredNum != 3)
            {

                List<int> numbers = new List<int>();
                numbers.Add(firstNum);
                numbers.Add(secondNum);
                if (theEnteredNum == 1)
                {
                    int Output = numbers.Sum();

                    Console.WriteLine("The Output is: {0} ", Output);
                    break;

                }
                if (theEnteredNum == 2)
                {
                    Console.WriteLine("How many number you will add in the addition? ");
                    int totalOfNum = int.Parse(Console.ReadLine());



                    for (int i = 0; i < totalOfNum; i++)
                    {
                        Console.WriteLine($"Enter a number {i + 3}: ");
                        int x = int.Parse(Console.ReadLine());

                        numbers.Add(x);
                    }
                    int Output = numbers.Sum();

                    Console.WriteLine("The Output is: {0} ", Output);
                    break;
                }

            }
            Console.WriteLine("Closing the application with any key!");
            Console.ReadKey();
        }
    }
}
