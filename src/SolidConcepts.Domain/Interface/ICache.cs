using System;
using System.Collections.Generic;
using System.Text;

namespace SolidConcepts.Domain.Interface
{
    /// <summary>
    /// Use this interface to create a control that impements cache configurations.
    /// </summary>
    public interface ICache
    {
        /// <summary>
        /// Set the value on cache.
        /// </summary>
        /// <param name="key">A key in pattern MessageID:User.</param>
        /// <param name="message">Message that you want to add/update.</param>
        void Set(string key, string message);

        /// <summary>
        /// Get the value on cache.
        /// </summary>
        /// <param name="key">The key that you want to find.</param>
        /// <returns>The value of the key or empty string if doesn't exist.</returns>
        string Get(string key);
    }
}
