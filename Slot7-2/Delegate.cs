using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLOT7
{
    internal class Class2
    {
        public delegate void MyDelegate(string msg);

        class MyClass
        {
            public static void Print(string msg) => Console.WriteLine($"{msg.ToUpper()}");
            public static void Show(string msg) => Console.WriteLine($"{msg.ToLower()}");
        }

        class Program
        {
            static void InvokeDelegate(MyDelegate dele, string msg) => dele(msg);

            static void Main(string[] args)
            {
                string msg = "Passing Delegate As A Parameter";
                InvokeDelegate(MyClass.Print, msg);
                InvokeDelegate(MyClass.Show, msg);
                Console.ReadLine();
            }

        }
        class 

    }



}