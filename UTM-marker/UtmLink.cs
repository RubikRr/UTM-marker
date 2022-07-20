using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTM_marker
{
    public class UtmLink
    {
        public string Source { get; }
        public string Medium { get; }
        public string Campaign { get; }
        [JsonIgnore]
        public string LinkForUser { get; set; }
        [JsonIgnore]
        public string LinkForApi{ get; set; }
        [JsonIgnore]
        public string ShortLink { get; set; }

        public UtmLink(string source, string medium, string campaign)
        {
            this.Source = source;
            this.Medium = medium;
            this.Campaign = campaign;
            

        }
        public void AddUTMmark(string url)
        {
           // LinkForUser = $"{url}?utm_source={Source}&utm_medium={Medium}&utm_campaign={Campaign}";

            LinkForUser = $"{url}?utm_source={Source}%26utm_medium={Medium}%26utm_campaign={Campaign}";
            LinkForApi = $"{url}?utm_source={Source}%26utm_medium={Medium}%26utm_campaign={Campaign}";
        }

        public void CreateShortLink(string url)
        {
            ShortLink=GetShortLink(url).Result;
        }

       public  static  async Task<string> GetShortLink(string link)
        {
            var url = $"https://clck.ru/--?url={link}";
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var uri=new Uri(url);
                    var res=client.GetAsync(uri).Result;
                    var ans = res.Content.ReadAsStringAsync();
                    return await ans;
                }

            }
            catch (WebException ex)
            {
                if (ex.Response == null) throw; 
                    return null;
            }
        }
    }
}
