using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static class HelloWorld
    {
        public static void helloWorld()
        {
            Console.WriteLine("HelloWorld!!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld.helloWorld();
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Arg[{0}]=[{1}]", i, args[i]);
            }
        }
        
    }
}
