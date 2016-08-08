using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Security.Policy;
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

        public static string GetDataURL(this Image img)
        {
            var ms = new MemoryStream();
            img.Save(ms, ImageFormat.Png);

            return "data:image/png;base64," + Convert.ToBase64String(ms.ToArray());
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