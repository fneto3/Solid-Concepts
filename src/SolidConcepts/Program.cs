using System;
using Microsoft.Extensions.Caching.Memory;
using SolidConcepts.Domain;
using SolidConcepts.Domain.Interface;

namespace SolidConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            var cache = new Cache();

            IMessage message = new Message("Hello World", cache);
            IMessage logMessage = new LogMessage("Hello World", cache);

            Console.WriteLine(message.Print());

            Console.WriteLine(logMessage.Print());
            Console.WriteLine(cache.Get("lastMessageLog"));

            Console.ReadLine();
        }
    }
}
