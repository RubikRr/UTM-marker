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
    public partial class UtmCreator : Form
    {
        public List<Site> SitesWithLinks { get; set; }
        List<Website> Sources = new List<Website>();
        ListBox SitesList = new ListBox();
        public UtmCreator(List<Site> sitesWithLinks,List<Website> utmLinks, ListBox sitesList)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            SitesWithLinks = sitesWithLinks;
            Sources = utmLinks;
            SitesList = sitesList;
        }

        private bool SiteExistenceCheck(string siteName)=> SitesList.Items.Contains(siteName);

        private void CreateUtmLinks_Click(object sender, EventArgs e)
        {
            string courseName = Site.Text;
            string url = Link.Text;

            if (SiteExistenceCheck(courseName))
            {
                DialogResult dialogResult = MessageBox.Show("Сайт с таким названием существует.\nХотите создать сайт с таким же названием?", "Подтверждение", MessageBoxButtons.YesNo);
                if(dialogResult==DialogResult.No)
                    return;
            }
            Sources.ForEach(site => site.UTMparam.AddUTMmark(url));
            //try
            //{
            //    Websites.ForEach(site => site.UTMparam.CreateShortLink(site.UTMparam.LinkForApi));
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"{ex.Message}\nКороткая ссылка не была добавлена");
            //}
            SitesList.Items.Add(courseName);
            var site = new Site(courseName, url, Sources);
            SitesWithLinks.Add(site);

            JsonWorker.SerializeJson(SitesWithLinks);
            MessageBox.Show("Сайт добавлен");
            this.Close();

        }
       
        private void UtmCreator_Load(object sender, EventArgs e)
        {
            
        }
    }
}
