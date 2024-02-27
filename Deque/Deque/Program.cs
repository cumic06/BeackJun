using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deque
{
    class Program
    {
        static Queue<int> deque = new Queue<int>();
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Deque(Console.ReadLine().Split());
            }
        }
        static void Deque(string[] a)
        {
            string command = a[0];
            int value = 0;
            if (a.Length > 1)
            {
                value = int.Parse(a[1]);
            }
            if (command == "push_front")
            {
                //deque.Enqueue();
            }
            if (command == "front")
            {
                //if (intQueue.Count == 0)
                //{
                //    sb.AppendLine("-1");
                //}
                //else
                //{
                //    sb.AppendLine($"{intQueue.Peek()}");
                //}
            }
            if (command == "back")
            {
                //if (intQueue.Count == 0)
                //{
                //    sb.AppendLine("-1");
                //}
                //else
                //{
                //    int[] queueArray = intQueue.ToArray();
                //    sb.AppendLine($"{queueArray[queueArray.Length - 1]}");
                //}
            }
            if (command == "size")
            {
                //sb.AppendLine($"{intQueue.Count}");
            }
            if (command == "empty")
            {
                //if (intQueue.Count == 0)
                //{
                //    sb.AppendLine("1");
                //}
                //else
                //{
                //    sb.AppendLine("0");
                //}
            }
            if (command == "pop")
            {
                //if (intQueue.Count == 0)
                //{
                //    sb.AppendLine("-1");
                //}
                //if (intQueue.Count >= 1)
                //{
                //    sb.AppendLine($"{intQueue.Dequeue()}");
                //}
            }
        }
    }
}
