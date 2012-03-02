using System;
using System.Collections.Generic;

namespace FubuCore.Util
{
    public interface IKeyValues
    {
        bool ContainsKey(string key);
        string Get(string key);
        IEnumerable<string> GetKeys();

        bool ForValue(string key, Action<string, string> callback);
    }
}