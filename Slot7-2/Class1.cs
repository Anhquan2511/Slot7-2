using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate int Mydelegate(int num1, int num2);
class Program
{
    static int Add(int num1, int num2) => num1 + num2;
    static int Subtract(int num1, int num2) => num1 - num2;
    static void Main(string[] args)
    {
        int num1 = 25;
        int num2 = 15;
        int result;
        Mydelegate obj1 = new Mydelegate(Add);
        result = obj1(num1, num2);
        Console.WriteLine($"{num1} + {num2} = {result} ");
        Mydelegate obj2 = new Mydelegate(Subtract);
        result = obj2.Invoke(num1, num2);
        Console.WriteLine($"{num1} - {num2} = {result} ");
        Console.ReadLine();
    }
}
