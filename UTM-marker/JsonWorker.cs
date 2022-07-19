using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTM_marker
{
    public static class JsonWorker
    {

        static public void SerializeJson(List<Site> SitesWithLinks)
        {
            using (StreamWriter file = File.CreateText(@"jsons\sites.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, SitesWithLinks);
            }
        }

        static public List<Site> DeserializeSitesJson()
        {
            List<Site> SitesWithLinks = new List<Site>();
            using (StreamReader file = File.OpenText(@"jsons\sites.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                SitesWithLinks = (List<Site>)serializer.Deserialize(file, typeof(List<Site>));
            }
            return SitesWithLinks ?? new List<Site>();
        }

        static public void SerializeUtmLinksJson(List<UtmLink> UtmLinks)
        {

        }

        static public List<UtmLink> DeserializeUtmLinksJson()
        {
            List<UtmLink> UtmLinks = new List<UtmLink>();
            using (StreamReader file = File.OpenText(@"jsons\utmlinks.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                UtmLinks = (List<UtmLink>)serializer.Deserialize(file, typeof(List<UtmLink>));
            }
            return UtmLinks ?? new List<UtmLink>();

        }
    }
}
