using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot7_4
{
    public delegate void PrintDetails(String msg);
    class Program
    {
        event PrintDetails Print;
        void Show(String msg) => Console.WriteLine(msg.ToUpper());
        static void Main(String[] args)
        {
            Program p = new Program();
            p.Print = new PrintDetails(p.Show);
            p.Print("Hello World !!");
            Console.ReadLine();
        }
    }
}
