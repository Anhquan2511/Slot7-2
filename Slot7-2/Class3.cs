using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot7_3
{
    class program
    {
        static int Sum(int x, int y) => x + y;
        static void Print(string msg) => Console.WriteLine(msg.ToUpper());
        static void Main(string[] args)
        {
            int a = 25;
            int b = 15, s;
            string strResult;

            Func<int, int, int> sumFunc = Sum;
            s = sumFunc(a, b);
            strResult = $"{a}+{b}= {s}";
            Console.WriteLine("***Involke Print method by Action delegate***");
            Action<string> action = Print;
            action(strResult);
            Console.ReadLine();
        }
    }
}
