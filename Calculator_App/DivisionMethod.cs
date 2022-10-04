using static System.Console;

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

            WriteLine("1.New Division");
            WriteLine("2.Change the calculation type");
            WriteLine("3.close the application");
            int theEntredNum = int.Parse(ReadLine());

            while (theEntredNum != 3)
            {
                if (theEntredNum == 1)
                {
                    WriteLine("Enter the first number :");
                    firstNum = int.Parse(ReadLine());

                    WriteLine("Enter the second number:");
                    secondNum = int.Parse(ReadLine());

                    result = firstNum / secondNum;
                    WriteLine($"The output is: {result}");
                }
                if (theEntredNum == 2)
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

                WriteLine("1.New division");
               WriteLine("2.Change the calculation type");
                WriteLine("3.close the application");
                theEntredNum = int.Parse(ReadLine());
            }
            WriteLine("Close the application with any key!");
            ReadKey();
        }
    }
}
