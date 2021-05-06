using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============Welcome To Hash Table Program=================");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To be or not to be");
            hash.frequencyOfWords("0");
        }
    }
}
