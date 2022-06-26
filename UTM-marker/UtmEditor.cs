﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTM_marker
{
    public partial class UtmEditor : Form
    {
        public List<Site> SitesWithLinks { get; set; }
        List<Website> Websites = new List<Website>();
        ListBox SitesList = new ListBox();
        private int selectedItemIndex;
        public UtmEditor(List<Site> sitesWithLinks, ListBox sitesList,int selectedItemIndex)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            SitesWithLinks = sitesWithLinks;
            SitesList = sitesList;
            this.selectedItemIndex= selectedItemIndex;
        }
        private bool SiteExistenceCheck(string siteName) => SitesList.Items.Contains(siteName);
        private void ChangeUtmLinks_Click(object sender, EventArgs e)
        {
            string courseName = Site.Text;
            string url = Link.Text;

            if (SiteExistenceCheck(courseName))
            {
                DialogResult dialogResult = MessageBox.Show("Сайт с таким названием существует.\nХотите создать сайт с таким же названием?", "Подтверждение", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                    return;
            }
            Websites.ForEach(site => site.UTMparam.AddUTMmark(url));
            try
            {
                Websites.ForEach(site => site.UTMparam.CreateShortLink(site.UTMparam.LinkForApi));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\nКороткая ссылка не изменена");
            }
            SitesList.Items[selectedItemIndex]=courseName;
            var site = new Site(courseName, url, Websites);
            SitesWithLinks[selectedItemIndex]=(site);

            JsonWorker.SerializeJson(SitesWithLinks);
            MessageBox.Show("Сайт был изменен");
            SitesList.SetSelected(selectedItemIndex, true);
            this.Close();
        }

        private void UtmEditor_Load(object sender, EventArgs e)
        {
            Site.Text = SitesWithLinks[selectedItemIndex].Name;
            Link.Text= SitesWithLinks[selectedItemIndex].Link;

            var VkSite = new Website("Vk", new UtmLink("myAnalytics", "social", "vk"));
            var TgSite = new Website("Tg", new UtmLink("myAnalytics", "social", "tg"));
            var InstSite = new Website("Inst", new UtmLink("myAnalytics", "social", "inst"));
            var TaplinkSite = new Website("Taplink", new UtmLink("myAnalytics", "organic", "taplink"));
            var EmailSite = new Website("Email", new UtmLink("myAnalytics", "email", "stepik"));
            var YouTubeSite = new Website("YouTube", new UtmLink("myAnalytics", "social", "youtube"));
            var PersonalSite = new Website("Personal", new UtmLink("myAnalytics", "organic", "personal"));
            Websites.AddRange(new Website[] { VkSite, TgSite, InstSite, TaplinkSite, EmailSite, YouTubeSite, PersonalSite });
        }
    }
}
