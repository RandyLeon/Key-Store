using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            Console.Write("List: ");
            foreach (var i in list)
            {
                Console.Write($"{i} ");
            }
            Console.Write("\n\n\nLinkedList: ");
            LinkedList<int> vs = new LinkedList<int>();
            vs.AddFirst(6);
            vs.AddAfter(vs.First, 10);
            vs.AddAfter(vs.First, 9);
            vs.AddAfter(vs.First, 8);
            vs.AddAfter(vs.First, 7);
            foreach (var i in vs)
            {
                Console.Write($"{i} ");
            }

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("1");
            queue.Enqueue("2");
            queue.Enqueue("3");
            queue.Enqueue("4");
            queue.Enqueue("5");
            Console.Write("Queue: ");
            foreach (var i in queue)
            {
                Console.Write($"{i} ");
            }

            Console.Write("Stack: ");
            
            Stack<int> stack = new Stack<int>();
            stack.Push(11);
            stack.Push(12);
            stack.Push(13);
            stack.Push(14);
            stack.Push(15);
            foreach (var i in stack)
            {
                Console.Write($"{i} ");
            }


            
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            keyValuePairs.Add(1, "hello");
            keyValuePairs.Add(2, "hola");
            keyValuePairs.Add(3, "bonjour");
            keyValuePairs.Add(4, "zdravstvuyte");
            keyValuePairs.Add(5, "nin hao");
            Console.Write("Dictionary: ");
            foreach (KeyValuePair<int, string> kvp in keyValuePairs)
            {
                Console.Write($"Key = {kvp.Key}, Value = {kvp.Value}");
            }
            
            SortedList<int, string> sortedList = new SortedList<int, string>();
            sortedList.Add(2, "7");
            sortedList.Add(1, "6");
            sortedList.Add(3, "8");
            sortedList.Add(4, "9");
            sortedList.Add(5, "10");
            Console.Write("\n\n\nSortedList: ");
            foreach (KeyValuePair<int, string> kvp in sortedList)
            {
                Console.Write($"Key = {kvp.Key}, Value = {kvp.Value} ");
            }


            
            HashSet<int> hash = new HashSet<int>();
            for (int i = 0; i < 11; i++)
            {
                hash.Add(i * 2);
            }
            Console.Write("Hash Table: ");
            foreach (var i in hash)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}

