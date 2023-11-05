﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice_5
{
    internal class Arrow
    {

        public int arrow()
        {
            ConsoleKeyInfo key;
            key = Console.ReadKey();
            int pos = 1;

            while (key.Key != ConsoleKey.Enter)
            {
                Console.CursorVisible = false;
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("  ");
                if (key.Key == ConsoleKey.UpArrow && pos != 0)
                {
                    pos--;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    pos++;
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    return -1;
                }

                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");

                key = Console.ReadKey();
            }
            return pos;
        }

    }
}