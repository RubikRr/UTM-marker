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

        static public void SerializeUtmLinksJson(List<Website> UtmLinks)
        {

        }

        static public List<Website> DeserializeUtmLinksJson()
        {
            List<Website> UtmLinks = new List<Website>();
            using (StreamReader file = File.OpenText(@"jsons\utmlinks.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                UtmLinks = (List<Website>)serializer.Deserialize(file, typeof(List<Website>));
            }
            return UtmLinks ?? new List<Website>();

        }
    }
}
