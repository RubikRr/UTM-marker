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
       
        static public void SerializeJson(List<Site> CoursesWithLinks)
        {
            using (StreamWriter file = File.CreateText(@"jsons\course.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, CoursesWithLinks);
            }
        }

        static public List<Site> DeserializeJson()
        {
            List<Site> CoursesWithLinks = new List<Site>();
            using (StreamReader file = File.OpenText(@"jsons\course.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                CoursesWithLinks = (List<Site>)serializer.Deserialize(file, typeof(List<Site>));
            }
            return CoursesWithLinks = CoursesWithLinks ?? new List<Site>();
            
        }
    }
}
