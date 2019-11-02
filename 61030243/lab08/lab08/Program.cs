using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace lab08
{
    class Program
    {
        static void Main()
        {
            ArrayList list1 = new ArrayList();
            list1.Add(10);
            list1.Add(20);
            list1.Add(30);
            list1.Add(40);
            Console.WriteLine("list1");
            for (int i = 0; i < list1.Count; i++)
            {
                Console.WriteLine(list1[i]);
            }
            ArrayList list2 = new ArrayList(list1);
            list2.Clear();
            list2.Add(55);
            list2.Add(66);
            list2.Add(77);
            Console.WriteLine("list2");
            for (int i = 0; i < list2.Count; i++)
            {
                Console.WriteLine(list2[i]);
            }

            Console.WriteLine(list2[2*1]);
            Console.ReadLine();
        }
    }
}
