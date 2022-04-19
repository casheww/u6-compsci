namespace PrimeChecker;

static class Program
{
    public static void Main()
    {
        bool done = false;

        while (!done)
        {
            Console.Write("Enter an integer >  ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int n))
            {
                Console.WriteLine("Input was not an integer.");
                continue;
            }

            if (n <= 1)
            {
                Console.WriteLine("Not greater than 1");
            }
            else if (CheckIsPrime(n))
            {
                Console.WriteLine("Is prime");
            }
            else
            {
                Console.WriteLine("Is not prime");
            }

            Console.Write("Do you want to enter another integer? [y/n] >  ");
            if (Console.ReadLine() != "y")
                done = true;
        }

    }

    private static bool CheckIsPrime(int n)
    {
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }
    
}
