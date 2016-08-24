using System;
using System.Collections.Generic;

namespace wman_Builder
{
    public static class ServiceLocator
    {
        static Dictionary<string, object> _data = new Dictionary<string, object>();

        public static void Add<T>(string k)
            where T : new()
        {
            _data.Add(k, new T());
        }

        public static void Add<T>(string k, Func<T> initializer)
        {
            _data.Add(k, initializer());
        }

        public static T Get<T>(string k) where T : class
        {
            return _data[k] as T;
        }
    }
}