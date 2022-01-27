namespace SearchAndSort
{
    public static class Search
    {
        public static bool LinearSearch(int[] arr, int value, out int index)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    index = i;
                    return true;
                }
            }

            index = -1;
            return false;
        }

        public static bool BinarySearch(int[] arr, int value, out int index)
        {
            int start = 0;
            int len = arr.Length;
            index = -1;

            bool found = false;
            while (!found || len > 0)
            {
                int mid = len / 2;
                if (arr[mid] == value)
                {
                    index = mid;
                    found = true;
                }
                else if (arr[mid] < value)
                {
                    start = mid;
                    len = arr.Length - start;
                }
                else
                {
                    len = arr.Length - mid;
                }
            }

            return found;
        }
    }
}
