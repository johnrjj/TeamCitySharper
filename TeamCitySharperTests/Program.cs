using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamCitySharper;

namespace TeamCitySharperTests
{
    class Program
    {
        static void Main(string[] args)
        {

            TeamCityAccount account;

            if (args[0] == null || args[1] == null || args[2] == null)
            {
                account = new TeamCityAccount("username", "password", "teamcity:8001");
            }
            else
            {
                account = new TeamCityAccount(args[0], args[1], args[2]);
            }

            var client = new TeamCityClient(account);
            var projects = client.GetProjects();
        }
    }
}
