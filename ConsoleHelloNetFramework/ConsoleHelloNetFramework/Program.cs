using System;
using System.Linq;
using ClassLibraryNetStandard;

namespace ConsoleHelloNetFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            var userName = args != null && args.Any() ? args[0] : String.Empty;
            Console.WriteLine(User.SayHello(userName));
        }
    }
}
