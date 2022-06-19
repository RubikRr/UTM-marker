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
       
        static public void SerializeJson(List<Course> CoursesWithLinks)
        {
            using (StreamWriter file = File.CreateText(@"jsons\course.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, CoursesWithLinks);
            }
        }

        static public List<Course> DeserializeJson()
        {
            List<Course> CoursesWithLinks = new List<Course>();
            using (StreamReader file = File.OpenText(@"jsons\course.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                CoursesWithLinks = (List<Course>)serializer.Deserialize(file, typeof(List<Course>));
            }
            return CoursesWithLinks = CoursesWithLinks ?? new List<Course>();
            
        }
    }
}
