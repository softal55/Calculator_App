using static System.Console;

namespace Calculator_App
{
    internal class DivisionMethod
    {
        public static void Division()
        {
            try
            {
                WriteLine("Enter the first number :");
                int firstNum = int.Parse(ReadLine());

                WriteLine("Enter the second number:");
                int secondNum = int.Parse(ReadLine());

                int result = firstNum / secondNum;

                Console.WriteLine("----------------------------------");
                WriteLine($"The output is: {result}");
                Console.WriteLine("---------------------------------- \n");

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

                        Console.WriteLine("----------------------------------");
                        WriteLine($"The output is: {result}");
                        Console.WriteLine("---------------------------------- \n");
                    }
                    if (theEntredNum == 2)
                    {
                        CalculationType.Types();
                        break;
                    }
                    if (theEntredNum == 0 || theEntredNum > 3)
                    {
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("------------------------------------------------------");
                        WriteLine("Please try again. Enter a number between 1 and 3 :");
                        WriteLine("------------------------------------------------------ \n");
                        ResetColor();
                    }
                    WriteLine("---------------------------------- \n");
                    WriteLine("1.New division");
                    WriteLine("2.Change the calculation type");
                    WriteLine("3.close the application");
                    theEntredNum = int.Parse(ReadLine());
                }
            }
            catch(FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                WriteLine("------------------------------------------------------");
                WriteLine("Please try again. The app accept only numbers");
                WriteLine("------------------------------------------------------\n");
                ResetColor();
                Division();
            }
            catch(DivideByZeroException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                WriteLine("------------------------------------------------------");
                WriteLine("Please try again. Can't do divide by 0.");
                WriteLine("------------------------------------------------------\n");
                ResetColor();
                Division();
            }
           
        }
    }
}
