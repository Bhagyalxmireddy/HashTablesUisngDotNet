﻿using System;

namespace HashTables_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcomt to HashTable");

            MyMapNode<int, string> hash = new MyMapNode<int, string>(4);
            /* hash.Add(0, "To");
             hash.Add(1, "be");
             hash.Add(2, "or");
             hash.Add(3, "not");
             hash.Add(4, "to");
             hash.Add(5, "be");

             string hash5 = hash.Get(5);
             Console.WriteLine("5th index  value is : " + hash5);

            // hash.Remove(3);

             string hash3 = hash.Get(3);
             Console.WriteLine("3th index  value is : " + hash3);*/
            FrequencyofPara para1 = new FrequencyofPara(); 
            string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] para = paragraph.Split(" ");
            int key = 0;
            foreach (string word in para)
            {
                hash.Add(key, word);
                key++;
            }
            para1.FrequencyOfWord(hash);

        }
    }
}
