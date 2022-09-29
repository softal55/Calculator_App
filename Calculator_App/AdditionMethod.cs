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
          
            Console.WriteLine("How much number you will add in the addition? ");
            int totalOfNum = int.Parse(Console.ReadLine());

           List<int> numbers = new List<int>();

            for (int i = 0; i < totalOfNum; i++)
            {
                Console.WriteLine("Enter a number: ");
                int x = int.Parse(Console.ReadLine());

                numbers.Add(x);
            }

            int Output = numbers.Sum();

            Console.WriteLine("The Output is: ", Output);

        }
    }
}
