using SolidConcepts.Domain.Interface;
using SolidConcepts.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidConcepts.Domain
{
    /// <summary>
    /// This object save a log of a message and return a formatted message.
    /// </summary>
    public class LogMessage : Message
    {
        /// <summary>
        /// Cahce repo.
        /// </summary>
        private readonly CacheRepository _logMessageRepository;
        
        /// <summary>
        /// Base cache that is used to cache the message.
        /// </summary>
        private readonly ICache _cache;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="message">Message to format.</param>
        /// <param name="cache">Object cache to store.</param>
        public LogMessage(string message, ICache cache)
            :base(message, cache)
        {
            _logMessageRepository = new CacheRepository();
        }

        /// <summary>
        /// Override the print method to allow some logs.
        /// </summary>
        /// <returns>Formatted message.</returns>
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
