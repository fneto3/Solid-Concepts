using SolidConcepts.Domain.Interface;
using SolidConcepts.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidConcepts.Domain
{
    public class LogMessage : Message
    {
        private readonly CacheRepository _logMessageRepository;
        private readonly ICache _cache;

        public LogMessage(string message, ICache cache)
            :base(message, cache)
        {
            _logMessageRepository = new CacheRepository();
        }

        public override string Print()
        {
            if(!string.IsNullOrWhiteSpace(base._message))
            {
                base._cache.Set("lastMessageLog", $"Date: { DateTime.Now.ToShortTimeString() }");
            }

            return base.Print();
        }
    }
}
