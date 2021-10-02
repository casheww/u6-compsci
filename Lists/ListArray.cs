using System;

namespace Lists
{
    public class ListArray
    {
        private Item[] items;
        private int count;
        private int capacity;

        public int Count
        {
            get { return count; }
        }

        public ListArray() : this(capacity: 100)
        {
        }

        public ListArray(int capacity)
        {
            items = new Item[capacity];
            this.capacity = capacity;
            count = 0;
        }

        public void Add(Item item)
        {
            if (!Full())
            {
                items[count] = item;
                count++;
            }
        }

        public bool Full()
        {
            return count >= items.Length;
        }

        public bool Empty()
        {
            return count == 0;
        }

        public bool Remove(Item item)
        {
            // Removes all items that match item. 
            // Returns true if there was any.
            int location = 0;
            bool result = false;
            while (location < count)
            {
                if (items[location].ProductName == item.ProductName)
                {
                    items[location] = items[count - 1];
                    count--;
                    location--; // to ensure item moved up is checked
                    result = true;
                }
                location++;
            }
            return result;
        }

        public void RemoveAt(int index)
        {
            if (index < count)
            {
                for (int i = index; i < count; i++)
                {
                    items[i] = (i + 1 < count) ? items[i + 1] : null;
                }
            }
        }

        public Item Retrieve(int index)
        {
            if (index <= count)
            {
                return items[index];
            }
            else
            {
                throw new InvalidOperationException("Index out of boundaries");
            }
        }

        public bool Find(Item item, out int position)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i].ProductName == item.ProductName)
                {
                    position = i;
                    return true;
                }
            }
            position = -1;
            return false;
        }

    }
}
