using SolidConcepts.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidConcepts.Domain
{
    public class Message : IMessage
    {
        public string _message { get; private set;  }
        public ICache _cache { get; private set; }

        public Message(string message, ICache cache)
        {
            _message = message;
            _cache = cache;
        }

        public virtual string Print()
        {
            return $"Message: { _message }";
        }
    }
}
