using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashDictionary
{
    public class HashDictionary<K, V> : IDictionary<K, V>, ICollection<KeyValuePair<K, V>>, IEnumerable<KeyValuePair<K, V>>
    {
        //In this part you will create your own class that implements the IDictionary<K,V> interface. In order to implement the IDictionary<K,V> interface you must understand and implement the ICollection interface, and the IEnumerable interface. Implement  using some form of dynamic array or list and perform a linear search when looking for values.
        //NOTE: you are not allowed to use the C# Dictionary implementation as a delegate as this would make the assignment trivial. You are expected to be able to implement the IDictionary<K,V> yourselves in some way.

        private List<KeyValuePair<K, V>> data;

        public HashDictionary()
        {
            data = new List<KeyValuePair<K, V>>();
        }

        public V this[K key]
        {
            get
            {
                foreach (var pair in data)
                {
                    if(EqualityComparer<K>.Default.Equals(pair.Key, key))
                    {
                        return pair.Value;
                    }
                }
                throw new KeyNotFoundException("The key was not found");
            }

            set
            {
                for (int i = 0; i < data.Count; i++)
                {
                    if (EqualityComparer<K>.Default.Equals(data[i].Key, key))
                    {
                        data[i] = new KeyValuePair<K, V>(key, value);
                        return;

                    }

                }

                data.Add(new KeyValuePair<K, V>(key, value));

            }
        
        
        }

        public ICollection<K> Keys
        {
            get
            {
                List<K> keys = new List<K>(data.Count);

                foreach (var pair in data)
                {
                    keys.Add(pair.Key);
                }
                return keys;
            }
        }

        public ICollection<V> Values
        {
            get
            {
                List<V> values = new List<V>(data.Count);

                foreach (var pair in data)
                {
                    values.Add(pair.Value);
                }
                return values;
            }
        }

        public int Count => data.Count;

        public bool IsReadOnly => false;

        public void Add(K key, V value)
        {
            if (ContainsKey(key))
            {
                throw new ArgumentException("An item with the same key already exists");
            }
            data.Add(new KeyValuePair<K, V>(key, value));
        }

        public void Add(KeyValuePair<K, V> item)
        {
            Add(item.Key, item.Value);
        }

        public void Clear()
        {
            data.Clear();
        }

        public bool Contains(KeyValuePair<K, V> item)
        {
            return data.Contains(item);
        }

        public bool ContainsKey(K key)
        {
            foreach (var pair in data)
            {
                if (EqualityComparer<K>.Default.Equals(pair.Key, key))
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(KeyValuePair<K, V>[] array, int arrayIndex)
        {
            data.CopyTo(array, arrayIndex);
        }

        public IEnumerator<KeyValuePair<K, V>> GetEnumerator()
        {
            return data.GetEnumerator();
        }

        public bool Remove(K key)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (EqualityComparer<K>.Default.Equals(data[i].Key, key))
                {
                    data.RemoveAt(i);
                    return true;
                }

            }
            return false;
        }

        public bool Remove(KeyValuePair<K, V> item)
        {
            return data.Remove(item);
        }

        public bool TryGetValue(K key, [MaybeNullWhen(false)] out V value)
        {
            foreach (var pair in data)
            {
                if (EqualityComparer<K>.Default.Equals(pair.Key, key))
                {
                    value = pair.Value;
                    return true;
                }
            }
            value = default;
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
