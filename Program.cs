namespace CalculatorAssignment_Lexicon
{
    internal class Program
    {

        static void printMenu()
        {
            Console.Clear();
            Console.WriteLine("Make a selection.");
            Console.WriteLine("1. Calculator.");
        }

        static void checkMenuSelection(string menuInput)
        {
            switch (menuInput)
            {
                case "1":
                    calculator();
                    break;
            }
        }

        static void calculator()
        {
            Console.WriteLine("Enter your first number. Only whole numbers are valid.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your operator. (+, -, *, /, %.");
            string op = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter your second number. Only whole numbers are valid.");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result;

            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine(result);
                    Console.ReadLine();
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine(result);
                    Console.ReadLine();
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine(result);
                    Console.ReadLine();
                    break;
                case "/":
                    result = num1 / num2;
                    Console.WriteLine(result);
                    Console.ReadLine();
                    break;
                case "%":
                    result = num1 % num2;
                    Console.WriteLine(result);
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Invalid.");
                    break;
            }
        }

        static void Main(string[] args)
        {
            bool loop = true;
            string menuInput;
            while (loop)
            {
                printMenu();
                checkMenuSelection(Console.ReadLine());

            }

            
        }
    }
}