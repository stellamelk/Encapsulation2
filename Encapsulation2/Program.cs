using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation2
{
    class Program
    {
        static void Main(string[] args)
        {
            OnlyUnsign e = new OnlyUnsign();
            e.setX(10);
            Console.WriteLine(e.getX());
            e.setX(-50);
            Console.WriteLine(e.getX());
            Console.WriteLine("Press any key to exist");
            Console.ReadKey();
        }
    }
}
