﻿using static System.Console;

namespace Calculator_App
{
    internal class DivisionMethod
    {
        public static void Division()
        {
            WriteLine("Enter the first number :");
            int firstNum = int.Parse(ReadLine());

           WriteLine("Enter the second number:");
            int secondNum = int.Parse(ReadLine());
            
            int result = firstNum / secondNum;
            WriteLine($"The output is: {result}");

            WriteLine("1.New division calculation");
            WriteLine("2.close the application");
            int theEntredNum = int.Parse(ReadLine());
            while (theEntredNum != 2)
            {
                if (theEntredNum == 1)
                {
                    WriteLine("Enter the first number :");
                    firstNum = int.Parse(ReadLine());

                    WriteLine("Enter the second number:");
                     secondNum = int.Parse(ReadLine());

                    result = firstNum / secondNum;
                    WriteLine($"The output is: {result}");
                    break;
                }
            }
            WriteLine("Close the application with any key!");
            ReadKey();
        }
    }
}