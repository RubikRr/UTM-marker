using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTM_marker
{
    public partial class Utm : Form
    {
        public List<Course> SitesWithLinks { get; set; }
        List<Website> websites = new List<Website>();
        ListBox CoursesList = new ListBox();
        public Utm(List<Course> coursesWithLinks, ListBox coursesList)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            SitesWithLinks = coursesWithLinks;
            CoursesList = coursesList;
        }

        private bool SiteExistenceCheck(string siteName)=> CoursesList.Items.Contains(siteName);

        private void CreateUtmLinks_Click(object sender, EventArgs e)
        {
            string courseName = Course.Text;
            string url = Link.Text;
            if (SiteExistenceCheck(courseName))
            {
                MessageBox.Show("NEEEEETUSHKI");
                return;
            }
            CoursesList.Items.Add(courseName);
            foreach (var site in websites)
            {
                site.UTMparam.AddUTMmark(url);
                site.UTMparam.CreateShortLink(site.UTMparam.LinkForApi);
            }
            var course = new Course(courseName, url, websites);
            SitesWithLinks.Add(course);

            JsonWorker.SerializeJson(SitesWithLinks);

            MessageBox.Show("Курс создан");
            this.Close();

        }
       
        private void UtmCreator_Load(object sender, EventArgs e)
        {
            var VkSite = new Website("Vk", new UtmLink("myAnalytics", "social", "vk"));
            var TgSite = new Website("Tg", new UtmLink("myAnalytics", "social", "tg"));
            var InstSite = new Website("Inst", new UtmLink("myAnalytics", "social", "inst"));
            var TaplinkSite = new Website("Taplink", new UtmLink("myAnalytics", "organic", "taplink"));
            var EmailSite = new Website("Email", new UtmLink("myAnalytics", "email", "stepik"));
            websites.AddRange(new Website[] { VkSite, TgSite, InstSite, TaplinkSite, EmailSite });
        }
    }
}
