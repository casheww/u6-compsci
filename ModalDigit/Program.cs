

namespace ModalDigit;

public static class Program
{
    public static void Main()
    {
        int[] frequencies = new int[10];
        
        Console.Write("Enter the number of digits to be entered >  ");
        int digitCount = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < digitCount; i++)
        {
            Console.Write($"\nEnter digit number {i+1} >  ");
            int digit = int.Parse(Console.ReadLine());
            frequencies[digit]++;
        }

        int modalFreq = -1;
        bool multimodal = false;
        for (int i = 0; i < frequencies.Length; i++)
        {
            if (frequencies[i] > modalFreq)
            {
                multimodal = false;
                modalFreq = frequencies[i];
            }
            else if (frequencies[i] == modalFreq)
            {
                multimodal = true;
            }
        }

        if (multimodal)
            Console.WriteLine("\nData was multimodal");
        else
            Console.WriteLine($"\n{modalFreq}");
    }
}

