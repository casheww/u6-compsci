namespace WordFromOtherWord;

static class Program
{
    public static void Main()
    {
        Console.Write("Enter the first word >  ");
        string first = Console.ReadLine().ToUpper();
        Console.Write("Enter the second word >  ");
        string second = Console.ReadLine().ToUpper();
        
        foreach (char c in first)
        {
            if (second.Contains(c))
            {
                int i = second.IndexOf(c);
                second = second.Substring(0, i) + second.Substring(i + 1, second.Length - i - 1);
            }
            else
            {
                Console.WriteLine("The first word CANNOT be made of letter from the second word.");
                return;
            }
        }

        Console.WriteLine("The first word CAN be made of letter from the second word.");
    }
}
