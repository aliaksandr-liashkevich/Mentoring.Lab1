using System;
using System.Linq;
using ClassLibraryNetStandard;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var userName = args != null && args.Any() ? args[0] : string.Empty;
            Console.WriteLine(User.SayHello(userName));
        }
    }
}
