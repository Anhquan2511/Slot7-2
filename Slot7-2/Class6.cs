using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot7_2
{
    //--------------------------
    using System;

msg = "Multicast Delegate";
using static SLOT7.Class2;

MyDelegate MyDele01 = MyClass.Print;

    MyDelegate MyDele02 = MyClass.Show;
    Console.WriteLine("**Combines MyDele01 + MyDele02**");
MyDelegate myDele = MyDele01 + MyDele02;
    myDele(msg);
    Console.WriteLine("**Combines MyDele01 + MyDele02 + MyDele03**");
MyDelegate myDele03 = MyClass.Display;
    myDele03 += myDele03;
myDele(msg);
    Console.WriteLine("-------------------------------");
Console.WriteLine("Remove MyDele2: ");
myDele -= MyDele02;
myDele("hello ");

    Console.ReadLine();
}
