namespace CustomCache
{
    public class CustomCache<TKey, TValue> where TKey : IEquatable<TKey>
    {
        private readonly object _lock = new object();
        private readonly Dictionary<TKey, TimedObject<TValue>> _cache;

        public CustomCache()
        {
            _cache = new Dictionary<TKey, TimedObject<TValue>>();
        }

        public bool AddItem(TKey key, TValue value, TimeSpan time)
        {
            try
            {
                lock (_lock)
                {
                    var n = new TimedObject<TValue>(value, time);
                    if (!_cache.TryAdd(key, n))
                    {
                        _cache[key] = n;
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public TValue? GetItem(TKey key)
        {
            var val = _cache[key];

            if (val != null)
            {
                if (val.IsValid)
                {
                    return val.Value;
                }
                else
                {
                    lock (_lock)
                    {
                        _cache.Remove(key);
                    }
                }
            }

            return default;
        }

        private class TimedObject<TValueObject>
        {
            public TValue? Value { get; set; }

            private DateTimeOffset _createdTime;

            public TimedObject(TValue value, TimeSpan time)
            {
                Value = value;
                _createdTime = DateTimeOffset.Now.Add(time);
            }

            public bool IsValid => _createdTime > DateTimeOffset.Now;
        }
    }
}
