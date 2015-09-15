using TeamCitySharper;

namespace TeamCitySharperTests
{
    class Program
    {
        static void Main(string[] args)
        {

            TeamCityAccount account;
            
            if (args.Length < 3 || args[0] == null || args[1] == null || args[2] == null)
            {
                account = new TeamCityAccount("user", "password", "teamcity:port");
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
