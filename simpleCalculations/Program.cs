namespace simpleCalculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, sum;
            decimal remainder, remByTwo1, remByTwo2;
            for (int i = 0; i < 1000000; i++)
            {
            Console.WriteLine("Enter your first number please:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number please:");
            num2 = int.Parse(Console.ReadLine());
            remainder = num1 % num2;
            if (remainder == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("The first number is  divisible by the second number.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("The first number is not divisible by the second number.");
            }
            //Now we want to know the number that has entered is odd or even..
            remByTwo1 = num1 % 2;
            remByTwo2 = num2 % 2;
            if (remByTwo1 == 0 && remByTwo2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Both numbers are even.");
            }else if(remByTwo1 == 0 && remByTwo2 != 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("The first number is even, but the second number is odd.");
            }else if (remByTwo1 != 0 && remByTwo2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("The first number is odd and the second number is even.");
            }else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Both number are odd.");
            }

            //Let's check sum of the two numbers that user has entered.
            sum = num1 + num2;
            Console.WriteLine("Sum= " + sum);

            //How an user can enter new numbers to calculate?
            Console.WriteLine("Would you like to enter new numbers? answer yes/no");
            string answer = Console.ReadLine();
                if (answer == "yes")
                    continue;
                else
                    break;
            }

            Console.ReadLine();
        }
    }
}
