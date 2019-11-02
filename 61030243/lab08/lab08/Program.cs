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
            Queue<string> queue1 = new Queue<string>();
            queue1.Enqueue("RED");
            queue1.Enqueue("BLUE");
            queue1.Enqueue("YELLOW");
            queue1.Enqueue("GREEN");

            Console.WriteLine("The elements in the queue are:" + queue1.Count);
            queue1.Clear();
            Console.WriteLine("The elements in the queue are after the clearmethod: " + queue1.Count);
            Console.ReadLine();
        }
    }
}
