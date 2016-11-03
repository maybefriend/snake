﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1, y1 = 3;
            char sym1 = '*';

            Draw(x1, y1, sym1);

            int x2 = 4, y2 = 5;
            char sym2 = 'm';

            Draw(x2, y2, sym2);

            Console.ReadLine();
        }

        static void Draw(int x, int y, char sym)//функция
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
