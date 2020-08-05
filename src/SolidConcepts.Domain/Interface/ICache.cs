using System;
using System.Collections.Generic;
using System.Text;

namespace SolidConcepts.Domain.Interface
{
    public interface ICache
    {
        void Set(string key, string message);
        string Get(string key);
    }
}
