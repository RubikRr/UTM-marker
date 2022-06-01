using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTM_marker
{
    internal class UtmLink
    {
        public string Source { get; }
        public string Medium { get; }
        public string Campaign { get; }

        public string Link { get; set; }

        public UtmLink(string source, string medium, string campaign)
        {
            this.Source = source;
            this.Medium = medium;
            this.Campaign = campaign;
            

        }
        public void AddUTMmark(string url)
        {
            Link= $"{url}?utm_source={Source}&utm_medium={Medium}&utm_campaign={Campaign}";
        }
    }
}
