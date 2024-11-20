namespace RecentlyUsedList
{
    public class RecentlyUsedListClass
    {
        private readonly int _capacity;
        private readonly List<string> _items;

        public RecentlyUsedListClass(int capacity = 5)
        {
            if (capacity < 0) throw new ArgumentException("Capacity must be non-negative.");
            _capacity = capacity;
            _items = new List<string>();
        }

        public int Count => _items.Count;
        public int Capacity => _capacity;

        public void Add(string item)
        {
            if (string.IsNullOrEmpty(item))
            {
                throw new ArgumentException("Null or empty strings are not allowed.");
            }

            _items.Remove(item);

            _items.Insert(0, item);

            if (_capacity > 0 && _items.Count > _capacity)
            {
                _items.RemoveAt(_items.Count - 1);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= _items.Count)
                {
                    throw new ArgumentOutOfRangeException(nameof(index), "Index out of bounds.");
                }

                return _items[index];
            }
        }

        public bool Contains(string item) => _items.Contains(item);
    }
}
