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
            Console.WriteLine("Enter your first number.");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your operator. (+, -, *, /, %.");
            string op = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter your second number.");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double result;

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
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero (0).");
                        Console.ReadLine();
                        break;
                    }
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