using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Web;
using wman.Core;
using wman.Core.WebCore;

namespace wman
{
    public class RoutableHttpServer : HttpServer
    {
        public RoutableHttpServer(int port) : base(port)
        {
        }

        public override void handleGETRequest(HttpProcessor p)
        {
            var ctrl = RouteTable.MatchController(p.http_url, p);
            var t = ctrl.Value.GetType().GetMethods();
            
            if (p.http_url.StartsWith(ctrl.Key))
            {
                foreach (var m in t)
                {
                    var att = m.GetCustomAttribute<RouteAttribute>();
                    if (att != null)
                    {
                        if (Regex.IsMatch(p.http_url, att.Pattern))
                        {
                            var param = m.GetParameters();
                            if (param.Length > 0)
                            {
                                m.Invoke(ctrl.Value,
                                    param.Any(_ => _.ParameterType == typeof (Query))
                                        ? UriToParamater(p)
                                        : MapParameter(p, m));
                            }
                            else
                            {
                                m.Invoke(ctrl.Value, null);
                            }
                        }
                    }
                }
            }
        }

        private object[] MapParameter(HttpProcessor httpProcessor, MethodInfo m)
        {
            var uri = new Uri(httpProcessor.http_url, UriKind.Relative);
            var ret = new List<object>();

            var query = HttpUtility.ParseQueryString(uri.OriginalString.Replace("/", ""));
            if (uri.OriginalString.Contains("?"))
            {
                foreach (var p in m.GetParameters())
                {
                    var conv = TypeDescriptor.GetConverter(p.ParameterType);

                    if (conv.CanConvertFrom(typeof (string)))
                    {
                        ret.Add(conv.ConvertFrom(query[p.Name]));
                    }
                    else
                    {
                        ret.Add(query);
                    }
                }
            }

            return ret.ToArray();
        }

        private object[] UriToParamater(HttpProcessor httpProcessor)
        {
            var uri = new Uri(httpProcessor.http_url, UriKind.Relative);
            var ret = new List<object>();

            var query = HttpUtility.ParseQueryString(uri.OriginalString.Replace("/", ""));
            if (uri.OriginalString.Contains("?"))
            {
                ret.Add(query.ToDictionary().ToQuery());
            }

            return ret.ToArray();
        }

        public override void handlePOSTRequest(HttpProcessor p, StreamReader inputData)
        {
            p.writeFailure();
        }
    }

    public static class RouteTable
    {
        static List<Type> _controllers = new List<Type>();

        public static void MapRoute(Type controller)
        {
            _controllers.Add(controller);
        }

        public static KeyValuePair<string, RouteController> MatchController(string url, HttpProcessor p)
        {
            string route = "/";
            Type controller = typeof(RouteController);
            
            foreach (var ctrl in _controllers)
            {
                var att = ctrl.GetCustomAttribute<RouteAttribute>();
                if (att != null)
                {
                    if (Regex.IsMatch(p.http_url, att.Pattern + ".*"))
                    {
                        route = att.Pattern;
                        controller = ctrl;
                    }
                }
            }

            return new KeyValuePair<string, RouteController>(route, (RouteController) Activator.CreateInstance(controller, p));
        }
    }

    public class RouteController
    {
        protected StreamWriter OutputStream { get; }
        public string Route { get; set; }

        HttpProcessor p;

        protected RouteController(HttpProcessor re)
        {
            p = re;
            OutputStream = re.outputStream;
        }

        protected void Success()
        {
            p.writeSuccess();
        }

        protected void Error()
        {
            p.writeFailure();
        }

        protected void Redirect(string url)
        {
            p.httpHeaders.Add("Location", url);
        }
    }

    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public class RouteAttribute : Attribute
    {
        public string Pattern { get; }

        public RouteAttribute(string p)
        {
            Pattern = p;
        }

        public RouteAttribute()
        {
            Pattern = "/";
        }
    }
}