using System;

namespace Program
{
      
    class Program
    {
        static void Main(string[] args)
        {
            int res;
            string repeat;
            do
            {
                Console.WriteLine("Enter first no.:");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second no.:");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the symbol(+,-,*,/):");
                string symbol = Console.ReadLine();

                switch (symbol)
                {
                    case "+":

                        res = num1 + num2;
                        Console.WriteLine("Addition:" + res);
                        break;

                    case "-":
                        res = num1 - num2;
                        Console.WriteLine("Substraction:" + res);
                        break;

                    case "*":
                        res = num1 * num2;
                        Console.WriteLine("Multiplication:" + res);
                        break;

                    case "/":
                        res = num1 / num2;
                        Console.WriteLine("Divison:" + res);
                        break;
                    default:
                        Console.WriteLine("Invalid symbol");
                        break;
                }
                
                Console.WriteLine("Do you want to continue - Y/N");
                repeat = Console.ReadLine();
            }
              while (repeat == "Y" || repeat == "y");
             Console.ReadLine();
        }
    }
 }
