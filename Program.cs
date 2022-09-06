namespace CalculatorAssignment_Lexicon
{
    internal class Program
    {
        static void Main(string[] args)
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
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine(result);
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine(result);
                    break;
                case "/":
                    result = num1 / num2;
                    Console.WriteLine(result);
                    break;
                case "%":
                    result = num1 % num2;
                    Console.WriteLine(result);
                    break;

                default:
                    Console.WriteLine("Invalid.");
                    break;
            }
        }
    }
}