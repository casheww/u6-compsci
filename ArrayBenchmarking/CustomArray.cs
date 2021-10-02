namespace ArrayBenchmarking
{
    public readonly struct CustomArray<T>
    {
        public CustomArray(uint width, uint height)
        {
            _items = new T[width * height];
            this.width = width;
        }

        public T this[int x, int y]
        {
            get => _items[x + y * width];
            set => _items[x + y * width] = value;
        }

        private readonly T[] _items;
        public readonly uint width;
    }
}
