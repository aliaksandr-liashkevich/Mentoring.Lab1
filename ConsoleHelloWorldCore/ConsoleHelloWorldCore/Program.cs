using System;
using System.Collections.Generic;
using ClassLibraryNetStandard;
using Microsoft.Extensions.Configuration;

namespace ConsoleHelloWorldCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();

            builder.AddCommandLine(args, new Dictionary<string, string> {
                ["-UserName"] = "UserName"
            });

            var config = builder.Build();

            var userName = config["UserName"];

            Console.WriteLine(User.SayHello(userName));
        }
    }
}
