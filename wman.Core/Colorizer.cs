using System;
using System.Drawing;

namespace wman.Core
{
    public static class Colorizer
    {
        public static void ColorString(string src, char stringChar, Color color)
        {
            bool isIn = false;
            foreach (var c in src)
            {
                if (c == stringChar) isIn = !isIn;
                if (isIn)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    SetScreenColorsApp.SetColor(ConsoleColor.DarkRed, color);
                    Console.Write(c);
                }
                else
                {
                    Console.Write(c);
                    Console.ResetColor();
                }
            }
        }
    }
}