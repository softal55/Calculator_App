using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_App
{
    internal class CalculationType
    {
        public static int Types()
        {
            
            Console.WriteLine("1.Addition \n");
            Console.WriteLine("2.Subtraction \n");
            Console.WriteLine("3.Miltiplication \n");
            Console.WriteLine("4.Division \n");
            Console.WriteLine("Enter a number according to the order of types: ");
             int num = int.Parse(Console.ReadLine());
            return num;
        }
    }
}
