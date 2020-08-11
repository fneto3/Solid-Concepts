using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace SolidConcepts.Repository
{
    public class CacheRepository
    {
        // Here i can use different technologies to implement the cache.
        private MemoryCache _cache = new MemoryCache(new MemoryCacheOptions());

        public string Get(string key)
        {
            string message;

            if(_cache.TryGetValue(key, out message))
            {
                return message;
            }

            return string.Empty;
        }

        public void Set(string key, string message)
        {
            _cache.Set(key, message);
        }
    }
}
