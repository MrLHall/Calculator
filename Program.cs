namespace ConsoleApp7
{
    internal class Program
    { 
        static float multipliy (int a, int b) 
        {
            return a * b;
        }
        static float divide(int a, int b)
        {
            return a / b;
        }
        static float addition(int a, int b)
        {
            return a + b;
        }
        static float subtract(int a, int b)
        {
            return a - b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("whats the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("whats the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("pick an option - \n1 - multipliy \n2 - divide \n3 - add\n4 - subtract");
            int choice = Convert.ToInt32(Console.ReadLine());
            float answer = 0;
            if (choice == 1)
            {
                answer = multipliy(num1, num2);
            }
            else if (choice == 2)
            {
                answer = divide(num1, num2);
            }
            else if (choice == 3)
            {
                answer = addition(num1, num2);
            }
            else if (choice == 4)
            {
                answer = subtract(num1, num2);
            }
            Console.WriteLine($"the answer to your calculation is {answer}");
        }
    }
}
