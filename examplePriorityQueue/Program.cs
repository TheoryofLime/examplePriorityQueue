using System;
using System.Globalization;

namespace examplePriorityQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue<string, int> newPriorityQueue= new PriorityQueue<string, int>();
            // add items
            newPriorityQueue.Enqueue("A", 1);
            newPriorityQueue.Enqueue("B", 2);
            newPriorityQueue.Enqueue("C", 3);
            newPriorityQueue.Enqueue("D", 4);
            newPriorityQueue.Enqueue("E", 5);
            // find highest priority and remove
            Console.WriteLine(newPriorityQueue.Peek());
            newPriorityQueue.Dequeue();
            // execute all sad little objects
            Console.WriteLine(newPriorityQueue.Peek());
            newPriorityQueue.Dequeue();
            Console.WriteLine(newPriorityQueue.Peek());
            newPriorityQueue.Dequeue();
            Console.WriteLine(newPriorityQueue.Peek());
            newPriorityQueue.Dequeue();
            Console.WriteLine(newPriorityQueue.Peek());
            newPriorityQueue.Dequeue();
        }
    }
}