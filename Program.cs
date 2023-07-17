using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConAppCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ArrayList list=new ArrayList();
            // Hashtable ht =new hashtable();
            // SortedList sortedList =new SortedList();
            // Stack stack= new Stack();
            // Queue queue= new Queue();

            // stack push example
            //Stack stack = new Stack();
            //stack.Push("Aman");
            //stack.Push("vijay");
            //stack.Push("Nikhil");
            //stack.Push("Abhi");
            //stack.Push("Ram");
            //Console.WriteLine("Number of Items in stack are:\t"+stack.Count);
            //foreach(var item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            //// stack pop example
            //Console.WriteLine("After Removing"+stack.Pop());
            //Console.WriteLine("Number of Items in stack are:\t" + stack.Count);
            //foreach( var item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            ////stack peek example
            //Console.WriteLine("Peek Example: \t"+stack.Peek());
            //Console.WriteLine("After Peek");
            //Console.WriteLine("Number of Items in stack are:\t" + stack.Count);
            //foreach  (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            ////stack clear example
            //stack.Clear();
            //Console.WriteLine("After Clear Number of items are:\t"+stack.Count);
            //Console.ReadKey();

            // queue add example 
            Queue queue= new Queue();
            queue.Enqueue("aman");
            queue.Enqueue("Ram");
            queue.Enqueue("Nikhil");
            queue.Enqueue("Sam");
            queue.Enqueue("Zoya");

            Console.WriteLine("number of items in queue are:\t" + queue.Count);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            // queue removing example
            Console.WriteLine("after removing" + queue.Dequeue());
            Console.WriteLine("number of items in queue are:\t" + queue.Count);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            //queue peek example
            Console.WriteLine("peek example: \t" + queue.Peek());
            Console.WriteLine("after peek");
            Console.WriteLine("number of items in queue are:\t" + queue.Count);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            //quue clear example
            queue.Clear();
            Console.WriteLine("after clear number of items are:\t" + queue.Count);
            Console.ReadKey();
        }
    }
}
