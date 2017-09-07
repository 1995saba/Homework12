using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Type consoleType = typeof(Console);

            foreach(var method in consoleType.GetMethods())
            {
                Console.WriteLine(method.ToString());
            }
            Console.ReadLine();
        }
    }
}
