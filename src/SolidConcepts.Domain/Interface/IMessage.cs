using System;
using System.Collections.Generic;
using System.Text;

namespace SolidConcepts.Domain.Interface
{
    /// <summary>
    /// Use this interface to create a control that format a message to print.
    /// </summary>
    public interface IMessage
    {
        /// <summary>
        /// This methods format the message and return to print.
        /// </summary>
        /// <returns>Formatted message</returns>
        string Print();
    }
}
