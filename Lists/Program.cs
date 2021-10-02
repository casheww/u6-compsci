using System;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing the class
            var myList = new ListArray();
            myList.Add(new Item { ProductName = "carrots", Quantity = 1 });
            myList.Add(new Item { ProductName = "milk", Quantity = 1 });
            myList.Add(new Item { ProductName = "apples", Quantity = 1 });
            myList.Add(new Item { ProductName = "biscuits", Quantity = 2 });
            myList.Add(new Item { ProductName = "carrots", Quantity = 1 });

            // List the items in the list
            Console.WriteLine(MakeListString(myList));


            // Remove carrots
            myList.Remove(new Item() {ProductName = "carrots"});


            // List the items in the list again
            Console.WriteLine(MakeListString(myList));


            // Ask the user for an item and output its position in the list
            Console.WriteLine("\nSearch for item:  ");
            string input = Console.ReadLine();
            bool success = myList.Find(new Item() {ProductName = input}, out int pos);
            
            if (success)
                Console.WriteLine($"{input} found at {pos}");
            else
                Console.WriteLine($"{input} not found");


        }

        private static string MakeListString(ListArray myList)
        {
            string listStr = "LIST:\n";
            for (int i = 0; i < myList.Count; i++)
            {
                Item item = myList.Retrieve(i);
                listStr += $"  - {item.ProductName} x{item.Quantity}\n";
            }

            return listStr;
        }

    }
}
