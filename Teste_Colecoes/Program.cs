using System;
using System.Collections.Generic;

namespace Teste_Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine((2).CompareTo(5));
            //Console.WriteLine((2).CompareTo(2));
            //Console.WriteLine((2).CompareTo(10000));
            //Console.WriteLine((2).CompareTo(0));

            List<int> lst = new List<int>() { 5, -7, 9, 20, 3, 0 };
            lst.Sort();
            foreach (int i in lst)
                Console.WriteLine(i);
;

        }
    }
}
