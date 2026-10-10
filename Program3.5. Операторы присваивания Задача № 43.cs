using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 12;
            x >>= 2; // сдвиг вправо на 2 бита: 12 (1100) → 3 (0011)
            Console.WriteLine($"x после x >>= 2: {x}"); // Вывод: 3
        }
    }
}
