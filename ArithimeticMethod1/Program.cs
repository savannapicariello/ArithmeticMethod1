using System;

namespace ArithmeticMethod2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Savanna Picariello");

            int num1, num2;
            string option;

            Console.WriteLine("Enter your first integer: ");

            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.Clear();
                Console.Write("Please enter a number! ");

            }
            Console.WriteLine("This is your first integer: " + num1);

            Console.WriteLine("Enter your second integer: ");

            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.Clear();
                Console.Write("Please enter a number! ");

            }
            Console.WriteLine("This is your second integer: " + num2);

            Console.WriteLine("\nPlease choose the Arithmetic Operation you wish to perform: \"Addition\",  \"Subtraction\", \"Multiplication\", \"Division\"): ");
            option = Console.ReadLine();

            ResultMessage(num1, num2, option);
        }
        static void ResultMessage(int n1, int n2, string operation)
        {

            bool Zero = false;

            if (n2 == 0)
            {
                Zero = true;
            }

            switch (operation.ToLower())
            {
                case "addition":
                    Console.WriteLine("The sum of " + n1 + " and " + n2 + " is " + (n1 + n2));
                    break;
                case "subtraction":
                    Console.WriteLine("The difference between " + n1 + " and " + n2 + " is " + (n1 - n2));
                    break;
                case "multiplication":
                    Console.WriteLine("The product between " + n1 + " and " + n2 + " is " + (n1 * n2));
                    break;
                case "division":
                    if (Zero)
                    {
                        Console.WriteLine("Cannot divide by 0.");
                    }
                    else
                    {
                        Console.WriteLine(" The division between " + n1 + " and " + n2 + " equals " + (n1 / n2));
                    }
                    break;
                default:
                    Console.WriteLine("Unknown function.");
                    break;

            }
        }
    }
    
}
