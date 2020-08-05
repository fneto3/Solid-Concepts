using SolidConcepts.Domain.Interface;
using SolidConcepts.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidConcepts.Domain
{
    public class Cache : ICache
    {
        private readonly CacheRepository _cache;

        public Cache()
        {
            _cache = new CacheRepository();
        }

        public string Get(string key) => _cache.Get(key);

        public void Set(string key, string message) => _cache.Set(key, message);
    }
}
