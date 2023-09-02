internal class Program
{
    private static void Main(string[] args)
    { 
        Console.WriteLine("^^^^^^^^^ Welcome to the Calculator  app ^^^^^^^^^^");
        while (true)
        {
            
            Console.Write("Enter num1 : ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter num2 : ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Sellect Operatio : \n  + for adding, - for subtracting, * for multiplication, / for division \n ####-> ");
            string key = Console.ReadLine();
            switch (key)
            {
                case "+":
                    Console.WriteLine("result -> " + Math.Round((num1 + num2), 2) + "\n");
                    break;
                case "-":
                    Console.WriteLine("result -> " + Math.Round((num1 - num2), 2) + "\n");
                    break;
                case "*":
                    Console.WriteLine("result -> " + Math.Round((num1 * num2), 2) + "\n");
                    break;
                case "/":
                    Console.WriteLine("result -> " + Math.Round((num1 / num2), 2)+ "\n");
                    break;
                default:
                    Console.WriteLine("Invalid operator\n");
                    break;

            }
            Console.Write("@@@ - > Press q for exit and anything else to continue \n -> ");
             key = Console.ReadLine();
            if(key == "q")
            {
                break;
            }
        }



    }
    private static int NthFibonacciNumber(int number)
    {
        if ((number == 0) || (number == 1))
        {
            return number;
        }
        else
        {
            return (NthFibonacciNumber(number - 1) + NthFibonacciNumber(number - 2));
        }
    }
}