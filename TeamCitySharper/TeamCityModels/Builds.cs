using System.Collections.Generic;

namespace TeamCitySharper.TeamCityModels
{
    class Builds
    {
        public List<Build> Build { get; set; }
        public int Count { get; set; }
        public string Href { get; set; }
        public string NextHref { get; set; }
    }
}
