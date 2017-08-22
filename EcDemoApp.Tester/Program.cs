using EcDemoApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcDemoApp.Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Person("Alfredo", 25);
            Console.WriteLine($"{obj.Name} {obj.Age}");

            Console.ReadKey();
        }
    }
}
