using SolidConcepts.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidConcepts.Domain
{
    /// <summary>
    /// This object return a formatted message.
    /// </summary>
    public class Message : IMessage
    {
        /// <summary>
        /// The message to format.
        /// </summary>
        public string _message { get; private set;  }

        /// <summary>
        /// Cache that is used to cache the message.
        /// </summary>
        public ICache _cache { get; private set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="message">Message to format.</param>
        /// <param name="cache">Object cache to store.</param>
        public Message(string message, ICache cache)
        {
            _message = message;
            _cache = cache;
        }

        /// <summary>
        /// Format the message.
        /// </summary>
        /// <returns>Formatted message.</returns>
        public virtual string Print()
        {
            return $"Message: { _message }";
        }
    }
}
