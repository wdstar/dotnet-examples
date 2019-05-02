using System;
using Newtonsoft.Json;

namespace dotnet_examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var jsonText = JsonConvert.SerializeObject(new { key = "value" });
            Console.WriteLine(jsonText);
        }
    }
}
