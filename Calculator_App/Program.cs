namespace Calculator_App
{
    class Program
    {


        public static void Main(string[] args)
        {
           
            Console.WriteLine("\t \t \t Welcome into the Calculator app! \n ");
            
            Console.WriteLine("which type of calculation you want to do? \n");

            int theEnteredNum = CalculationType.Types();

            Console.WriteLine("----------------------------------");
           
            if(theEnteredNum == 1)
            {
                AdditionMethod.Addition();
            }
            if (theEnteredNum == 2)
            {

            }
            if(theEnteredNum == 3)
            {

            }
            if(theEnteredNum == 4)
            {

            }
        }
    }
}