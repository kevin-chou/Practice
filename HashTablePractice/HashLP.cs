namespace HashTablePractice
{
    /// <summary>
    /// A simple hash table implementation that uses linear probing to handle collisions.
    /// </summary>
    public class HashLP<TKey, TValue> 
        where TKey :  IEquatable<TKey>
        where TValue : IEquatable<TValue>
    {
        public class KeyValuePair
        {
            public TKey Key { get; set; }
            public TValue Value { get; set; }   

            public KeyValuePair(TKey keyPair, TValue valuePair)
            {
                Key = keyPair;
                Value = valuePair;
            }
        }

        private KeyValuePair[] table;
        private uint tableSize;

        public HashLP(uint size)
        {
            tableSize = size;
            table = new KeyValuePair[tableSize];
        }

        /// <summary>
        /// Computes the hash code for a given key and maps it to an index in the array.
        /// </summary>
        /// <param name="key">They key to compute hash code for.</param>
        /// <returns>An index in the array.</returns>
        private int MapToIndex(TKey key)
        {
            int hashCode = key?.GetHashCode() ?? 0;
            return Math.Abs(hashCode % (int)tableSize);
        }

        /// <summary>
        /// Inserts a key value pair into the hash table.
        /// </summary>
        /// <param name="key">The key for the key value pair.</param>
        /// <param name="value">The value for the key value pair.</param>
        /// <returns>0 if the operation was successful and -1 otherwise.</returns>
        public int Insert(TKey key, TValue value)
        {
            int index = MapToIndex(key); // map hash code to index in the array

            // handle collision using linear probing method
            // search for empty spot in table starting from hash code index
            for (int i = 0; i < tableSize; i++)
            {
                if (table[index] == null)
                {
                    table[index] = new KeyValuePair(key, value);   
                    return 0;
                }

                index = (index + 1) % (int)tableSize;
            }

            return -1;
        }

        /// <summary>
        /// Searches the hash table using the given key.
        /// </summary>
        /// <param name="key">The key to search for.</param>
        /// <returns>The corresponding value to the given key or null/default value if the key does not exist.</returns>
        public TValue? Search(TKey key)
        {
            int index = MapToIndex(key); // map hash code to index in the array

            // search for key starting from hash code index
            // continue search using linear probing if element not found
            for (int i = 0; i < tableSize; i++)
            {
                // return value if key found
                if (table[index] != null && table[index].Key.Equals(key))
                {
                    return table[index].Value;
                }

                index = (index + 1) % (int)tableSize;
            }

            return default;
        }

        /// <summary>
        /// Deletes the given key value pair from the hash table
        /// </summary>
        /// <param name="key"></param>
        /// <returns>0 if operation sucessful and -1 otherwise.</returns>
        public int Delete(TKey key)
        {
            int index = MapToIndex(key); // map hash code to index in the array

            // search for key starting from hash code index
            // continue search using linear probing if element not found
            for (int i = 0; i < tableSize; i++)
            {
                // delete element if key is found
                if (table[index] != null && table[index].Key.Equals(key))
                {
                    table[index] = null;
                    return 0;
                }

                index = (index + 1) % (int)tableSize;
            }

            return -1;
        }
    }
}
