using System;
using System.Collections.Generic;

namespace StringCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string s1 = "Ola";
            string s2 = "Porta";
            string s3 = "Morte";
            string s4 = "Fila";
            string s5 = "Fila";

            // Colections
            List<string> strList = new List<string>();
            Stack<string> strStack = new Stack<string>();
            Queue<string> strQueue = new Queue<string>();
            HashSet<string> strHash = new HashSet<string>();


            // Store values....
            // ....in list
            strList.Add(s1);
            strList.Add(s2);
            strList.Add(s3);
            strList.Add(s4);
            strList.Add(s5);

            // .... in stack
            strStack.Push(s1);
            strStack.Push(s2);
            strStack.Push(s3);
            strStack.Push(s4);
            strStack.Push(s5);

            // .... in Queue
            strQueue.Enqueue(s1);
            strQueue.Enqueue(s2);
            strQueue.Enqueue(s3);
            strQueue.Enqueue(s4);
            strQueue.Enqueue(s5);

            // .... in hashSet
            strHash.Add(s1);
            strHash.Add(s2);
            strHash.Add(s3);
            strHash.Add(s4);
            strHash.Add(s5);

            // Print...
            // ... list
            foreach(string s in strList)
                Console.WriteLine(s);

            Console.WriteLine();

            // ... stack
            foreach(string s in strStack)
                Console.WriteLine(s);

            Console.WriteLine();

            // .... queue
            foreach(string s in strQueue)
                Console.WriteLine(s);

            Console.WriteLine();

            // .... hashSet
            foreach(string s in strHash)
                Console.WriteLine(s);
        }
    }
}
