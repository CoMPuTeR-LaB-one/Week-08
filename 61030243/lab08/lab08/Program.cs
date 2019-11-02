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
            int[,] multiplyTable = new int[12, 12];
            multiplyTable[0, 0] = 2 * 1;
            multiplyTable[1, 0] = 2 * 2;
            multiplyTable[2, 0] = 2 * 3;
            multiplyTable[3, 0] = 2 * 4;
            multiplyTable[4, 0] = 2 * 5;
            multiplyTable[5, 0] = 2 * 6;
            multiplyTable[6, 0] = 2 * 7;
            multiplyTable[7, 0] = 2 * 8;
            multiplyTable[8, 0] = 2 * 9;
            multiplyTable[9, 0] = 2 * 10;
            multiplyTable[10, 0] = 2 * 11;
            multiplyTable[11, 0] = 2 * 12;
            for (int row = 0; row < multiplyTable.GetLength(0); row++)
            {
                for (int col = 0; col < multiplyTable.GetLength(1); col++)
                {
                    Console.Write("{0,5}", multiplyTable[row, col]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
