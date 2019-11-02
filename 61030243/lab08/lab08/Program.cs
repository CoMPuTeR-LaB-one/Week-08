using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab08
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();
            Console.WriteLine("-- add 4 items -- ");
            s.Push(10);
            s.Push(20);
            s.Push(30);
            s.Push(40);
            Console.Write("Stack contains : ");
            foreach (var item in s)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(Environment.NewLine + "s.Count  = {0}", s.Count);
            Console.WriteLine("s.Peek = {0}", s.Peek());

            Console.WriteLine("-- add more items -- ");
            s.Push(50);
            s.Push(60);

            Console.Write("Queue contains : ");
            foreach (var item in s)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(Environment.NewLine + "s.Count  = {0}", s.Count);
            Console.WriteLine("s.Peek = {0}", s.Peek());

            Console.WriteLine("-- push -- ");
            int i = s.Pop();
            Console.WriteLine("i = {0}", i);

            Console.Write("Stack contains : ");
            foreach (var item in s)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(Environment.NewLine + "s.Count  = {0}", s.Count);
            Console.WriteLine("s.Peek = {0}", s.Peek());
            Console.ReadLine();
        }
    }
}
