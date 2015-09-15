using System;
using System.IO;

namespace TeamCitySharper
{
    public static class ResourceUrls
    {
        private const string BaseUrl = "/app/rest/";

        public static string Projects()
        {
            return Url("projects");
        }        
        
        public static string BuildTypes()
        {
            return Url("buildTypes");
        }        
        
        public static string Builds()
        {
            return Url("builds");
        }

        public static string Builds(int count)
        {
            return Url(string.Format("builds/?count={0}", count));
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
