using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamCitySharper
{
    public static class ResourceUrls
    {
        private const string BaseUrl = "/app/rest/";

        public static string Project()
        {
            return Url("projects");
        }

        private static string Url(string key)
        {
            return Path.Combine(BaseUrl, key);
        }

        private static Uri Uri(string key)
        {
            return new Uri(Url(key));
        }
    }
}
