using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _09_StreamingContent_UIRefactor.UI
{
    public class FunConsole : IConsole
    {
        public void Clear()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }

        public ConsoleKeyInfo ReadKey()
        {
            WriteLine("Reading your keypress, I swear I won't sell this data to a third party");
            return Console.ReadKey();
        }

        public string ReadLine()
        {
            string input = Console.ReadLine();
            return input.ToUpper();
        }

        public void Write(string s)
        {
            Console.Write(s);
        }

        public void WriteLine(string s)
        {
            Random rand = new Random();
            int color = rand.Next(0, 4);
            switch (color)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    break;
            }
            Thread.Sleep(color);
            string derpString = "";
            bool capitalize = false;
            foreach (char c in s)
            {
                if (capitalize)
                {
                    derpString += c.ToString().ToUpper();
                    capitalize = false;
                } else
                {
                    derpString += c.ToString().ToLower();
                    capitalize = true;
                }
            }

            Console.WriteLine(derpString);
        }

        public void WriteLine(object o)
        {
            Console.WriteLine(o);
        }

        public void WriteLine(DateTime d)
        {
            Console.WriteLine(d);
        }
    }
}
