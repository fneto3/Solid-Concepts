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
            // Creating the cache object.
            // The most important thing here, is that Cache Object needs to implements Get and Set Methods
            // so i'm abstracting what i use, Redis, Memory Cache, ..., this is very usefull when you have
            // distributed softwares.
            var cache = new Cache();

            // Create a object that print a message.
            IMessage message = new Message("Hello World", cache);

            // Create a object that print a message, respecting Liskov Substitution.
            IMessage logMessage = new LogMessage("Hello World", cache);

            // Test - Printing the messages.
            Console.WriteLine(message.Print());
            Console.WriteLine(logMessage.Print());
            Console.WriteLine(cache.Get("lastMessageLog"));

            Console.ReadLine();
        }
    }
}
