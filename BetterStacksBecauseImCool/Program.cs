using System;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {

            string input;

            do
            {
                Console.Write("  >  ");
                input = Console.ReadLine();
                if (input == "exit") break;

                try
                {
                    Console.WriteLine(CalculateReversePolish(input));
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                
            } while (input != "exit");

        }

        static float CalculateReversePolish(string input)
        {
            string[] tokens = input.Split(" ");
            Stack<float> stack = new Stack<float>(32);

            foreach (string t in tokens)
            {
                if (float.TryParse(t, out float val))
                {
                    stack.Push(val);
                }
                else if (stack.TryPop(out float v1) && stack.TryPop(out float v0) &&
                         TryDoOperation(t, v0, v1, out float ans))
                {
                    // v1 needs to be popped before v0 because their original order is switched when they are pushed to the stack
                    stack.Push(ans);
                }
                else
                {
                    throw new FormatException("invalid token");
                }
            }

            if (stack.TopOfStackPointer != 0)
                throw new FormatException("too many values left over after calculation");

            stack.TryPop(out float result);
            return result;
        }

        static bool TryDoOperation(string token, float v0, float v1, out float result)
        {
            switch (token)
            {
                default:
                    result = 0f;
                    return false;
                
                case "+":
                    result = v0 + v1;
                    break;
                case "-":
                    result = v0 - v1;
                    break;
                case "*":
                    result = v0 * v1;
                    break;
                case "/":
                    result = v0 / v1;
                    break;
                case "^":
                    result = MathF.Pow(v0, v1);
                    break;
            }

            return true;
        }

        static void TestStack()
        {
            Stack<int> s = new Stack<int>(10);
            
            s.Push(5);
            s.Push(10);
            s.Push(12);

            s.TryPeek(out int top);
            Console.WriteLine($"value at the top of the stack is {top}");

            s.TryPop(out _);
            s.TryPop(out _);
            s.TryPop(out _);
            Console.WriteLine(s.IsEmpty);

            for (int i = 0; i < 10; i++)
            {
                s.Push(i + 2);
            }
            
            s.DebugPrint();
            Console.WriteLine(s.IsFull);
            
            s.DebugPrint();
            Console.WriteLine(s.TopOfStackPointer);

            s.TryPop(out int o);
            Console.WriteLine(o);
        }
    }
}