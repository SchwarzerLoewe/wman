using System.Collections.Generic;
using System.Collections.Specialized;
using wman.Core.WebCore;

namespace wman.Core
{
    public static class Extensions
    {
        public static Dictionary<string, string> ToDictionary(this NameValueCollection col)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            foreach (var k in col.AllKeys)
            {
                dict.Add(k, col[k]);
            }
            return dict;
        }

        public static Query ToQuery(this Dictionary<string, string> dic)
        {
            var q = new Query();

            foreach (var k in dic)
            {
                q.Add(k.Key, k.Value);
            }

            return q;
        }
    }
}