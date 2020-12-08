using System;
using System.Collections.Generic;
using System.Text;

namespace HashTables_Program
{
    public  class MyMapNode<K, V>
    {
        private readonly int size;
        private readonly LinkedList<KeyValuePair<K, V>>[] items;

        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValuePair<K, V>>[size];
        }
        protected int getArrayPosition(K key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }
        public V Get(K key)
        {
            int position = getArrayPosition(key);
            LinkedList<KeyValuePair<K, V>> linkedList = GetLinkedList(position);
            foreach(KeyValuePair<K, V> item in linkedList)
            {
                if (item.key.Equals(key))
                {
                    return item.value;
                }
            }
            return default(V);
        }

        public void Add(K key, V value)
        {
            int position = getArrayPosition(key);
            LinkedList<KeyValuePair<K, V>> linkedList = GetLinkedList(position);
            KeyValuePair<K, V> item = new KeyValuePair<K, V>() { key = key, value = value };
            linkedList.AddLast(item);
        }
        public void Remove(K key)
        {
            int position = getArrayPosition(key);
            LinkedList<KeyValuePair<K, V>> linkedList = GetLinkedList(position);
            bool itemFound = false;
            KeyValuePair<K, V> founditem = default(KeyValuePair<K, V>);
            foreach(KeyValuePair<K, V> item  in linkedList)
            {
                if (item.key.Equals(key))
                {
                    itemFound = true;
                    founditem = item;
                }
            }
            if (itemFound)
            {
                linkedList.Remove(founditem);
            }
        }

        protected LinkedList<KeyValuePair<K, V>> GetLinkedList(int position)
        {
            LinkedList<KeyValuePair<K, V>> linkedList = items[position];
            if(linkedList == null)
            {
                linkedList = new LinkedList<KeyValuePair<K, V>>();
                items[position] = linkedList;
            }
            return linkedList;
        }
    }
    public struct KeyValuePair<K, V>
    {
        public K key { get; set; }
        public V value { get; set; }
    }
}
