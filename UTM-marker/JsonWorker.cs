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

        static public List<Site> DeserializeJson()
        {
            List<Site> SitesWithLinks = new List<Site>();
            using (StreamReader file = File.OpenText(@"jsons\sites.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                SitesWithLinks = (List<Site>)serializer.Deserialize(file, typeof(List<Site>));
            }
            return SitesWithLinks ?? new List<Site>();
            
        }
    }
}
