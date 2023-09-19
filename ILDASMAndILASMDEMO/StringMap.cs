using System;
using System.Collections.Generic;

namespace CustomCollection.Tests
{
    // Do not change the name of this class
    public class StringMap<TValue> : IStringMap<TValue>
        where TValue : class
    {
        private readonly Dictionary<string, TValue> map = new Dictionary<string, TValue>();
        /// <summary> Returns number of elements in a map</summary>
        public int Count => map.Count;

        /// <summary>
        /// If <c>GetValue</c> method is called but a given key is not in a map then <c>DefaultValue</c> is returned.
        /// </summary>
        // Do not change this property
        public TValue DefaultValue { get; set; }

        /// <summary>
        /// Adds a given key and value to a map.
        /// If the given key already exists in a map, then the value associated with this key should be overriden.
        /// </summary>
        /// <returns>true if the value for the key was overriden otherwise false</returns>
        /// <exception cref="System.ArgumentNullException">If the key is null</exception>
        /// <exception cref="System.ArgumentException">If the key is an empty string</exception>
        /// <exception cref="System.ArgumentNullException">If the value is null</exception>
        public bool AddElement(string key, TValue value)
        {
            if (key == null)
                throw new ArgumentNullException(nameof(key));

            if (string.IsNullOrEmpty(key))
                throw new ArgumentException("Key cannot be empty.", nameof(key));

            if (value == null)
                throw new ArgumentNullException(nameof(value));

            // Check if the key already exists and override the value if it does
            if (map.ContainsKey(key))
            {
                map[key] = value;
                return true;
            }

            // Add the key-value pair to the map
            map.Add(key, value);
            return false;
        }

        /// <summary>
        /// Removes a given key and associated value from a map.
        /// </summary>
        /// <returns>true if the key was in the map and was removed otherwise false</returns>
        /// <exception cref="System.ArgumentNullException">If the key is null</exception>
        /// <exception cref="System.ArgumentException">If the key is an empty string</exception>
        public bool RemoveElement(string key)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            if (string.IsNullOrEmpty(key))
                throw new ArgumentException("Key cannot be empty.", nameof(key));

            return map.Remove(key);
        }

        /// <summary>
        /// Returns the value associated with a given key.
        /// </summary>
        /// <returns>The value associated with a given key or <c>DefaultValue</c> if the key does not exist in a map</returns>
        /// <exception cref="System.ArgumentNullException">If a key is null</exception>
        /// <exception cref="System.ArgumentException">If a key is an empty string</exception>
        public TValue GetValue(string key)
        {
            if (key == null)
                throw new ArgumentNullException(nameof(key));

            if (string.IsNullOrEmpty(key))
                throw new ArgumentException("Key cannot be empty.", nameof(key));

            // If the key exists in the map, return its value; otherwise, return DefaultValue
            if (map.TryGetValue(key, out var value))
            {
                return value;
            }

            return DefaultValue;
        }
    }
}
