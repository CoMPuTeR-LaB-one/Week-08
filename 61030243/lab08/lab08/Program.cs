using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace lab08
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> Tfile = new Dictionary<string, string>();
            Tfile.Add("txt", "Notepad.exe");
            Tfile.Add("bmp", "paint.exe");
            Tfile.Add("rtf", "wordpad.exe");
            Tfile.Add("pdf", "acrobat.exe");

            foreach(var item in Tfile)
                Console.WriteLine($"{item.Key} => {item.Value}");
            Console.WriteLine();

            Console.Write("Enter type file: ");
            string type = Console.ReadLine().ToLower();

            foreach (var item in Tfile)
            {
                if (type.Equals(item.Key))
                    Process.Start(item.Value);
            }

            Console.ReadLine();
        }
    }
}
