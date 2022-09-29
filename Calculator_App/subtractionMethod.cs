using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_App
{
    internal class SubtractionMethod
    {
        public static void Subtraction()
        {
            Console.WriteLine("How much number you will add in the subtraction? ");
            int totalOfNum = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();

            for (int i = 0; i < totalOfNum; i++)
            {
                Console.WriteLine("Enter a number: ");
                int x = int.Parse(Console.ReadLine());

                numbers.Add(x);
            }

            /* the numbers that user enter are in the list, 
             * in the AdditionMethod.cs i used method who exist in System.Collections.Generic 
             * the "sum" method.
             * So here i don't know what i use to get the result ?
             * and i'm looking to do the same consist for all the calculate method (the same stracture )
             */



        }
    }
}
