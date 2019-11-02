using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab08
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue1 = new Queue<int>();
            queue1.Enqueue(10);
            queue1.Enqueue(20);
            queue1.Enqueue(30);
            queue1.Enqueue(40);
            Console.WriteLine("The queue elements are:");
            foreach (int i in queue1)
            {
                Console.WriteLine(i);
            }
            ArrayList array = new ArrayList(queue1.ToArray());
            Console.WriteLine("\nContents of the copy");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
