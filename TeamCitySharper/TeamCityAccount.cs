using System;

namespace TeamCitySharper
{
    public class TeamCityAccount
    {
        public string ServerUrl { get; private set; }
        public string User { get; private set; }
        public string Password { get; private set; }

        public TeamCityAccount(string username, string password, string baseurl, bool useSSL = false)
        {
            User = username;
            Password = password;

            if (!baseurl.StartsWith("http://") || !baseurl.StartsWith("https://"))
            {
                var prefix = useSSL ? "https://" : "http://";
                baseurl = prefix + baseurl;
            }
            ServerUrl = baseurl;
        }


    }
}