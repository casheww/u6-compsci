using System;

namespace Intractable
{
    public class Program
    {
        public static void Main()
        {
            _stacks = new AllOfTheDataTypes.Stack<Ring>[3];
                
            for (_disks = 1; _disks <= 20; _disks++)
            {
                for (int i = 0; i < _stacks.Length; i++)
                    _stacks[i] = new AllOfTheDataTypes.Stack<Ring>(_disks);
                
                for (int i = _disks; i >= 1; i--)
                    _stacks[0].Push(new Ring(i));

                MoveStack(_disks, 0, 2, 1);

                Console.WriteLine($"\n{_disks} disks took {_moves} moves\n\n");
                Console.ReadLine();     // wait
            }
        }

        private static void MoveStack(int numDisks, int start, int end, int via)
        {
            if (numDisks == 1)
            {
                MoveOne(start, end);
            }
            else
            {
                MoveStack(numDisks - 1, start, via, end);  // Move n-1 disks to peg B
                MoveOne(start, end);                     // Move 1 disk to Peg C
                MoveStack(numDisks - 1, via, end, start);  // Then move n-1 disks from B back to C
            }
        }

        private static void MoveOne(int start, int end)
        {
            if (_stacks[start].TryPop(out Ring ring))
            {
                _stacks[end].Push(ring);
                _moves++;
                Console.WriteLine($"{ring.size} ::: \t{start} -> {end}");
            }
            else
                throw new Exception("aaaaa");
        }


        private static int _disks;
        private static int _moves;
        private static AllOfTheDataTypes.Stack<Ring>[] _stacks;

    }
}
