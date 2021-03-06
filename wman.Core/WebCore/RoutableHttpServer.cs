using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Web;

namespace wman.Core.WebCore
{
    public class RoutableHttpServer : HttpServer
    {
        public RoutableHttpServer(int port) : base(port)
        {
        }

        public override void handleGETRequest(HttpProcessor p)
        {
            Invoke(p, null);
        }
        public override void handlePOSTRequest(HttpProcessor p, StreamReader inputData)
        {
            Invoke(p, inputData);
        }


        Query GetQuery(string uri)
        {
            var q = uri.Split(new[] { '?' }, StringSplitOptions.RemoveEmptyEntries);
            if (q.Length > 1)
            {
                return new Query(HttpUtility.ParseQueryString(q[1]).ToDictionary());
            }
            else
            {
                return new Query();
            }
        }

        private object[] MapParameter(HttpProcessor httpProcessor, MethodInfo m)
        {
            var uri = new Uri(httpProcessor.http_url, UriKind.Relative);
            var ret = new List<object>();

            var query = GetQuery(httpProcessor.http_url);
            if (uri.OriginalString.Contains("?") && uri.OriginalString.Contains("="))
            {
                foreach (var p in m.GetParameters())
                {
                    var conv = TypeDescriptor.GetConverter(p.ParameterType);

                    if (query.ContainsKey(p.Name))
                    {
                        if (conv.CanConvertFrom(typeof (string)))
                        {
                            ret.Add(conv.ConvertFrom(query[p.Name]));
                        }
                        else
                        {
                            ret.Add(query);
                        }
                    }
                    else
                    {
                        ret.Add(null);
                    }
                }
            }
            else
            {
                // if no query given, inject null to all parameters
                for (int index = 0; index < m.GetParameters().Length; index++)
                {
                    ret.Add(null);
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
        
        private void Invoke(HttpProcessor p, StreamReader input)
        {
            var ctrl = RouteTable.MatchController(p.http_url, p);
            var t = ctrl.Value.GetType().GetMethods();

            ctrl.Value.InputStream = input;
            
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
                                    param.Any(_ => _.ParameterType == typeof(Query))
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
    }

    public static class RouteTable
    {
        static List<Type> _controllers = new List<Type>();
        public static IErrorController ErrorController;

        public static void MapRoute(Type controller)
        {
            _controllers.Add(controller);

            if (controller.IsAssignableFrom(typeof (IErrorController)))
            {
                ErrorController = (IErrorController)Activator.CreateInstance(controller);
            }
        }

        public static void Search()
        {
            var ass = Assembly.GetCallingAssembly();
            foreach (var type in ass.GetTypes())
            {
                if (type.BaseType?.FullName == typeof (RouteController).FullName)
                {
                    _controllers.Add(type);
                }
                if (typeof(IErrorController).IsAssignableFrom(type))
                {
                    try
                    {
                        ErrorController = (IErrorController) Activator.CreateInstance(type);
                    }
                    catch
                    {
                        ErrorController = (IErrorController)Activator.CreateInstance(type, new HttpProcessor(null, null));
                    }
                }
            }
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
        public StreamReader InputStream { get; set; }

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

        protected void Header(string key, string value)
        {
            p.httpHeaders.Add(key, value);
        }

        protected void Status(string status)
        {
            p.writeStatus(status);
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
    }
}