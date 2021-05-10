using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContent_UIRefactor.UI
{
    public interface IConsole
    {
        void WriteLine(string s);
        void WriteLine(object o);
        void WriteLine(DateTime d);
        void Write(string s);
        string ReadLine();
        ConsoleKeyInfo ReadKey();
        void Clear();
    }
}
